using System;
using System.Text;

namespace EditorHTML
 {
     public class Editor
     {
         public static void Show()
         {
             Console.Clear();
             // Console.BackgroundColor = ConsoleColor.White;
             Console.ForegroundColor = ConsoleColor.DarkGreen;
             Console.Clear();
             Console.WriteLine("EDITOR MODE:");
             Console.WriteLine("-------------");
             Start();
         }

         public static void Start()
         {
             var file = new StringBuilder();

             do
             {
                 file.Append(Console.ReadLine());
                 file.Append(Environment.NewLine);
             } while (Console.ReadKey().Key != ConsoleKey.Enter);
             
             Console.WriteLine("-------------");
             Console.WriteLine(" Do you want to save your file?");
             Viewer.Show(file.ToString());
         }
     }
 }
 
