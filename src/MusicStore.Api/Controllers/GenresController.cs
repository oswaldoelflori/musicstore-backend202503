﻿using Microsoft.AspNetCore.Mvc;
using MusicStore.Entities;
using MusicStore.Repositories;

namespace MusicStore.Api.Controllers;
[ApiController]
[Route("api/genres")]  

public class GenresController : ControllerBase
{
    private readonly GenreRepository repository;
    public GenresController(GenreRepository repository)
    {
        this.repository = repository;
    }
    [HttpGet]
    public ActionResult<List<Genre>> Get()
    {
      
        var genres = repository.Get();
        return Ok(genres);

    }
    [HttpGet("{id:int}")]
    public ActionResult<Genre> Get(int id)
    {
        var item = repository.Get(id);
        return item is not null ? Ok(item) : NotFound();
    }
    [HttpPost]
    public ActionResult<Genre> Post(Genre genre)
    {
        repository.Add(genre);
        return Ok(genre);
    }
    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Genre genre)
    {
        repository.Update(id, genre);
        return Ok();
    }
    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        repository.Delete(id);
        return Ok();
    }
}
 
