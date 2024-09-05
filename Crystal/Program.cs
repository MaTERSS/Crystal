/*
Легенда: 
Вы приходите в магазин и хотите купить за своё золото кристаллы. 
В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить? 
После сделки у вас остаётся какое-то количество золота в кошельке и появляется какое-то количество кристаллов.

Формально: 
При старте программы пользователь вводит начальное количество золота. 
Потом ему предлагается купить какое-то количество кристаллов по цене N(задать в программе самому). 
Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран. 

Проверять на то, что у игрока достаточно денег не нужно. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное количество золота");
            int gold;
            string input = Console.ReadLine();
            gold = Convert.ToInt32(input);
            int crystalPrice = 175;
            int purchasedСrystals;
            purchasedСrystals = gold / crystalPrice;
            int goldResidue = gold - purchasedСrystals * crystalPrice;
            Console.WriteLine("Вы купили:"+purchasedСrystals+"кристаллов.У вас осталось:" + goldResidue + "золота");
        }
    }
}
