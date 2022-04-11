using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamageFormula
{
    class SwordDamage
    {
        // create constants for the BASE_DAMAGE and FLAME_DAMAGE
        public const int BASE_DAMAGE = 3;  // 3HP points
        public const int FLAME_DAMAGE = 2;  // 2HP points

        public int Roll;
        public decimal MagicMultiplier = 1M;
        public int FlamingDamage = 0;
        public int Damage;

        public void CalculateDamage()
        {
            // calculate the damage formula
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            // flaming swords cause extra damage in addition to the roll.
            // so the method will have to calculate damage and then add FLAME_DAMAGE to it
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
