using QuizApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Web.Adapters._interfaces
{
    public interface IQuestion
    {
        QuestionVM GetQuestion(int id);
    }
}
