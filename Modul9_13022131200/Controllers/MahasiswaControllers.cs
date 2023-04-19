using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Modul9_13022131200.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // Daftar mahasiswa
        static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("Walid Hanif Ataullah", "1302213120", new List<string>{"Dasar Pemrograman", "Kalkulus", "Basis Data"}, 2021),
            new Mahasiswa("Muhammad Raffa Zuhayr", "1302210068", new List<string>{"Dasar Pemrograman ", "Algoritma dan Struktur Data", "Basis Data"}, 2021),
            new Mahasiswa("Sylvana Rheina Khrameliawaty", "1302210017", new List<string>{"Pemrograman Lanjut", "Algoritma dan Struktur Data", "Basis Data"}, 2021),
            new Mahasiswa("M. Yasin Rafi", "1302210055", new List<string>{"Dasar Pemrograman", "Kecerdasan Buatan", "Jaringan Komputer"}, 2021),
            new Mahasiswa("M. Nabiel P", "1302210041", new List<string>{"Dasar Pemrograman", "Algoritma dan Struktur Data", "Basis Data"}, 2021)
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMhs[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            listMhs.Add(value);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            listMhs[id] = value;
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMhs.RemoveAt(id);
        }
    }
}
