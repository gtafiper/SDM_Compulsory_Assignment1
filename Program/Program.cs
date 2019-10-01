using System;
using SDM_Compulsory_Assignment;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogicHandler logic = new LogicHandler();
            foreach (var Review in logic.getReviews())
            {
                Console.WriteLine($"List of Reviews {Review.Reviewer}, Movie Number {Review.Movie}, Grade: {Review.Grade}, Date: {Review.Date}");
            }
        }
    }
}