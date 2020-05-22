using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Game_Forms.Entities
{
    class BaseEntity
    {
        private float HealthPoints { get; set; }
        private float MaxHealthPoints { get; set; }

        public BaseEntity(float healthPoints, float maxHealthPoints)
        {
            HealthPoints = healthPoints;
            MaxHealthPoints = maxHealthPoints;
        }

        public float GetHealth()
        {
            return HealthPoints;
        }
    }
}
