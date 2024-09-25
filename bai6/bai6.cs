// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

public class bai6
{
    public void Bai16()
    {
        
            ArrayList numbers = new ArrayList();
            string input;

            Console.WriteLine("Nhap cac so nguyen (nhap 'x' de dung):");
            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "x") break;
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so nguyen hop le!");
                }
            }

            numbers.Sort();

            Console.WriteLine("Danh sach cac so nguyen đa nhap (tang dan):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
 
    }

    public void Bai26()
    {
            Hashtable people = new Hashtable();
            string name;
            int age;

            Console.WriteLine("Nhap ten va tuoi (nhap 'x' đe dung):");
            while (true)
            {
                Console.Write("Ten: ");
                name = Console.ReadLine();
                if (name.ToLower() == "x") break;

                Console.Write("Tuoi: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    people[name] = age;
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot tuoi hop le!");
                }
            }

            Console.WriteLine("Danh sach ten va tuoi:");
            foreach (DictionaryEntry entry in people)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} tuoi");
            }
    }

    public void Bai36()
    {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string name;
            int score;

            Console.WriteLine("Nhap ten và điem cua hoc sinh (nhap 'x' đe dung):");
            while (true)
            {
                Console.Write("Ten hoc sinh: ");
                name = Console.ReadLine();
                if (name.ToLower() == "x") break;

                Console.Write("Diem: ");
                if (int.TryParse(Console.ReadLine(), out score))
                {
                    students[name] = score;
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot điem hop le!");
                }
            }

            Console.WriteLine("Danh sach hoc sinh va diem:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}: {student.Value} diem");
            }
    }
}
