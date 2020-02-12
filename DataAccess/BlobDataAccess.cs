namespace SOAT.Labs.DataAccess
{
    public class BlobDataAccess
    {
        private string storageConnectionString { get; set; }

        public BlobDataAccess(string cnxString)
        {
            this.storageConnectionString = cnxString;
        }

    }
}