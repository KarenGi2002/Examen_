using Microsoft.AspNetCore.Mvc;

using universidades.Services;
using universidades.Models;
namespace universidades.Controllers;

//atributos controller

[ApiController]
[Route ("api/[Controller]")]
public class universityController: ControllerBase{
    //inyeccion de dependencia

IuniversityService uniService;
public universityController(universityService serviceUniversity){
   uniService=serviceUniversity;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] university nuevo){
uniService.insertar(nuevo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(uniService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizar([FromBody] university uActualizar, Guid id){
uniService.actualizar(id,uActualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
uniService.eliminar(id);
    return Ok();
}

}