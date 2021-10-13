using Library.Core;
using Library.Core.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    public class BookController : Controller
    {
        private readonly MainBusinessLayer mainBusinessLayer;

        public BookController(MainBusinessLayer mainBL)
        {
            this.mainBusinessLayer = mainBL;

        }
        [HttpGet]
        public IActionResult Get()
        {
            var books = mainBusinessLayer.FetchBooks();

            return Ok(books);
        }

        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
                return BadRequest("Id non valido"); //400 -> bad request

   

            Book book = mainBusinessLayer.GetById(id);

            if (book == null)
            {
                return NotFound("Non trovato"); //404 -> not found
            }

            return Ok(book);

        }

      
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            if (newBook == null)
                return BadRequest("Dati invalidi");

            bool isAdded = mainBusinessLayer.AddBook(newBook);

            if (!isAdded)
                return StatusCode(500, "Il libro non può essere aggiunto");


            return CreatedAtAction("AddBook", newBook); //201 -> created

        }

        //update
        [HttpPut("{id}")]
        public IActionResult Put(int id, Book book)
        {
            if (id <= 0 || book == null)
                return BadRequest("Impiegato invalido");

            if (id != book.Id)
                return BadRequest("Gli id non combaciano");

            bool isAdded = mainBusinessLayer.UpdateBook(book);

            if (!isAdded)
                return BadRequest("Libro non modificato");

            return Ok(book);
        }

      
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Id non valido");

            bool isDeleted = mainBusinessLayer.DeleteBook(id);

            if (!isDeleted)
                return BadRequest("Libro non cancellato");

            return Ok();
        }

    }
}
