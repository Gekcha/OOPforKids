using System;
using System.Collections.Generic;
using System.Text;

namespace MemeHierarchy.Date1
{
    class Date
    {
        int year=2000;
        int month=1;
        int day=1;

        public Date()
        {

        }

        public Date(int _year, int _month, int _day)
        {
            year = _year;
            month = _month;
            day = _day;
        }

        public bool CompareDate(Date date)
        {
            if ((year * 365 + month * 30 + day) >= (date.year * 365 + date.month * 30 + date.day))
                return true;
            else
                return false;
        }

    }
}
