using System;
using System.Collections.Generic;
using System.Collections;


namespace rpg
{
    class Program
    {
        static Queue skilltreeQ = new Queue();
        static void Main(string[] args)
        {
            int skillpont = 0;
            int Counter = 0;
            bool addskill = true;

            while(addskill)
            {
                string skillName = "";
                Console.Write("input skill = ");
                skillName = Console.ReadLine();

                if(skillName == "?")
                {
                    addskill = false;
                    break;
                }
                Node skill = new Node(skillName);
                Counter += 1;
                skilltreeQ.Push(skill);

                Console.Write(" Add for {0} Y/N = ", skillName);
                char Answer = char.Parse(Console.ReadLine());
                while(Answer != 'N')
                {
                    if(Answer == 'Y')
                    {
                        Console.Write("input skill = ");
                        string nextskillname = Console.ReadLine();
                        Node nextskill = new Node(nextskillname);

                        nextskill = skill;
                        skill = nextskill;

                        Console.Write(" Add for {0} Y/N ", nextskill);
                        Answer = char.Parse(Console.ReadLine());

                        if(Answer == 'N')
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
