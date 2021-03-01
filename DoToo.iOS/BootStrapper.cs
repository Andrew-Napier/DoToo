using System;
namespace DoToo.iOS
{
    public class BootStrapper : DoToo.BootStrapper
    {
        public static void Init()
        {
            var instance = new BootStrapper();
        }
    }
}
