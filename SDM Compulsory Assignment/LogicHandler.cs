using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SDM_Compulsory_Assignment
{
    public class LogicHandler : ILogicHandler
    {
        public List<Review> Reviews;

        public LogicHandler()
        {
            using (StreamReader r = new StreamReader("C:/Users/Nijas Hansen/source/repos/SDM_Compulsory_Assignment1/SDM Compulsory Assignment/RESOURCES/SmallRating.json"))
            {
                string json = r.ReadToEnd();
                Reviews = JsonConvert.DeserializeObject<List<Review>>(json);
            }
        }

        public List<Review> getReviews()
        {
            return Reviews;
        }

    }
    
    
}


public class Review
{
    public int Reviewer;
    public int Movie;
    public int Grade;
    public DateTime Date;
}