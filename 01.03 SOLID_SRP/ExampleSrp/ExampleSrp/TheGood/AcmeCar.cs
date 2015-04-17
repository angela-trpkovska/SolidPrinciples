using ExampleSrp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class AcmeCar
    {
        ILoggerException objectLoggerException;
        ILoggerState objectLoggerState;


        public LockState IsLocked { get; private set; }


        public AcmeCar(ILoggerException objectLoggerException, ILoggerState objectLoggerState)
        {
            this.objectLoggerException = objectLoggerException;
            this.objectLoggerState = objectLoggerState;
        }


        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                if(objectLoggerState!=null)
                objectLoggerState.LogChangeState("CarLocked");

            }
            catch (Exception)
            {
                objectLoggerException.LockException();
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //
                if (objectLoggerState != null)
                objectLoggerState.LogChangeState("CarUnlocked");

            }
            catch (Exception)
            {
                objectLoggerException.UnlockException();

            }

        }
    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }


}

