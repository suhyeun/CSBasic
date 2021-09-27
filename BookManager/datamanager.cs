using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookManager
{
    public class DataManager
    {
        // 모든 클래스에서 접근할 수 있도록 static으로 데이터리스트를 만든다.
        // 이런식으로 모든 클래스에서 접근할 수 있도록 만든 리스트를
        // Static 저장소(Storage) 기술이라고 부른다.
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DataManager()
        {
            Load();
        }

        private static void Load()
        {
            try
            {
                // 책과 사용자 정보 xml을 읽고 파싱한다. 
                string booksOutput = File.ReadAllText(@"./Books.xml");
                XElement booksXElement = XElement.Parse(booksOutput);
                Books = (from item in booksXElement.Descendants("book")
                         select new Book()
                         {
                             Isbn = item.Element("isbn").Value,
                             Name = item.Element("name").Value,
                             Publisher = item.Element("publisher").Value,
                             Page = int.Parse(item.Element("page").Value),
                             isBorrowed = item.Element("isBorrowed").Value != "0" ? true : false,
                             UserId = int.Parse(item.Element("userId").Value),
                             UserName = item.Element("userName").Value
                         }).ToList<Book>();
                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             Id = int.Parse(item.Element("id").Value),
                             Name = item.Element("name").Value,
                         }).ToList<User>();
            }
            catch (FileNotFoundException exception)
            {
                Save(); // 최초 실행 시에는 당연히 파일이 없으니 파일이 없으면 생성한다.
            }
        }

        // 저장합니다.
        private static void Save()
        {
            // 책 정보를 xml로 만들었습니다.
            string booksOutput = "";
            booksOutput += "<books>\n";
            foreach (var item in Books)
            {
                booksOutput += "<book>\n";
                booksOutput += "  <isbn>" + item.Isbn + "</isbn>\n";
                booksOutput += "  <name>" + item.Name + "</name>\n";
                booksOutput += "  <publisher>" + item.Publisher + "</publisher>\n";
                booksOutput += "  <page>" + item.Page + "</page>\n";
                booksOutput += "  <borrowedAt>" + item.BorrowedAt.ToLongDateString() + "</borrowedAt>\n";
                booksOutput += "  <isBorrowed>" + (item.isBorrowed ? 1 : 0) + "</isBorrowed>\n";
                booksOutput += "  <userId>" + item.UserId + "</userId>\n";
                booksOutput += "  <userName>" + item.UserName + "</userName>\n";
                booksOutput += "</book>\n";
            }
            booksOutput += "</books>\n";

            // 사용자 정보를 xml로 만들었습니다.
            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)
            {
                booksOutput += "<user>\n";
                booksOutput += "  <id>" + item.Id + "</id>\n";
                booksOutput += "  <name>" + item.Name + "</name>\n";
                booksOutput += "</user>\n";
            }
            usersOutput += "</users>\n";

            File.WriteAllText(@"./Books.xml", booksOutput);
            File.WriteAllText(@"./Users.xml", usersOutput);
        }
    }
}