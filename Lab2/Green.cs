using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            for (int i = 2; i <= n; i += 2)
            {
                double a = (double)i / (i + 1);
                answer += a;
            }

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            double a = 1.0;
            for (int i = 0; i <= n; i++)
            {
                answer += a;
                a /= x;
            }
            
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            long fact = 1;
            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact;
            }
            answer = sum;

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            for (int i = 0; ; i++)
            {
                if (elem < limit)
                {
                    elem *= 2;
                    answer += elem;
                }
                else
                {

                    break;
                }

            }

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
