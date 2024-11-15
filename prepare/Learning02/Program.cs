using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1._jobTitle = "Computer Programmer";
        job1._company = "Zimba Technologies Inc";
        job1._startYear = 2012;
        job1._endYear = 2020;


        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "Redo Developers Inc";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();

        myResume._name = "Job Oboth";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



    }
}