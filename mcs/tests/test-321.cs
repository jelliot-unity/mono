using System;
 
struct X : IDisposable {
        public void Dispose ()
        {
        }
 
        static void Main ()
        {
                X x = new X ();
                using (x)
                        ;
        }
}