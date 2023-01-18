
using System;

namespace LineProblem{
    class Line{
        public int x1, y1, x2, y2;
        
        public Line(int a1, int b1, int a2, int b2){
            x1 = a1;
            y1 = b1;
            x2 = a2;
            y2 = b2;
        }
        
        public double UC_1_line_len(){
            double line_len = Math.Sqrt( (Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)) );
    
            return line_len;
        }
        
    }
    class LineComparison {
        static void UC_2(Line l1, Line l2){
            double line1_len = l1.UC_1_line_len();
    
            double line2_len = l2.UC_1_line_len();
            
            if (line1_len == line2_len){
                Console.WriteLine("Both lines are equal");
            }
            else {
                Console.WriteLine("Both lines are NOT equal");
                if(line1_len > line2_len){
                    Console.WriteLine("Line 1 is greater.");
                }
                else{
                    Console.WriteLine("Line 2 is greater.");
                }
            }
            
        }
        
        static void Main() {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            
            Line line1 = new Line(2,3,5,4);
            Line line2 = new Line(4,5,8,9);
            
            Console.WriteLine("UC_1 : ");
            
            double line_len = line1.UC_1_line_len();
            Console.WriteLine("Line 1: line_len " + line_len);
            double line_len2 = line2.UC_1_line_len();
            Console.WriteLine("Line 2: line_len " + line_len2);
            Console.WriteLine("UC_2: ");
            UC_2(line1, line2);
            
            
        }
    }

}

