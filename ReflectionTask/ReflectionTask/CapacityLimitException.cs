using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTask
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }
    }
}
