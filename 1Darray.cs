# write a shell script that uses a switch-case (case statement) to #let the user:#1️ Check if a file exists#2️ Check if a directory exists#3️ Check if a file is empty# Function to check if a file existsCODEcheck_file() {echo "Enter the file name:"read filenameif [ -f "$filename" ]; thenecho "File '$filename' exists."elseecho "File '$filename' does not exist."fi}# Function to check if a directory existscheck_directory() {echo "Enter the directory name:"read dirnameif [ -d "$dirname" ]; thenecho "Directory '$dirname' exists."elseecho "Directory '$dirname' does not exist."fi}# Function to check if a file is emptycheck_empty_file() {echo "Enter the file name:"read filenameif [ -f "$filename" ]; thenif [ ! -s "$filename" ]; thenecho "File '$filename' is empty."elseecho "File '$filename' is not empty."fielseecho "File '$filename' does not exist."fi}# Main menu using case statementecho "Choose an option:"echo "1. Check if a file exists"echo "2. Check if a directory exists"echo "3. Check if a file is empty"echo "4. Exit"read choicecase $choice in1) check_file;;2) check_directory ;;3) check_empty_file ;;4) echo "Exiting..."; exit ;;*) echo "Invalid option. Please enter a valid choice." ;;esac# Function to display digital clock and calendarshow_clock_calendar() {while true; doclearecho "======================================"echo " DIGITAL CLOCK & CALENDAR "echo "======================================"echo ""echo " Time: $(date +"%H:%M:%S")"echo " Date: $(date +"%d %B %Y")"#%d The two-digit day of the month padded with leading zeroes if applicable. Example: 09.#%B The full month name. Example: September.#%Y The four-digit year. Example: 2001.echo ""calecho ""echo "======================================"sleep 1 # Wait for 1 second before updatingdone}# Call the functionshow_clock_calendar﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int a = 0; a < arr.Length; a++)
            {
                Console.Write("Enter value:");
                arr[a] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int b in arr)
            {
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
