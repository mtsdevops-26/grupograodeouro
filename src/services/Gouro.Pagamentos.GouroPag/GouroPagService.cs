namespace Gouro.Pagamentos.GouroPag
{
    public class GouroPagService
    {
        public readonly string ApiKey;
        public readonly string EncryptionKey;

        public GouroPagService(string apiKey, string encryptionKey)
        {
            ApiKey = apiKey;
            EncryptionKey = encryptionKey;
        }
    }
}