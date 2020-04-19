using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Work : IEntity
    {
      
        public int Id { get; set; }

      
        public string Name { get; set; }

        
        public bool Status { get; set; }
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
