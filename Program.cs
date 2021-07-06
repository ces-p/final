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
        static void Main(string[] args)
        {  
            add(1); 
            add(2);
            add(3);
            add(4);
            add(4);
            add(5);
            add(5);  
            Console.WriteLine(removeAll(5));
            Console.WriteLine(contains(10));
            foreach(int i in List.l)
                Console.WriteLine(i);  
            Console.WriteLine(length());
            foreach(int i in all())
                Console.WriteLine(i);
            Console.WriteLine(isEmpty());
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

    }
       
}
