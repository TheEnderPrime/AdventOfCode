using System;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCode_2024
{
    class Program
    {
        static void Main(string[] args)
        {
            // DAY ONE - PART ONE
            // pair up numbers and measure how far apart they are
            // pair up the LEFT smallest number with the RIGHT smallest number
            // then LEFT next smallest nubmer with the RIGHT next smallest number
            // with each pair, figure the DIFFERENCE between the numbers
            // add up all the DIFFERENCES 
            // List<int> left = new List<int>();
            // List<int> right = new List<int>();
            // int answer = 0;

            // string[] data = File.ReadAllLines("Day1.txt");
                
            // foreach(string line in data) {
            //     left.Add(int.Parse((line.Split("   ")[0]).Trim()));
            //     right.Add(int.Parse((line.Split("   ")[1]).Trim()));
            // }

            // left.Sort();
            // right.Sort();

            // for (int i = 0; i < left.Count; i++) {
            //     answer += Math.Abs(left[i] - right[i]);
            // }

            // Console.WriteLine("Day One - Part One: " + answer);

            // // DAY ONE - PART TWO
            // //iterate through left list and find how many times each int exists in the right list.
            // // multiple each left by the number of dups found in right
            // answer = 0;

            // foreach(int leftNum in left) {
            //     int multiplier = 0;
            //     foreach(int rightNum in right) {
            //         if(leftNum == rightNum) {
            //             multiplier += 1;
            //         }
            //     }
            //     answer += leftNum * multiplier;
            // }
            // Console.WriteLine("Day One - Part Two: " + answer);

            // DAY TWO - PART ONE
            // Row numbers must all be increasing or decreasing
            // Adjacent levels must differ by at least 1 and at most 3
            string[] data = File.ReadAllLines("Day2.txt");
            int[][] reports = new int[data.Length][];

            int answer = 0;

            for(int i = 0; i < reports.Length; i++) {             
               string[] strings = data[i].Split(' ');
               int[] intArray = Array.ConvertAll(strings, int.Parse);
               reports[i] = intArray;
            }

            foreach(int[] line in reports) {
                for(int i = 0; i < reports.Length; i++) {  
                    if (i == 0) {
                        int post = line[i] - line[i+1];
                    }
                    
                    if (i == reports.Length) {
                        int prev = line[i] - line[i-1];
                    }
                    
                    
                    
                    
                    int prev = i==0 ?  : (line[i] - line[i-1]);
                    int post = (line[i] - line[i+1]);

                    if (prev == 0 || post == 0) {
                        continue;
                    } 
                    else if ((prev > 0 && post < 0) || (prev < 0 && post > 0)) 
                    { 
                        continue;
                    } 
                    else if ((prev < 1 && prev > 3) && (post < 1 && post > 3)) 
                    {
                        continue;
                    } 
                    else {
                        answer++;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}

// dotnet run --project adventofcode_2024



