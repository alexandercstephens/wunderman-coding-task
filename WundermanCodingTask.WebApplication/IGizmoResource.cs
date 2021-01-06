using System.Collections.Generic;
using System.Threading.Tasks;
using WundermanCodingTask.WebApplication.Models;

namespace WundermanCodingTask.WebApplication
{
    public interface IGizmoResource
    {
        /// <summary>
        /// Return a list of all gizmos.
        /// </summary>
        public Task<IEnumerable<GizmoModel>> Fetch();
    }
}
