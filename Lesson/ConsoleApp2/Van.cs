﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    public class Van : Car
    {
        private int mileage = 0;
        private int maxCarrying = 5000;
        private int carrying = 100;

        public Van(int carrying, int mileage, Insurance insurance, string carName, int id, double price) : base(id, carName, price)
        {
            Carrying = carrying;
            Mileage = mileage;
            Insurance = insurance;
        }

        public override string Name { get; set => throw new NotImplementedException(); }


        //public override string Name => "Van";

        public override int GetSpeed()
        {
            return 90;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public Insurance Insurance { get; set; }

        public int Carrying
        {
            get => carrying;
            set
            {
                if (value < 0 || value > maxCarrying)
                {
                    System.Console.WriteLine("Invalid Input");
                }
                else
                {
                    carrying = value;
                }
            }
        }

        public int Mileage
        {
            get => mileage;
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Invalid Input");
                }
                else
                {
                    mileage = value;
                }
            }
        }
    }
}
