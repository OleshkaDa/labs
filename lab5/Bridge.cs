using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    interface IDelivery
    {
        void Deliver(string product);
    }

    class CourierDelivery : IDelivery
    {
        public void Deliver(string product)
        {
            Console.WriteLine("Курьер доставил: " + product);
        }
    }

    class PostDelivery : IDelivery
    {
        public void Deliver(string product)
        {
            Console.WriteLine("Отправлено почтой: " + product);
        }
    }

    abstract class DeliveryOrder
    {
        protected IDelivery delivery;

        public DeliveryOrder(IDelivery delivery)
        {
            this.delivery = delivery;
        }

        public abstract void Send();
    }

    class RegularOrder : DeliveryOrder
    {
        public RegularOrder(IDelivery delivery) : base(delivery) { }

        public override void Send()
        {
            delivery.Deliver("Обычный заказ");
        }
    }

    class FragileOrder : DeliveryOrder
    {
        public FragileOrder(IDelivery delivery) : base(delivery) { }

        public override void Send()
        {
            delivery.Deliver("Хрупкий заказ");
        }
    }
}
