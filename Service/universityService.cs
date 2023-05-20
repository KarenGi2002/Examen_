using universidades.Models;


namespace universidades.Services;

public class universityService: IuniversityService{
    //inyeccion de dependencia a la base de datos
context context;

public universityService(context dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(university input){
        input.id=Guid.NewGuid();
        await context.AddAsync(input);
        await context.SaveChangesAsync();
    }

    public IEnumerable <university>? obtener(){
        return context.university;
    }
    public async Task actualizar (Guid id, university input){
        var u=  context.university?.Find(id);

        if(u != null){
            u.nombre=input.nombre;
            u.country_id=input.country_id;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var u=context.university?.Find(id);
        if(u != null){
            context.Remove(u);
            await context.SaveChangesAsync();
        }
    }
}

  public interface IuniversityService{
    
       Task insertar (university input);
    IEnumerable<university>? obtener();
    Task actualizar(Guid id, university input);
    Task eliminar(Guid id);
    }
