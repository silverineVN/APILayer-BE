namespace APILayer.Models.Entities
{
    public class APIDocumentation
    {
        public int DocumentationId { get; set; }
        public int ApiId { get; set; }
        public required string DocContent { get; set; }
        public string? IntegrationGuide { get; set; }
        public string? CodeExamples { get; set; }
        public string? Status { get; set; }

        // Relationships
        public API? Api { get; set; }
    }
}
