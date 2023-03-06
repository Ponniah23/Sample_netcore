namespace crud.Services.crudService
{
    public class crudService : IcrudService
    {
        private static List<employee> employees = new List<employee>
        {
            new employee
            {
                    Id=1,
                    Name="Ponniah",
                    Location="Chennai"
            },
            new employee
            {
                    Id=2,
                    Name="Anand",
                    Location="Nellai"
            }

        };

        public List<employee> Add(employee emp)
        {
            employees.Add(emp);
            return employees;
        }

        public List<employee>? Delete(int id)
        {
            var emp = employees.Find(x => x.Id == id);
            if (emp == null)
                return null;

            employees.Remove(emp);
            return employees;
        }

        public List<employee> GetAll()
        {
           return employees;
        }

        public employee? GetSingle(int id)
        {
            var emp = employees.Find(x => x.Id == id);
            if (emp == null)
                return null;
            return emp;
        }

        public List<employee>? Update(int id, employee request)
        {
            var emp = employees.Find(x => x.Id == id);
            if (emp == null)
                return null;

            emp.Name = request.Name;
            emp.Location = request.Location;
            return employees;
        }
    }
}
