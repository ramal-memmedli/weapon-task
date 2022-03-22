using System;
using WeaponTask.Models;

namespace WeaponTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
        ReEnterMagazineSize:
            Console.Write("Enter Magazine Size : ");
            int magazineSize = Convert.ToInt32(Console.ReadLine());

            if (magazineSize > 0 && magazineSize < 100000)
            {

            }
            else
            {
                goto ReEnterMagazineSize;
            }

        ReEnterRemainBullet:
            Console.Write("Enter Remain Bullet Count : ");


            int remainBulletCount = Convert.ToInt32(Console.ReadLine());
            if (remainBulletCount <= magazineSize && remainBulletCount >= 0)
            {

            }
            else
            {
                goto ReEnterRemainBullet;
            }

            Console.Write("Enter default fire mode (1 - single, 2 - auto) : ");
            int defaultFireMode = Convert.ToInt32(Console.ReadLine());
            bool isSingle = true;
            switch (defaultFireMode)
            {
                case 1:
                    isSingle = true;
                    break;
                case 2:
                    isSingle = false;
                    break;
            }

            Weapon weapon = new Weapon(magazineSize, remainBulletCount, isSingle);


            int choice;
            Console.WriteLine("0 - Get information\n1 - Shoot\n2 - Fire\n3 - Remain bullet count\n4 - Reload weapon\n5 - Change fire mode\n6 - exit\n7 - Edit");
            Console.WriteLine("Enter 6 for exit.");
            do
            {
                Console.Write("Choose the command : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("0 - Get information\n1 - Shoot\n2 - Fire\n3 - Remain bullet count\n4 - Reload weapon\n5 - Change fire mode\n6 - exit\n7 - Edit");
                        break;
                    case 1:
                        Console.WriteLine("------------------------");
                        weapon.Shoot();
                        Console.WriteLine("------------------------");
                        break;
                    case 2:
                        Console.WriteLine("------------------------");
                        weapon.Fire();
                        Console.WriteLine("------------------------");
                        break;
                    case 3:
                        Console.WriteLine("------------------------");
                        weapon.GetRemainBulletCount();
                        Console.WriteLine("------------------------");
                        break;
                    case 4:
                        Console.WriteLine("------------------------");
                        weapon.Reload();
                        Console.WriteLine("------------------------");
                        break;
                    case 5:
                        Console.WriteLine("------------------------");
                        weapon.ChangeFireMode();
                        Console.WriteLine("------------------------");
                        break;
                    case 7:
                        Console.WriteLine("Edit :\n8 - Edit magazine size\n9 - Edit current bullet count");
                        break;
                    case 8:
                    ReEnterNewMagazineSize:
                        Console.Write("Enter magazine size : ");
                        int newMagazineSize = Convert.ToInt32(Console.ReadLine());
                        if (newMagazineSize > weapon.CurrentBulletCount)
                        {
                            weapon.EditMagazineSize(newMagazineSize);
                        }
                        else
                        {
                            goto ReEnterNewMagazineSize;
                        }
                        break;
                    case 9:
                    ReEnterNewCurrentBulletCount:
                        Console.Write("Enter current bullet count : ");
                        int newCurrentBulletCount = Convert.ToInt32(Console.ReadLine());
                        if (newCurrentBulletCount >= 0 && newCurrentBulletCount < weapon.MagazineSize)
                        {
                            weapon.EditBulletCount(newCurrentBulletCount);
                        }
                        else
                        {
                            goto ReEnterNewCurrentBulletCount;
                        }
                        break;
                    default:
                        break;
                }

            } while (choice != 6);
        }
    }
}
