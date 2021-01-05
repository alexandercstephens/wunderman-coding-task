using System.Collections.Generic;

namespace WundermanCodingTask.API
{
    public interface IGizmoRepository
    {
        public IEnumerable<Gizmo> All();
    }
}
