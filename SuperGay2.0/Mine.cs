using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGay2._0
{
    internal class Mine
    {
        public int Ore { get; set; } = 0;
        public int Worker { get; set; } = 1;
        public void Tick()
        {
            Ore += Worker;
        }
        public void SellOre(FormMine formMine, ref int Balance)
        {
            if (formMine.isButtonSell == false)
            {
                return;
            }

            if (Ore >= formMine.SellOre())
            {
                Ore -= formMine.SellOre();
                Balance += formMine.SellOre();

                formMine.Clear();
            }
        }

        public void BuyWorker(FormMine formMine, ref int Balance)
        {
            if (formMine.isButtonBuy == false)
            {
                return;
            }
            if (Balance >= 300)
            {
                Balance -= 300;
                Worker += 1;
                formMine.isButtonBuy = false;
            }
        }
    }
}
