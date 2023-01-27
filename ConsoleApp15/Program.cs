namespace one
{
    public class Myself
    {

        public string name;
        public string subject;
        public void display(string name, string subject)
        {
            this.name = name;
            Console.WriteLine("my name is " + name);
            Console.WriteLine("my fav subject is " + subject);
        }




    }
    class Myname : Myself
    {
        public Myname()
        {
            Console.WriteLine();
        }

    }



    class subject
    {

        static void Main(string[] args)
        {
            var myname = new Myname();
            myname.display("saba", "bio");

        }
    }
}



