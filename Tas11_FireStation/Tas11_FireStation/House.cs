using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tas11_FireStation
{
    
    public delegate void FireHandler();
    
    class House
    {
        
        
        public event FireHandler onFire;

        public void FireInHouse()
        {   
                if(onFire!=null)
                {
                    onFire();
                }
            
        }

    }
}
