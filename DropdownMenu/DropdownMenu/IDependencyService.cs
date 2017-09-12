using System;
using System.Collections.Generic;
using System.Text;

namespace DropdownMenu
{
    interface IDependencyService
    {
        void SendNotification(string title, string text);
    }
}
