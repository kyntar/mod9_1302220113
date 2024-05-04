namespace Mod9_1302220113
{
    public class Mahasiswa
    {
        public int year { get; set; }
        public String nama { get; set; }
        public String nim { get; set; }

        public List<String> course{ get; set; }

        public Mahasiswa(String nama, String nim, List<String> course, int year)
        {
            this.nama = nama;
            this.nim = nim;
            this.course = course;
            this.year = year;
        }
       
    }
}