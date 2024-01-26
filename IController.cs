using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstGame
{
    internal interface IController
    {
        public void Update()
        { }
        public void RegisterCommand(Keys key, ICommand command)
        { }
        }
}
