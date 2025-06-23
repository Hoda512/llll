namespace indexer
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Ip ip = new Ip(1, 2, 3, 4);
            ip[0] = 9;
            Console.WriteLine(ip.dis);
        }
    }


    public class Ip {

        private int[] Segmants = new int[4];




        public int this[int index] {

            get { 
            
            return Segmants[index];
            }
            set {

                Segmants[index] = value;
            
            }
        
        
        }
        public Ip(int segmant1, int segmant2, int segmant3, int segmant4) {

            Segmants[0] = segmant1;
            Segmants[1] = segmant2;
            Segmants[2] = segmant3;
            Segmants[3] = segmant4;

        }
        public string dis =>string.Join(".", Segmants);
    
    
    
    }
}
