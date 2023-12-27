using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace TestWinForms1
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "0c2ea2e4737953f301830438b345d112";

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private async void button1_Click(object sender, EventArgs e)
        {
            string city = CityTextBox.Text;

            HttpClient client = new HttpClient();
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                // ������������� System.Text.Json ��� ������� JSON
                JsonDocument jsonDoc = JsonDocument.Parse(responseBody);

                // ��������� ������ � �����������, �������� � �������� �����
                var root = jsonDoc.RootElement;
                string temperature = root.GetProperty("main").GetProperty("temp").GetDouble().ToString() + "�C";
                string description = root.GetProperty("weather")[0].GetProperty("description").GetString();
                string wind_Speed = root.GetProperty("wind").GetProperty("speed").GetDouble().ToString() + " m/s";

                // ��������� ������ � Label ��� ����������� ���������� � ������
                temp.Text = $"�����������: {temperature}";
                descriptio.Text = $"��������: {description}";
                windSpeed.Text = $"�������� �����: {wind_Speed}";

                jsonDoc.Dispose(); // �� ��������� ����������� ������� JsonDocument
            }
            else
            {
                MessageBox.Show("������ ��� ��������� ������ � ������.");
            }
        }

    }
}
