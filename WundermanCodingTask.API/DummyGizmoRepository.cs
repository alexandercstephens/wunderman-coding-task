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
                Universe = "The Hitchhiker's Guide to the Galaxy",
                ApproximateWeightInGrams = 150,
            },
            new Gizmo {
                Name = "Food replicator",
                Universe = "Star Trek",
                ApproximateWeightInGrams = 20000,
            },
            new Gizmo {
                Name = "Speeder bike",
                Universe = "Star Wars",
                ApproximateWeightInGrams = 80000,
            },
            new Gizmo {
                Name = "Iconograph",
                Universe = "Discworld",
                ApproximateWeightInGrams = 4000,
            },
            new Gizmo {
                Name = "Voight-Kampff machine",
                Universe = "Blade Runner / Do Androids Dream of Electric Sheep?",
                ApproximateWeightInGrams = 10000,
            },
            new Gizmo {
                Name = "Neuralyzer",
                Universe = "Men In Black",
                ApproximateWeightInGrams = 300,
            },
        };

        public IEnumerable<Gizmo> All()
        {
            return allGizmos.ToArray(); // Clone array to prevent caller from modifying private array.
        }
    }
}
