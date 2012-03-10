
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ParticleSample
{
	#region Entry Point
#if IPHONE
    [Register("AppDelegate")]
    class Program : UIApplicationDelegate
    {
        ParticleSampleGame game;
        public override void FinishedLaunching(UIApplication app)
        {
            // Fun begins..
            game = new ParticleSampleGame();
            game.Run();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
        }
    }    
#else
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    static class Program
    {
        static void Main()
        {
            using (ParticleSampleGame game = new ParticleSampleGame())
            {
                game.Run();
            }
        }
    }    
#endif
    #endregion
}
