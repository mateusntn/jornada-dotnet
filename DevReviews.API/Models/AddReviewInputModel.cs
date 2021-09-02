namespace DevReviews.API.Models
{
    public class AddReviewInputModel
    {
        public int Rating { get; set; }
        
        public string Author { get; set; }
        
        public string Comments { get; set; }                
    }
}