using QuizApp.Data;
using QuizApp.Web.Adapters._interfaces;
using QuizApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizApp.Web.Adapters._adapters
{
    public class QuestionAdapter : IQuestion
    {

        public QuestionVM GetQuestion(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            QuestionVM question = db.Questions.Where(q => q.Id == id).Select(
                q => new QuestionVM 
                {
                    Prompt = q.Prompt,
                    Answer1 = q.Answer.Answer1, 
                    Answer2 = q.Answer.Answer2,
                    Answer3 = q.Answer.Answer3,
                    Answer4 = q.Answer.Answer4
                }).FirstOrDefault();
            return question;
     
        }
    }
}