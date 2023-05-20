using Microsoft.AspNetCore.Mvc;

using universidades.Services;
using universidades.Models;
namespace universidades.Controllers;

//atributos controller

[ApiController]
[Route ("api/[Controller]")]
public class rankingSystemController: ControllerBase{
    //inyeccion de dependencia

IrankingSystemService rankingService;
public rankingSystemController(IrankingSystemService servicerankingsystem){
    rankingService=servicerankingsystem;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] ranking_system nuevoranking){
rankingService.insertar(nuevoranking);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(rankingService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizar([FromBody] ranking_system rankingActualizar, Guid id){
rankingService.actualizar(id,rankingActualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
rankingService.eliminar(id);
    return Ok();
}

}