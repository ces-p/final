using System;
using static System.Math;
using System.Collections.Generic;

namespace funCounters
{
    class Program
    { 
        public static class List{
            public static LinkedList<int> l = new LinkedList<int>();
        }

        static void add(int x){
            List.l.AddLast(x);
        }

        static bool remove(int x){
            bool result = false;
            var node = List.l.First;
            while(node != null){
                var next = node.Next;
                if(node.Value == x){
                    List.l.Remove(node);
                    result = true;
                    break;
                }
                node = next;
            }
            return result;
        }

        static bool removeAll(int x){
            bool result = false;
            var node = List.l.First;
            while(node != null){
                var next = node.Next;
                if(node.Value == x){
                    List.l.Remove(node);
                    result = true;
                }
                node = next;
            }
            return result;
        }

        static bool contains(int x){
            bool result = false;
            var node = List.l.First;
            while(node != null){
                var next = node.Next;
                if(node.Value == x){
                    result = true;
                    break;
                }
                node = next;
            }
            return result;

        }

        static int length(){
            int x = 0;
            var node = List.l.First;
            while(node != null){
                var next = node.Next;
                x++;
                node = next;
            }
            return x;
        }

        static int[] all(){
            int x = 0;
            int[] y = new int[length()];
            foreach(int i in List.l){
                y[x] = i;
                x++;
            }
             
            return y;
        }

        static bool isEmpty(){
            bool result = false;
            if (List.l.First == null)
                result = true;
            return result;
        }

    

    
        public static class Set{
            public static LinkedList<int> l = new LinkedList<int>();
        }
        static void Main(string[] args)
        {  
            add1(1); 
            add1(2);
            add1(3);
            add1(4);
            add1(4);
            add1(5);
            add1(5);  
            
            Console.WriteLine(contains1(10));
            foreach(int i in Set.l)
                Console.WriteLine(i);  
            Console.WriteLine(length());
            foreach(int i in all1())
                Console.WriteLine(i);
            Console.WriteLine(isEmpty());
        }

        static bool add1(int x){
            bool result = true;
            var node = Set.l.First;
            while(node != null){
                var next = node.Next;
                if(node.Value == x){
                    result = false;
                    break;
                }
                node = next;
            }
            if(result)
                Set.l.AddLast(x);
                
            return result;
            
        }

        static bool remove1(int x){
            bool result = false;
            var node = Set.l.First;
            while(node != null){
                var next = node.Next;
                if(node.Value == x){
                    Set.l.Remove(node);
                    result = true;
                    break;
                }
                node = next;
            }
            return result;
        }

        static bool removeAll1(int x){
            bool result = false;
            var node = Set.l.First;
            while(node != null){
                var next = node.Next;
                if(node.Value == x){
                    Set.l.Remove(node);
                    result = true;
                }
                node = next;
            }
            return result;
        }

        static bool contains1(int x){
            bool result = false;
            var node = Set.l.First;
            while(node != null){
                var next = node.Next;
                if(node.Value == x){
                    result = true;
                    break;
                }
                node = next;
            }
            return result;

        }

        static int length1(){
            int x = 0;
            var node = Set.l.First;
            while(node != null){
                var next = node.Next;
                x++;
                node = next;
            }
            return x;
        }

        static int[] all1(){
            int x = 0;
            int[] y = new int[length1()];
            foreach(int i in Set.l){
                y[x] = i;
                x++;
            }
             
            return y;
        }

        static bool isEmpty1(){
            bool result = false;
            if (Set.l.First == null)
                result = true;
            return result;
        }

    }

    
       
}
