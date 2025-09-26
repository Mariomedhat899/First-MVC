using Company.G02.BLL.InterFaces;
using Company.G02.DAL.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.G02.DAL.Data.Contexts;

namespace Company.G02.BLL.Repos
{
    public class DepartmentReposaitory : IDepartmentReposaitory
    {

        private readonly CompanyDbContext _context;

        public DepartmentReposaitory()
        {
            _context = new CompanyDbContext();
        }
        IEnumerable<Department> IDepartmentReposaitory.GetALl()
        {
            return _context.Departments.ToList();
        }

        Department? IDepartmentReposaitory.Get(int Id)
        {
            return _context.Departments.Find(Id);
        }

        int IDepartmentReposaitory.Add(Department model)
        {

            _context.Departments.Add(model);

            return _context.SaveChanges();
        }

        int IDepartmentReposaitory.Update(Department model)
        {

            _context.Departments.Update(model);

            return _context.SaveChanges();

        }

        int IDepartmentReposaitory.Delete(Department model)
        {

            _context.Departments.Remove(model);

            return _context.SaveChanges();
        }
    }
}
