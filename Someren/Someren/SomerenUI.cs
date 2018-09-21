﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Someren
{
    public static class SomerenUI
    {
        public static Control showStudents()
        {
            List<SomerenModel.Student> sl = new List<SomerenModel.Student>();
            //SomerenDB.

            SomerenDB db = new SomerenDB();
            sl = db.DB_getstudents();
            SomerenModel.Student[] studenten = sl.ToArray();

            ListView c = new ListView();
            c.View = View.Details;
            c.BackColor = System.Drawing.SystemColors.ControlLight;

            c.Columns.Add("id", -2, HorizontalAlignment.Left);
            c.Columns.Add("naam", -2, HorizontalAlignment.Left);
            c.Columns.Add("achternaam", -2, HorizontalAlignment.Left);

            c.Height = 500;
            c.Width = 500;

            for (int i = 0; i < studenten.Length; i++)
            {
                ListViewItem lv = new ListViewItem(studenten[i].getId().ToString());
                lv.SubItems.Add(studenten[i].getNaam());
                lv.SubItems.Add(studenten[i].getAchternaam());
                c.Items.Add(lv);
            }

            return c;
        }

        public static Control showTeachers()
        {
            List<SomerenModel.Docent> dl = new List<SomerenModel.Docent>();
            //SomerenDB.


            SomerenDB db = new SomerenDB();
            dl = db.DB_getteachers();
            SomerenModel.Docent[] docenten = dl.ToArray();

            ListView c = new ListView();
            c.View = View.Details;
            c.BackColor = System.Drawing.SystemColors.ControlLight;

            c.Columns.Add("docent_id", -2, HorizontalAlignment.Left);
            c.Columns.Add("docent_naam", -2, HorizontalAlignment.Left);
            c.Columns.Add("docent_achternaam", -2, HorizontalAlignment.Left);

            c.Height = 500;
            c.Width = 500;

            for (int i = 0; i < docenten.Length; i++)
            {
                ListViewItem lv = new ListViewItem(docenten[i].getId().ToString());
                lv.SubItems.Add(docenten[i].getNaam());
                lv.SubItems.Add(docenten[i].getAchternaam());
                c.Items.Add(lv);
            }

            return c;
        }

        public static Control addUILabel(string text)
        {
            Label l = new Label();
            l.Text = text;
            return l;
        }
        

    }
}
