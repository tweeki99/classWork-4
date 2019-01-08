using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();
            
            article.AddAuthor("Mod_1", "Mod_2");


            string numberAsString = "25";
            int number = int.Parse(numberAsString);

            string numberAsString1 = "s";
            int number1;
            if(int.TryParse(numberAsString1,out number1))   //out может иметь или не иметь значение
            {

            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Resize(ref numbers, 10);                 //ref должна иметь значение
        }
    }
    partial class Article
    {
        public string ReturnData()
        {
            return $"{_author} {_text} {_title}";
        }

        public void AddAuthor(params string[] authors)
        {
            foreach (var author in authors)
            {
                _author += " " + author;
            }
            _author.Trim();
        }

        //public bool IsAuthorSet(out string author)
        //{
        //    if (String.IsNullOrEmpty(_author)) //пустая ли строка?
        //    {
        //        author = "";
        //        return false;
        //    }
        //    else
        //    {
        //        author = _author;
        //        return true;
        //    }
        //}
        public bool IsAuthorSet(ref string author)
        {
            if (String.IsNullOrEmpty(_author)) //пустая ли строка?
            {
                return false;
            }
            else
            {
                author = _author;
                return true;
            }
        }
    }
}

