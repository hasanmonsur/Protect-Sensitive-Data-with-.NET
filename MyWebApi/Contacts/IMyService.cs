namespace MyWebApi.Contacts
{
    public interface IMyService
    {
        string GetSecret(string secretkey);
        void PrintSecret();
    }
}