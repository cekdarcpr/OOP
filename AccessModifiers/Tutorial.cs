using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Tutorial
    {
        int TutorialID;
        string TutorialName;

        public void setTutorial(int tutorialID, string tutorialName)
        {
            TutorialID = tutorialID;
            TutorialName = tutorialName;
        }

        public string getTutorialName()
        {
            return TutorialName;
        }  

    }
}
