using Azure.Storage.Blobs;

namespace BlobDataInsert
{
    public class StorageConfiguration
    {
        private string ConnectString;

        public StorageConfiguration(string connectString)
        {
            this.ConnectString = connectString;
        }

        public BlobContainerClient ConfigClouldStoraAccount()
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(this.ConnectString);

            return blobServiceClient.GetBlobContainerClient("poc-blob");
        }
    }
}
