using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DeskQuote
    {



        const int basePrice = 200;
        const int pricePerInchSquared = 1;
        const int pricePerDrawer = 50;








        public string CustomerName { get; set; }

        public int RushOrder { get; set; }

        public DateTime QuoteDate { get; set; }

        public int QuotePrice { get; set; }

        public Desk Desk { get; set; }

       

        public DeskQuote(Desk desk)
        {
            this.Desk = desk;

        }

        public int DeskSize()
        {
            int size = Desk.Width * Desk.Depth;
            return size;
        }

        public int GetQuote()
        {
            int drawers = Desk.Drawers;
            int totalPrice;
            int size = DeskSize();
            string material = Desk.DeskMaterial;
            int materialPrice = 0;
            int rushPrice;
            int sizePrice;


            if (size > 1000)
            {
                sizePrice = (size - 1000) * pricePerInchSquared;
            }
            else
            {
                sizePrice = 0;
            }

            switch (material)
            {
                case "Laminate":
                    materialPrice = (int)Desk.Material.Laminate;
                    break;
                case "Oak":
                    materialPrice = (int)Desk.Material.Oak;
                    break;
                case "Rosewood":
                    materialPrice = (int)Desk.Material.Rosewood;
                    break;
                case "Veneer":
                    materialPrice = (int)Desk.Material.Veneer;
                    break;
                case "Pine":
                    materialPrice = (int)Desk.Material.Pine;
                    break;
            }

            switch (RushOrder)
            {
                case 3:
                    if (size >= 1000 || size <= 2000)
                    {
                        rushPrice = 70;
                    }
                    else if (size > 2000)
                    {
                        rushPrice = 80;
                    }
                    else
                    {
                        rushPrice = 60;
                    }
                    break;
                case 5:
                    if (size >= 1000 || size <= 2000)
                    {
                        rushPrice = 50;
                    }
                    else if (size > 2000)
                    {
                        rushPrice = 60;
                    }
                    else
                    {
                        rushPrice = 40;
                    }
                    break;
                case 7:
                    if (size >= 1000 || size <= 2000)
                    {
                        rushPrice = 35;
                    }
                    else if (size > 2000)
                    {
                        rushPrice = 40;
                    }
                    else
                    {
                        rushPrice = 30;
                    }
                    break;
                default:
                    rushPrice = 0;
                    break;
            }



            totalPrice = basePrice + sizePrice + (pricePerDrawer * drawers) + materialPrice + rushPrice;

            return totalPrice;
        }


    }
