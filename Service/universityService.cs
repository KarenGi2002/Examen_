using universidades.Models;


namespace universidades.Services;

public class universityService: IUniversityService{
    //inyeccion de dependencia a la base de datos
context context;

public universityService(context dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(University input){
        input.id=Guid.NewGuid();
        await context.AddAsync(input);
        await context.SaveChangesAsync();
    }

    public IEnumerable <University>? obtener(){
        return context.University;
    }
    public async Task actualizar (Guid id, University input){
        var u=  context.University?.Find(id);

        if(u != null){
            u.nombre=input.nombre;
          

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var u=context.University?.Find(id);
        if(u != null){
            context.Remove(u);
            await context.SaveChangesAsync();
        }
    }
}

  public interface IUniversityService{
    
       Task insertar (University input);
    IEnumerable<University>? obtener();
    Task actualizar(Guid id, University input);
    Task eliminar(Guid id);
    }
