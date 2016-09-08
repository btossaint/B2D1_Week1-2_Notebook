using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2D1_Week1_2_Notebook
{
    public class Notebook
    {
        private ArrayList notes;

        public Notebook()
        {
            notes = new ArrayList();
        }

        public void storeNote(string note)
        {
            notes.Add(note);
        }

        public int numberOfNotes()
        {
            return notes.Count;
        }

        public void showNote(int indexnumber)
        {
            Console.WriteLine("Notes: "+notes[indexnumber]);
        }
    }

    
}
