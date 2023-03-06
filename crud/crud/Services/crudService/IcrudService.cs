namespace crud.Services.crudService
{
    public interface IcrudService
    {
        List<employee> GetAll();
        employee? GetSingle(int id);
        List<employee> Add(employee emp);
        List<employee>? Update(int id, employee request);
        List<employee>? Delete(int id);


    }
}
