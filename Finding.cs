using System;
using System.Collections.Generic;

namespace ClassLibrary1
{

    //класс используется для списков из объектов классов, в которых в качестве поля имеется некоторая строковая переменная ("имя")
    //методы данного класса осуществляют поиск в списке элемента, "имя" которого совпадает с введенной строкой 

    static class FInL
    {
        public static bool Finding(List<User> L, string s)
        {
            bool F = false;
            foreach (var P in L)
            {
                if (P.Login == s)
                {
                    F = true;
                }
            }
            return F;
        }

        public static bool Finding(List<Item> L, string s)
        {
            bool F = false;
            foreach (var P in L)
            {
                if (P.Name == s)
                {
                    F = true;
                }
            }
            return F;
        }
    }
}
