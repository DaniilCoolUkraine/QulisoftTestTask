using System;

namespace QulisoftTestTask.Player
{
    public interface IPlayerInput
    {
        public event Action<bool> IsAccelerating;
        public event Action<bool> IsBraking;
    }
}
