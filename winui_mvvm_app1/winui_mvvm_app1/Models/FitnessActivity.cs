using System;

namespace PracticeWork8.Models
{
    public class FitnessActivity
    {
        // Primary key
        public int ActivityId { get; set; }

        // Name of the activity, e.g. "Біг", "Йога"
        public string Title { get; set; }

        // Duration in minutes
        public int DurationInMinutes { get; set; }

        // Calories burned during the activity
        public int CaloriesBurned { get; set; }

        // Date/time of the activity
        public DateTime ActivityDate { get; set; }
    }
}