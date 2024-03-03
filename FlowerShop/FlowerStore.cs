using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class FlowerStore
    {
        private string name;
        private List<Flower> flowers;
        public FlowerStore(string name)
        {
            Name = name;
            flowers = new List<Flower>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid flower store name!");
                }
                name = value;
            }
        }

        public void AddFlower(Flower flower)
        {
            if (!flowers.Contains(flower))
            {
                flowers.Add(flower);
            }
        }

        public bool SellFlower(Flower flower)
        {
            for (int i = 0; i < flowers.Count; i++)
            {
                if (flowers[i].Type == flower.Type)
                {
                    flowers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Flower flower in flowers)
            {
                totalPrice += flower.Price;
            }
            return totalPrice;
        }

        public Flower GetFlowerWithHighestPrice()
        {
            List<Flower> maxFlowers = flowers.OrderByDescending(P => P.Price).ToList();
            return maxFlowers[0];
        }

        public Flower GetFlowerWithLowestPrice()
        {
            if (flowers.Count == 0)
            {
                return null;
            }
            Flower lowestPriceFlower = flowers[0];
            foreach (Flower flower in flowers)
            {
                if (flower.Price < lowestPriceFlower.Price)
                {
                    lowestPriceFlower = flower;
                }
            }
            return lowestPriceFlower;
        }

        public void RenameFlowerStore(string newName)
        {
            Name = newName;
        }

        public void SellAllFlowers()
        {
            flowers.Clear();
        }

        public override string ToString()
        {
            if (flowers.Count == 0)
            {
                return $"Flower store {Name} has no available flowers.";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Flower store {Name} has {flowers.Count} flower/s:");
                foreach (Flower flower in flowers)
                {
                    sb.AppendLine($"Flower {flower.Type} with color {flower.Color} costs {flower.Price:F2}");
                }
                return sb.ToString();
            }
        }
    }


