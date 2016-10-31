using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketPluginTemplate
{
    public class Main : RocketPlugin
    {
        public static Main Instance;

        protected override void Load()
        {
            Instance = this;
        }

        protected override void Unload()
        {

        }

        private void FixedUpdate()
        {
        }
    }
}
