namespace Article_programm.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string Tags { get; set; }
        public int Views { get; set; }
    }
}
