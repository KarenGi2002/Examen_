using Microsoft.AspNetCore.Mvc;
using universidades.Models;
using universidades.Services;

namespace universidades.Controllers;

//atributos controller

[ApiController]
[Route ("api/[Controller]")]
public class CountryController: ControllerBase{
    //inyeccion de dependencia

ICountryService countryService;
public CountryController(ICountryService serviceCountry){
    countryService=serviceCountry;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresarCountry([FromBody] Country nuevoCountry){
countryService.insertar(nuevoCountry);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrarCountry(){
    return Ok(countryService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizarCountry([FromBody] Country countryActualizar, Guid id){
countryService.actualizar(id,countryActualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminarCountry(Guid id){
countryService.eliminar(id);
    return Ok();
}

}