namespace SOAT.Labs.Models
{
    public class ImageItem
    {
        public string Name { get; private set; }
        public string Url { get; private set; }

        public ImageItem(string name, string url)
        {
            this.Name = name; 
            this.Url = url;
        }
    }
}
