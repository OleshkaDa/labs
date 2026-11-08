using System;

namespace Lab5
{
    interface IOrder
    {
        void Show();
    }

    class Order : IOrder
    {
        public void Show()
        {
            Console.WriteLine("Информация о заказе: №125, сумма 3000 руб.");
        }
    }

    class OrderProxy : IOrder
    {
        private Order order = new Order();
        private bool isOwner;

        public OrderProxy(bool owner)
        {
            isOwner = owner;
        }

        public void Show()
        {
            if (isOwner)
                order.Show();
            else
                Console.WriteLine("Доступ запрещён!");
        }
    }

    class Proxy
    {
        static void Main()
        {
            IOrder order = new OrderProxy(false);
            order.Show();

            IOrder ownerOrder = new OrderProxy(true);
            ownerOrder.Show();
        }
    }
}