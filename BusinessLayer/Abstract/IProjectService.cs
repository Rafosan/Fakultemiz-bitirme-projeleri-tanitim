﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IProjectService:IGenericService<Project>
    {
        //List<Project> TGetListExpression(int id);
        List<Project> TGetListWithExpressionStudentAndTeacher(int id);
    }
}
