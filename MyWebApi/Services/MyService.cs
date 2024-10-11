using MyWebApi.Contacts;

namespace MyWebApi.Services
{
    public class MyService : IMyService
    {
        private readonly IConfiguration _configuration;

        public MyService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetSecret(string secretkey)
        {
            string secret = _configuration[secretkey];

            return secret;
        }

        public void PrintSecret()
        {
            string secret = _configuration["MySecret"];
            Console.WriteLine($"Secret: {secret}");
        }
    }
}
