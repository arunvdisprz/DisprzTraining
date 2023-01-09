using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DisprzTraining.Models
{
    public class PatchAppointmentList
    {
        public string ?patchName {get; set;}
         public string? patchId { get; set; }
        public DateTime patchAppointmentDate { get; set; }
        public DateTime patchAppointmentStartTime { get; set; }
        public DateTime patchAppointmentEndTime { get; set; }
        public string patchStartTime { get; set; } = string.Empty;
        public string patchEndTime { get; set; } = string.Empty;
        public string? patchAppointmentContent { get; set; }
        public string? patchLocation { get; set; }
        public string? patchDescription { get; set; }
        public string? patchColor { get; set; }
    }
}