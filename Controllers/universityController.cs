using Microsoft.AspNetCore.Mvc;

using universidades.Services;
using universidades.Models;
namespace universidades.Controllers;

//atributos controller

[ApiController]
[Route ("api/[Controller]")]
public class universityController: ControllerBase{
    //inyeccion de dependencia

IUniversityService uniService;
public universityController(universityService serviceUniversity){
   uniService=serviceUniversity;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] University nuevo){
uniService.insertar(nuevo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(uniService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizar([FromBody] University uActualizar, Guid id){
uniService.actualizar(id,uActualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
uniService.eliminar(id);
    return Ok();
}

}