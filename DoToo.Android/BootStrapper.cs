using System;
namespace DoToo.Droid
{
    public class BootStrapper : DoToo.BootStrapper
    {
        public static void Init()
        {
            var instance = new BootStrapper();
        }
    }
}
