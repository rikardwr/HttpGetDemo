using System;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Web.Http;
using Windows.Storage.Streams;
using System.Diagnostics;
using System.Threading.Tasks;
using DBLibary;

namespace HttpGetDemo
{
    public sealed partial class MainPage : Page
    {
        public object Output { get; private set; }
        public object Input_Box { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
            //var db = new DbContext();
            //db.Database.EnsureCreated();

        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
            var headers = httpClient.DefaultRequestHeaders;
            string header = "ie";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";

            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            Uri requestUri = new Uri("http://localhost192.168.50.14:8000");
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();
            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(new Uri("http://localhost:8000/partData/1000"));
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }
        }

        // Is a syncronous method to get the data from the server
        // when a button event is clicked on the UI
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ///HttpClient sends a GET request to the specified Uri and returns the response body as a string.
            ///
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
            var headers = httpClient.DefaultRequestHeaders;
            string header = "ie";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";

            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            Uri requestUri = new Uri("http://localhost:8000");
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();
            string httpResponseBody = "";
            try
            {
                
                httpResponse = await httpClient.GetAsync(new Uri("http://localhostlocalhost:8000/"));
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }

            
        }
        private async Task Button_Click_2Async(object sender, RoutedEventArgs e)
        {

            try
            {
                Encoding unicode = new System.Text.UnicodeEncoding();
                byte[] unicodeBytes = unicode.GetBytes("Hello World");
                Uri uri = new Uri("http://localhost:8000/");

                Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
                var headers = httpClient.DefaultRequestHeaders;
                string header = "ie";

                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }
                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";

                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }
                
                


                // Construct the JSON to post.
                HttpStringContent content = new HttpStringContent(
             "{ \"PartId\": \"Eliot\" }",
             Windows.Storage.Streams.UnicodeEncoding.Utf8,
             "application/json");
                
                // HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(
                //uri,
                //content);

                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(
                    uri,
                    content);

                httpResponseMessage.EnsureSuccessStatusCode();
                var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                //var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                Debug.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
        private async void Get_Event(object sender, RoutedEventArgs e)
        {
            ///HttpClient sends a GET request to the specified Uri and returns the response body as a string.
            ///
            HttpClient httpClient = new HttpClient();
            var headers = httpClient.DefaultRequestHeaders;
            string header = "ie";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            Uri requestUri = new Uri("http://localhost192.168.50.14:8000");
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(new Uri("http://localhostlocalhost192.168.50.14:8000/"));
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }
        }
        private async void Post_event(object sender, RoutedEventArgs e)
        {
            try
            {
                Encoding unicode = new System.Text.UnicodeEncoding();
                byte[] unicodeBytes = unicode.GetBytes("Hello World");
                Uri uri = new Uri("http://localhostlocalhost192.168.50.14:8000/");

                Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
                var headers = httpClient.DefaultRequestHeaders;
                string header = "ie";

                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }
                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";

                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }
                // Construct the JSON to post.
                HttpStringContent content = new HttpStringContent(
             "{ \"Value\": \"Value1\" }",
             Windows.Storage.Streams.UnicodeEncoding.Utf8,
             "application/json");
                // HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(
                //uri,
                //content);
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(
                    uri,
                    content);
                httpResponseMessage.EnsureSuccessStatusCode();
                var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                //var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                Debug.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {   ///HttpClient sends a GET request to the specified Uri and returns the response body as a string.
            ///
            HttpClient httpClient = new HttpClient();
            var headers = httpClient.DefaultRequestHeaders;
            string header = "ie";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
            Uri requestUri = new Uri("http://localhostlocalhost192.168.50.14:8000/partData/1");
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(new Uri("http://localhostlocalhost192.168.50.14:8000/partData/1"));
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }

        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                Encoding unicode = new System.Text.UnicodeEncoding();
                byte[] unicodeBytes = unicode.GetBytes("Hello World");
                Uri uri = new Uri("http://localhostlocalhost192.168.50.14:8000/activeId/1");

                Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
                var headers = httpClient.DefaultRequestHeaders;
                string header = "ie";

                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }
                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";

                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }
                // Construct the JSON to post.
                HttpStringContent content = new HttpStringContent(
             "{ \"Value\": \"Value1\" }",
             Windows.Storage.Streams.UnicodeEncoding.Utf8,
             "application/json");
                // HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(
                //uri,
                //content);
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(
                    uri,
                    content);
                httpResponseMessage.EnsureSuccessStatusCode();
                var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                //var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                Debug.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}



