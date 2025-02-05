namespace delta_demo_web.Models
{
    public class ErrorViewModel
    {
        //Some code changes
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
