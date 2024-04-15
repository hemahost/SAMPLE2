using TextFile;
namespace SAMPLE2
{
    public class DataLine
    {
        public int ID;
        public int WORK;
        public DataLine(int ID, int WORK) { 
        this.ID = ID;
        this.WORK = WORK;}
    }

    internal class Program
    {
        public static DataLine? ReadData(TextFileReader reader)
        {
            bool ReadID = reader.ReadInt(out int  ID);
            bool ReadWORK = reader.ReadInt(out int  WORK);
            if(ReadID && ReadWORK)
            {
                return new DataLine(ID, WORK);
            }
            else
            {
                return null;
            }
        }
            
    
          
        static void Main(string[] args)
        {
            var reader = new TextFileReader("input.txt");
            DataLine? line = null;  
            var max = 0;
            var maxId = 0;
            while((line= ReadData(reader)) != null)
            {
                if (line.WORK > max)
                {
                    max = line.WORK;
                    maxId = line.ID;

                }   
            }
            Console.WriteLine(maxId);
        }
    }
}
