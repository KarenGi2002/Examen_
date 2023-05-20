using universidades.Models;


namespace universidades.Services;

public class rankingSystemService: IrankingSystemService{
    //inyeccion de dependencia a la base de datos
context context;

public rankingSystemService(context dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(ranking_system inputranking){
        inputranking.id=Guid.NewGuid();
        await context.AddAsync(inputranking);
        await context.SaveChangesAsync();
    }

    public IEnumerable <ranking_system>? obtener(){
        return context.ranking_System;
    }
    public async Task actualizar (Guid id, ranking_system inputranking){
        var ranking_System=  context.ranking_System?.Find(id);

        if(ranking_System != null){
            ranking_System.nombre=inputranking.nombre;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var ranking=context.ranking_System?.Find(id);
        if(ranking != null){
            context.Remove(ranking);
            await context.SaveChangesAsync();
        }
    }
}

  public interface IrankingSystemService{
    
       Task insertar (ranking_system inputranking);
    IEnumerable<ranking_system>? obtener();
    Task actualizar(Guid id, ranking_system inputranking);
    Task eliminar(Guid id);
    }
