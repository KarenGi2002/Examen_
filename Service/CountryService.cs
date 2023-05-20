using universidades.Models;


namespace universidades.Services;

public class CountryService: ICountryService{
    //inyeccion de dependencia a la base de datos
context context;

public CountryService(context dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(Country inputCountry){
        inputCountry.id=Guid.NewGuid();
        await context.AddAsync(inputCountry);
        await context.SaveChangesAsync();
    }

    public IEnumerable <Country>? obtener(){
        return context.country;
    }
    public async Task actualizar (Guid id, Country inputCountry){
        var country=  context.country?.Find(id);

        if(country != null){
            country.nombre=inputCountry.nombre;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var country=context.country?.Find(id);
        if(country != null){
            context.Remove(country);
            await context.SaveChangesAsync();
        }
    }
}

  public interface ICountryService{
    
       Task insertar (Country inputCountry);
    IEnumerable<Country>? obtener();
    Task actualizar(Guid id, Country country);
    Task eliminar(Guid id);
    }
