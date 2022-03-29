using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33
{
    class Student
    {
        public string _fullname;
        public string _groupno;
        public int Age { get; set; }

        public string GroupN0
        {
            get => _groupno;
            set
            {
                if (_groupno.Length == 5 && char.IsUpper(_groupno[0]) && char.IsUpper(_groupno[1]) && char.IsDigit(_groupno[2]) && char.IsDigit(_groupno[3]) && char.IsDigit(_groupno[4]))
                    this._groupno = value;
            }
        }

        string Name;
        string Surname;
        public string FullName
        {
            get => _fullname;
            set
            {
                if (value==Name+" "+Surname)
                    _fullname = value;
            }
        }

        public static bool CheckGroupNo()
        {
            if()
        }
        public static bool CheckFullname()
        {
            
        }

    }
}
