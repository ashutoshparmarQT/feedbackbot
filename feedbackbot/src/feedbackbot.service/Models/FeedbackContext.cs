using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace feedbackbot.service.Models
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext() : base()
        {
            //TODO: How to pass connection strings to base class
        }

        public FeedbackContext(string connectionString) : base()
        {
            //TODO: How to pass connection strings to base class
        }


    }
}
