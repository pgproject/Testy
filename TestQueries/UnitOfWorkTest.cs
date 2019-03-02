using NUnit.Framework;
using Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQueries
{
    [TestFixture]
    public class UnitOfWorkTest
    {
        [Test]
        public void UnitOfWorkTestContext()
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                //var course = unitOfWork.Courses.Get(1);
                //Assert.AreNotEqual(course, 1);

                var course1 = unitOfWork.Authors.GetAuthorWithCourses(1);
                Assert.AreEqual(course1, 1);
            }
        }
        [Test]
        public void UnitOfWorkTestContext1()
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                var course = unitOfWork.Courses.Get(1);
                Assert.AreNotSame(course, "1");
            }
        }

        [Test]
        public void UnitOfWorkTestContext2()
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                var course = unitOfWork.Courses.GetTopSellingCourses(100);
                Assert.IsNull(course );
            }
        }
    }
    
}
