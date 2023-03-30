using ExperimentationsLINQ;

namespace POO1_Module15_ExperimentationLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Func<int, int> fctIdentite_V01 = (int x) => x;
        //    ObjectDumper.Write(Identite(10));

        //    Func <double, double> fctCarre_V01 = (double y) => y * y;
        //    ObjectDumper.Write(fctCarre_V01(5));
        
            Func<int, int, int> fctMultiplication_V01 = (x, y) => x * y;
            ObjectDumper.Write(fctMultiplication_V01(5, 3));
            
            Func<int, int> fctIdentite_V02 = (x) => x;
            ObjectDumper.Write(fctIdentite_V02(10));

            Func<int, int, int> fctAddition_V02 = (x, y) => x + y;
            ObjectDumper.Write(fctAddition_V02(10, 20));


        }

        private static int Identite(int val)
        {
            return val;
        }

        public double Carre(double p_chiffre)
        {
            return p_chiffre * p_chiffre;
        }

        public int Multiplicatiom(int p_valeur1, int p_valeur2)
        {
            return p_valeur1 * p_valeur2;
        }
    }
}