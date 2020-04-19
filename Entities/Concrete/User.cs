using System.Collections.Generic;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public List<Work> Works { get; set; }
    }
}
