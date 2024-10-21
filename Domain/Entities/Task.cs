using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Task
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }

        public Task(string id, string title, string description, string userId)
        {
            Id = id;
            Title = title;
            Description = description;
            UserId = userId;
        }
    }
}
