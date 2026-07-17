using StudentManagement.WinForms.Forms;
using StudentManagement.WinForms.Models;
using StudentManagement.WinForms.Services;

namespace StudentManagement.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly ApiService _api =
            new ApiService();

        private async void btnLogin_Click(
            object sender,
            EventArgs e)
        {
            var result =
                await _api.LoginAsync(
                    new LoginRequest
                    {
                        Login = txtLogin.Text,
                        Password = txtPassword.Text
                    });


            if (result == null)
            {
                MessageBox.Show(
                    "Invalid login or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Clear();
                txtPassword.Focus();

                return;
            }
            _api.SetToken(result.Token);

            var form =
                new StudentsForm(_api);

            form.Show();

            Hide();
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =!txtPassword.UseSystemPasswordChar;
        }
    }
}
