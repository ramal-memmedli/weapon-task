using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponTask.Models
{
    public class Weapon
    {
        public Weapon(int magazineSize, int currentBulletPoint, bool shootMode)
        {
            MagazineSize = magazineSize;
            CurrentBulletCount = currentBulletPoint;
            ShootMode = shootMode;
        }

        public int MagazineSize { get { return _magazineSize; } set { if (value > 0 && value < 100000) _magazineSize = value; } }
        public int CurrentBulletCount { get { return _currentBulletCount; } set { if (value >= 0 && value <= _magazineSize) _currentBulletCount = value; } }
        public bool ShootMode { get; set; }


        private int _magazineSize;
        private int _currentBulletCount;

        public void Shoot()
        {
            if(CurrentBulletCount > 0)
            {
                --CurrentBulletCount;
                Console.WriteLine("Fired");
            }
            else
            {
                Console.WriteLine("Bullet ran out");
            }
        }
        public void Fire()
        {
            if (CurrentBulletCount > 0)
            {
                if (ShootMode == true)
                {
                    --CurrentBulletCount;
                    Console.WriteLine("One bullet fired");
                }
                else
                {
                    CurrentBulletCount = 0;
                    Console.WriteLine("All Bullets Fired");
                }
            }
            else
            {
                Console.WriteLine("Bullet ran out");
            }
        }
        public int GetRemainBulletCount()
        {
            Console.WriteLine(MagazineSize - CurrentBulletCount + " " + "Current bullet count : " + CurrentBulletCount);
            return MagazineSize - CurrentBulletCount;
        }
        public void Reload()
        {
            if(CurrentBulletCount < MagazineSize)
            {
                CurrentBulletCount = MagazineSize;
                Console.WriteLine("Weapon reloaded");
            }
            else
            {
                Console.WriteLine("Weapon already reloaded");
            }
        }
        public void ChangeFireMode()
        {
            if(ShootMode == true)
            {
                ShootMode = false;
            }
            else if(ShootMode == false)
            {
                ShootMode = true;
            }
            Console.WriteLine("Weapon fire mode changed");
        }

        public void EditMagazineSize(int newMagazineSize)
        {
            MagazineSize = newMagazineSize;
            Console.WriteLine($"Magazine size updated to {MagazineSize}");
        }

        public void EditBulletCount(int newBulletCount)
        {
            CurrentBulletCount = newBulletCount;
            Console.WriteLine($"Current bullet count updated to {CurrentBulletCount}");
        }
    }
}
