using System.Collections.Generic;

namespace WorkGroupProject.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<Menu> Children { get; set; } = new HashSet<Menu>();
    }
}