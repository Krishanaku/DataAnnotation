namespace DataAnnotation
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            // Data Annotation........................
            //AnnotationTest.display();

            // Garbage collection examples.............

            long men1 = GC.GetTotalMemory(false);// excuites synchronous manner it will wait until go to the memory and collect
            {
                int[] values = new int[5000];
                values = null;


            }
            long men2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long  men3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(men1);
                Console.WriteLine(men2);
                Console.WriteLine(men3);
            }

        }
    }
}
