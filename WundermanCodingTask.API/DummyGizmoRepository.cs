using System.Collections.Generic;
using System.Linq;

namespace WundermanCodingTask.API
{
    /// <summary>
    /// A simple dummy implementation of IGizmoRepository containing sample data.
    /// </summary>
    public class DummyGizmoRepository : IGizmoRepository
    {
        private readonly Gizmo[] allGizmos = new Gizmo[]
        {
            new Gizmo {
                Name = "Babel fish",
            },
            new Gizmo {
                Name = "Food replicator",
            },
            new Gizmo {
                Name = "Hoverbike",
            },
            new Gizmo {
                Name = "Iconograph",
            },
            new Gizmo {
                Name = "Voight-Kampff machine",
            },
            new Gizmo {
                Name = "Invisibility cloak",
            },
        };

        public IEnumerable<Gizmo> All()
        {
            return allGizmos.ToArray(); // Clone array to prevent caller from modifying private array.
        }
    }
}
