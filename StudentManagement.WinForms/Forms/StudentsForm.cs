using StudentManagement.WinForms.Services;
using StudentManagement.WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.WinForms.Forms
{
    public partial class StudentsForm : Form
    {
        private readonly ApiService _api;

        private int _currentPage = 1;

        private const int PageSize = 10;

        private int _totalPages = 1;

        private string _search = string.Empty;

        private string? _sortBy = "Id";
        private bool _ascending = true;

        public StudentsForm(ApiService api)
        {
            InitializeComponent();

            _api = api;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
        }


        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            await LoadStudents();
        }

        private async Task LoadStudents()
        {
            var result = await _api.GetStudentsAsync(_currentPage, PageSize, _search, _sortBy, _ascending);

            if (result == null)
                return;

            dataGridView1.DataSource = result.Items;

            _totalPages =
                (int)Math.Ceiling(
                    (double)result.TotalCount /
                    result.PageSize);

            lblPage.Text =
                $"Page {result.Page} of {_totalPages}";

            btnPrevious.Enabled =
                result.Page > 1;

            btnNext.Enabled =
                result.Page < _totalPages;


            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["StudentFirstName"].HeaderText = "First Name";
            dataGridView1.Columns["StudentLastName"].HeaderText = "Last Name";

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.ColumnHeadersHeight = 40;


            dataGridView1.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns["Id"].Width = 60;

            dataGridView1.Columns["StudentFirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["StudentLastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            txtFirstName.Focus();
        }

        private async void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            var success = await _api.AddStudent(
                new StudentDto
                {
                    StudentFirstName =
                        txtFirstName.Text,

                    StudentLastName =
                        txtLastName.Text
                });

            if (success)
            {
                MessageBox.Show(
                    "Added new student.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearInputs();
                await LoadStudents();
            }
            else
            {
                MessageBox.Show(
                    "Failed to add student.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            var student = (StudentDto)dataGridView1.CurrentRow.DataBoundItem;


            var success = await _api.DeleteStudent(
                student.Id);

            if (success)
            {
                MessageBox.Show(
                    $"Deleted student. Id = {student.Id}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearInputs();
                if (_currentPage > 1 && dataGridView1.Rows.Count == 1)
                {
                    _currentPage--;
                }
                await LoadStudents();
            }
            else
            {
                MessageBox.Show(
                    "Failed to delete student.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show(
                    "First Name and Last Name are required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var student = (StudentDto)dataGridView1.CurrentRow.DataBoundItem;

            var success = await _api.UpdateStudent(
                student.Id,
                new StudentDto
                {
                    StudentFirstName =
                        txtFirstName.Text,

                    StudentLastName =
                        txtLastName.Text
                });

            if (success)
            {
                MessageBox.Show(
                    $"Updated student. Id = {student.Id}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearInputs();
                await LoadStudents();
            }
            else
            {
                MessageBox.Show(
                    "Failed to update student.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;

                await LoadStudents();
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;

                await LoadStudents();
            }
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            _search = string.Empty;

            _currentPage = 1;

            await LoadStudents();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _search = txtSearch.Text.Trim();

            _currentPage = 1;

            await LoadStudents();
        }

        private async void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

            if (_sortBy == column)
            {
                _ascending = !_ascending;
            }
            else
            {
                _sortBy = column;
                _ascending = true;
            }

            _currentPage = 1;

            await LoadStudents();
        }
    }
}
