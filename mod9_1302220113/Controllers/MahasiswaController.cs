using Microsoft.AspNetCore.Mvc;
using Mod9_1302220113;

namespace MOD9_1302220113.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<String> Course = new List<String> { "KPL", "PBO", "BD", "UX" };
        private static List<Mahasiswa> arrMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Kyntar Barra Langit", "1302220113" , Course,2022 ),
            new Mahasiswa ("Yoga Fikri", "1302220101", Course,2022 ),
            new Mahasiswa ("M Faisal Shafwan", "1302223119" , Course, 2022),
            new Mahasiswa ("Haidar Abdul Halim", "1302220152" , Course, 2022)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return arrMahasiswa;
        }

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id < 0 || id >= arrMahasiswa.Count)
            {
                return NotFound();
            }
            return arrMahasiswa[id];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa mahasiswa)
        {
            arrMahasiswa.Add(mahasiswa);
            return CreatedAtAction(nameof(Get), new { id = arrMahasiswa.IndexOf(mahasiswa) }, mahasiswa);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= arrMahasiswa.Count)
            {
                return NotFound();
            }

            arrMahasiswa.RemoveAt(id);
            return NoContent();
        }
      }
   }
