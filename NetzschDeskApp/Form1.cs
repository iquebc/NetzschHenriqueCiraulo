using NetzschDeskApp.Model;
using RestSharp;
using System.Text.Json;

namespace NetzschDeskApp;

public partial class Form1 : Form
{
    public readonly string _API = "https://localhost:7288";
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSendMessage_Click(object sender, EventArgs e)
    {
        try
        {
            var options = new RestClientOptions(_API)
            {
                RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
            };
            var client = new RestClient(options);
            var request = new RestRequest("Message", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new { message = txtMessage.Text, userName = txtUserName.Text });

            RestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Message Sent Sucefully");
                RefreshMessage();
            }
            else
            {
                throw new Exception($"Error: {response.ErrorMessage}");
            }

        }
        catch (System.Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnRefreshMessage_Click(object sender, EventArgs e)
    {
        RefreshMessage();
    }

    public void RefreshMessage()
    {
        var options = new RestClientOptions(_API)
        {
            RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
        };
        var client = new RestClient(options);
        var request = new RestRequest("message", Method.Get);

        RestResponse response = client.Execute(request);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            txtMessages.Text = String.Empty;
            string responseData = response.Content;
            List<MessageModel>? messages = JsonSerializer.Deserialize<List<MessageModel>>(responseData);
            foreach(MessageModel message in messages)
            {
                txtMessages.Text += $"{message.sender.name}: {message.message} {Environment.NewLine}";
            }
        }
        else
        {
            throw new Exception($"Error: {response.ErrorMessage}");
        }
    }
}
