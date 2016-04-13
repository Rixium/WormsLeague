﻿using System;

namespace WormsScheme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deserialiser = new WscReader(@"F:\Steam\steamapps\common\Worms Armageddon\User\Schemes\{{01}} Beginner.wsc");
            var model = deserialiser.GetModel();

            var wscCreator = new WscWriter(@"F:\Steam\steamapps\common\Worms Armageddon\User\Schemes\testcreation.wsc");
            wscCreator.WriteModel(model);

            var textFileCreator = new TextFileWriter(@"F:\Steam\steamapps\common\Worms Armageddon\User\Schemes\01_-_uber_coolest_options.txt");
            textFileCreator.WriteModel(model);

            var textFileReader = new TextFileReader(@"F:\Steam\steamapps\common\Worms Armageddon\User\Schemes\01_-_uber_coolest_options.txt");
            var finalModel = textFileReader.GetModel();


            Console.WriteLine(model.Signature);
            Console.WriteLine(model.Version);
            Console.WriteLine(model.HotSeatDelay);
            Console.WriteLine(model.RetreatTime);
            Console.WriteLine(model.RopeRetreatTime);
            Console.WriteLine(model.HealthCrateProbability);
            Console.WriteLine(model.SheepHeaven);

            foreach (var weapon in model.Weapons)
            {
                Console.WriteLine(weapon.Name);
                Console.WriteLine(weapon.Ammo);
                Console.WriteLine(weapon.Power);
                Console.WriteLine(weapon.Delay);
                Console.WriteLine(weapon.CrateProbability);
            }
            
            Console.ReadKey();
        }
    }
}
