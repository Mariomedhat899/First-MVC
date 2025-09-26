using Company.G02.DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Company.G02.BLL.InterFaces
{
    public interface IDepartmentReposaitory
    {
        IEnumerable<Department> GetALl();

        Department? Get(int Id);

        int Add(Department model);

        int Update(Department model);

        int Delete(Department model);



    }
}
