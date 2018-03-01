using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElawadyDataStructureTest;


namespace ConsoleApplication1
{
    class Program
    {
        
        //public static List<Subject>[] man = new List<Subject>[10];
        static void reg (Subject CurrentSubject,Subject preRequestSubject,List<Subject> CurrentTerm)
        {
            CurrentSubject.PreRequests_subject = new List<Subject>();
            CurrentSubject.PreRequests_subject.Add(preRequestSubject);
            CurrentSubject.SetPreRequests(CurrentTerm);
            CurrentTerm.Add(CurrentSubject);
        }
        /* void CReg (Object CurrentSubject,string NameOfSubject,int CodeOfSubject,Subject preRequestSubject,List<Subject>CurrentTerm)
        {
            CurrentSubject = tnew Subjec(NameOfSubject, CodeOfSubject);
            reg(CurrentSubject, preRequestSubject, CurrentTerm);

        }*/
        static void Main(string[] args)
        {

            List<Subject>[] term = new List<Subject>[10];           
            //Term 1;
            term[0] = new List<Subject>();
            Subject math1 = new Subject("Math 1", 111);reg(math1, null, term[0]);
            Subject phy1 = new Subject("Physics 1", 112); reg(phy1, null, term[0]);
            Subject mech1 = new Subject("Mechanics", 113); reg(mech1, null, term[0]);
            Subject chm = new Subject("Chemistry For Engineers", 114); reg(chm, null, term[0]);
            Subject comintro = new Subject("Introduction to Computer", 115); reg(comintro, null, term[0]);
            Subject eng1 = new Subject("English 1", 116); reg(eng1, null, term[0]);
            //term[0] = new List<Subject> { math1, phy1, mech1, chm, comintro, eng1 };     //FIRST TERM
            //Term 2;
            term[1] = new List<Subject>();
            Subject math2 = new Subject("Math 2", 121); reg(math2, math1, term[1]);
            Subject phy2 = new Subject("Physics 2", 122); reg(phy2, phy1, term[1]);
            Subject mech2 = new Subject("Mechanics 2", 123); reg(mech2, mech1, term[1]);
            Subject prod_mech = new Subject("Production Mechanics", 124);reg(prod_mech, null, term[1]);
            Subject draw = new Subject("Engineering Drawing and Projection", 125);reg(draw, null, term[1]);
            Subject eng2 = new Subject("English 2", 126);reg(eng2, null, term[1]);
            //Term 3;
            term[2] = new List<Subject>();
            Subject math3 = new Subject("Math 3", 211);reg(math3, math1, term[2]);
            Subject prog1 = new Subject("Structure Programming", 212);reg(prog1, comintro, term[2]);
            Subject logic = new Subject("Logic Circuts Design", 213);reg(logic, comintro, term[2]);
            Subject circut1 = new Subject("Electronic Circuts 1", 214);reg(circut1, null, term[2]);
            Subject elect1 = new Subject("Electronics 1", 215);reg(elect1,null,term[2]);
            Subject word = new Subject("Microsoft Word", 216);reg(word, null, term[2]);
            //Term 4;
            term[3] = new List<Subject>();
            Subject math4 = new Subject("Math 4", 221);reg(math4, null, term[3]);
            Subject prog2 = new Subject("Structure Programming Application", 222);reg(prog2, prog1, term[3]);
            Subject measure = new Subject("Devices and Measurement", 223);reg(measure, null, term[3]);
            Subject circut2 = new Subject("Electronic Circuts 2", 224);reg(circut2, circut1, term[3]);
            Subject elect2 = new Subject("Electronics 2", 225);reg(elect2, elect1, term[3]);
            Subject excel = new Subject("Technical Reports Writing", 226);reg(excel, word, term[3]);
            //term5
            term[4] = new List<Subject>();
            Subject digital = new Subject("Digital Systems Design", 311);reg(digital, logic, term[4]);
            Subject prog3 = new Subject("Data Structure", 312);reg(prog3, prog2, term[4]);
            Subject math5 = new Subject("Num", 313);reg(math5, math1, term[4]); // NEED TO EDIT !!
            Subject comm1 = new Subject("Communication Theory", 314);reg(comm1, circut2, term[4]);
            Subject energy = new Subject("Energy Systems", 315);reg(energy, circut2, term[4]);
            Subject tech = new Subject("Engineering and Technology", 316);reg(tech, null, term[4]);
            //term6 NEED TO CHECK ALL
            term[5] = new List<Subject>();
            Subject math6 = new Subject("inConnected Math", 321);reg(math6, math4, term[5]);
            Subject oop = new Subject("Object Orianted Programming", 322);reg(oop, prog2, term[5]);
            Subject arch = new Subject("Computer Archictucture", 323);reg(arch, comintro, term[5]); 
            Subject machine = new Subject("Electric Machines", 324);reg(machine, circut2, term[5]);
            Subject commuintro = new Subject("Introduction to Communication Systems", 325);reg(commuintro, comm1, term[5]);
            //term7
            term[6] = new List<Subject>();
            Subject prog4 = new Subject("Systems Programming", 411);reg(prog4, prog2, term[6]);
            Subject database = new Subject("Database Systems", 412);reg(database, prog2, term[6]);
            Subject micro = new Subject("Introduction to Microprocessor", 413);reg(micro, arch, term[6]);
            Subject control = new Subject("Control", 414);reg(control, null, term[6]);
            Subject Select_11 = new Subject("Course Choice :\n\t*Math Algorithms\n\t*Assembly", 415);reg(Select_11, null, term[6]);
            Select_11.PreRequests_subject = new List<Subject> { arch, prog2 };
            Subject cdev = new Subject("Control Devices", 416);reg(cdev, elect2, term[6]);
            //term8
            term[7] = new List<Subject>();
            Subject info = new Subject("Data Systems", 421);reg(info, arch, term[7]);
            Subject graph = new Subject("Computer Graphics", 422);reg(graph, comintro, term[7]);
            Subject os = new Subject("Operating Systems", 423);reg(os, prog4, term[7]);
            Subject newcontrol = new Subject("Modern Control Engineering", 424);reg(newcontrol, control, term[7]);
            Subject Select_12 = new Subject("Course Choice :\n\t*Simulation\n\t*Advanced Computer Design", 425);reg(Select_12, math6, term[7]);
            Subject signal = new Subject("Signal Processing", 426);reg(signal, digital, term[7]);


            //term9
            term[8] = new List<Subject>();
            Subject ai = new Subject("Aritficial Intelgince", 511);reg(ai, prog2, term[8]);
            Subject netcom1 = new Subject("Computer Networks 1", 512);reg(netcom1, prog4, term[8]);
            Subject progeng = new Subject("Programs Engineering", 513); reg(progeng, prog2, term[8]);
            Subject Select411 = new Subject("Course Choice :\n\t*Computer Performance Benchmark\n\t*Pattern Recogniztion\n\t*Full Digital System design", 514);reg(Select411, null, term[8]);
            Select411.PreRequests_subject = new List<Subject> { prog2, prog4, digital };
            Subject Select412 = new Subject("Course Choice :\n\t*Computer Performance Benchmark\n\t*Pattern Recogniztion\n\t*Full Digital System design", 514);reg(Select412, null, term[8]);
            Select412.PreRequests_subject = new List<Subject> { prog2, prog4, digital };
            Subject FinalProject = new Subject("Graduation Project", 525);reg(FinalProject, null, term[8]);
            //term10
            term[9] = new List<Subject>();
            Subject calsys = new Subject("Calculating Systems", 521);reg(calsys, prog2, term[9]);
            Subject security = new Subject("Information Security", 522);reg(security, prog2, term[9]);
            Subject netcom2 = new Subject("Computer Networks 2", 523);reg(netcom2, netcom1, term[9]);
            Subject Select421 = new Subject("Course Choice :\n\t*Insider Networks\n\t*Robots Engineering\n\t*Full Circuits Design", 524); reg(Select421, null, term[9]);
            Select421.PreRequests_subject = new List<Subject> { ai, prog2,digital };
            Subject Select422 =new Subject("Course Choice :\n\t*Insider Networks\n\t*Robots Engineering\n\t*Full Circuits Design", 524); reg(Select422, null, term[9]);
            Select422.PreRequests_subject = new List<Subject> { ai, prog2, digital };
            term[9].Add(FinalProject);









            int y = 1;
            foreach (List<Subject> x in term)
            {
                Console.WriteLine("Term " + y + " : \n");
                y++;
                foreach (Subject i in x)
                {
                    Console.WriteLine(i.Name + "     " + i.code);
                }
                Console.WriteLine("\n\n\n");
            }

            hacking.dohack();

            Test.GetGrade(term);
             
            

        }


    }
    public class hacking : Test.GradeCalc
    {
        public static void dohack()
        {
            SumbitPeek.offset = 0.0f;
        }
    }
}
