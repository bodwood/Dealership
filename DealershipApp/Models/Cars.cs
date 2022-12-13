using System.Collections.Generic;

namespace DealershipApp.Models
{
    public class Cars
    {
        public string Description { get; set; }
        private static List<Cars> _instances = new List<Cars> { };

        public Cars(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static List<Cars> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}