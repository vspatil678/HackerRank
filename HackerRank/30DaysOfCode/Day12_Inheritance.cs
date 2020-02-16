﻿using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public string firstName;
    public string lastName;
    public int id;
    public int[] scores;
    public Student(string _firstName, string _lastName, int _id, int[] _scores)
    {
        this.firstName = _firstName;
        this.lastName = _lastName;
        this.id = _id;
        this.scores = _scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public void printPerson()
    {
        Console.WriteLine("Name: " + this.lastName + ", " + this.firstName);
        Console.WriteLine("ID: " + this.id);
    }
    public char Calculate()
    {
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum = sum + scores[i];
        }
        int score = sum / scores.Length;
        if (score >= 90 && score <= 100)
        {
            return 'O';
        }
        else if (score >= 80 && score < 90)
        {
            return 'E';
        }
        else if (score >= 70 && score < 80)
        {
            return 'A';
        }
        else if (score >= 55 && score < 70)
        {
            return 'P';
        }
        else if (score >= 40 && score < 55)
        {
            return 'D';
        }
        else
        {
            return 'T';
        }


    }
}

class Solution12
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}