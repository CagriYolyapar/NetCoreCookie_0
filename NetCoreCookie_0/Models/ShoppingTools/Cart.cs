namespace NetCoreCookie_0.Models.ShoppingTools
{
    public class Cart
    {
        Dictionary<int, CartItem> _myCart;

        public Cart()
        {
            _myCart = new Dictionary<int, CartItem>();
        }

        public List<CartItem> MyCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }


        public void AddToCart(CartItem item)
        {
            if (_myCart.ContainsKey(item.ID))
            {
                item.Amount++;
                return;
            }
            _myCart.Add(item.ID, item);
        }
    }
}
