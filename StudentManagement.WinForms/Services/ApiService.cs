using StudentManagement.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentManagement.WinForms.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();

            _client.BaseAddress =
                new Uri("https://localhost:7062/");
        }

        public void SetToken(string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    token);
        }

        public async Task<LoginResponse?> LoginAsync(LoginRequest request)
        {
            var response =
                await _client.PostAsJsonAsync(
                    "token",
                    request);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content
                .ReadFromJsonAsync<LoginResponse>();
        }

        public async Task<PagedResult<StudentDto>?> GetStudentsAsync(int page, int pageSize, string? search = null, string? sortBy = "Id", bool ascending = true)
        {
            var url = $"student?page={page}&pageSize={pageSize}";
            if (!string.IsNullOrWhiteSpace(search))
            {
                url += $"&search={Uri.EscapeDataString(search)}";
            }
            url += $"&sortBy={Uri.EscapeDataString(sortBy ?? "Id")}";
            url += $"&ascending={ascending}";

            var response = await _client.GetAsync(url);
            
            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<PagedResult<StudentDto>>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }

        public async Task<bool> AddStudent(StudentDto dto)
        {
            var response =
                await _client.PostAsJsonAsync(
                    "student",
                    dto);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateStudent(
            int id,
            StudentDto dto)
        {
            var response =
                await _client.PutAsJsonAsync(
                    $"student/{id}",
                    dto);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var response =
                await _client.DeleteAsync(
                    $"student/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
