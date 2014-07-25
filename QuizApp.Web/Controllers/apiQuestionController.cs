using QuizApp.Web.Adapters._adapters;
using QuizApp.Web.Adapters._interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizApp.Web.Controllers
{
    public class apiQuestionController : ApiController
    {
        private IQuestion _adapter;
        public apiQuestionController()
        {

            _adapter = new QuestionAdapter();


        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            if(id == -1){

            return Ok();
            }
            return Ok();
            
            }
    }
}
