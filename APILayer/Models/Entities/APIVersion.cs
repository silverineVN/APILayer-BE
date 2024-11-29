namespace APILayer.Models.Entities
{
    public class APIVersion
    {
        public int VersionId { get; set; }
        public int ApiId { get; set; }
        public int VersionNumber { get; set; }
        public string? ChangeLog { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Status { get; set; } = "Active"; //Inactive
                                                       // Relationships
        public API? Api { get; set; }
    }
}
