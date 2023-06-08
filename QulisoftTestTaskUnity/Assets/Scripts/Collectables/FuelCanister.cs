using QulisoftTestTask.Player;

namespace QulisoftTestTask.Collectables
{
    public class FuelCanister : Collectable
    {
        private FuelController _fuelController;
        
        protected override void Collect()
        {
            _fuelController = (FuelController) _collector;
            _fuelController.Refuel();
            
            Destroy(gameObject);
        }
    }
}