using Microsoft.VisualStudio.TestTools.UnitTesting;
using Admission_Contest_Cli.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admission_Contest_Cli.Model;

namespace Admission_Contest_Cli.Repository.Tests
{
    [TestClass()]
    public class MemoryRepositoryTests
    {
        [TestMethod()]
        public void AllTest()
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();
            Candidate c1 = new Candidate(1, "candidate1", "123456789", "address1");
            Candidate c2 = new Candidate(2, "candidate2", "123456789", "address2");
            Candidate c3 = new Candidate(3, "candidate3", "123456789", "address3");
            candidateRepo.Insert(c1);
            candidateRepo.Insert(c2);
            candidateRepo.Insert(c3);

            Assert.IsTrue(candidateRepo.All().Contains(c1));
            Assert.IsTrue(candidateRepo.All().Contains(c2));
            Assert.IsTrue(candidateRepo.All().Contains(new Candidate(3, "candidate3", "123456789", "address3")));
            Assert.AreEqual(3, candidateRepo.Size());
        }

        [TestMethod()]
        public void DeleteTest()
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();
            Candidate c1 = new Candidate(1, "candidate1", "123456789", "address1");
            Candidate c2 = new Candidate(2, "candidate2", "123456789", "address2");
            Candidate c3 = new Candidate(3, "candidate3", "123456789", "address3");
            candidateRepo.Insert(c1);
            candidateRepo.Insert(c2);
            candidateRepo.Insert(c3);
            Assert.AreEqual(3, candidateRepo.Size());

            candidateRepo.Delete(c1.Id);
            Assert.IsFalse(candidateRepo.All().Contains(c1));
            Assert.AreEqual(2, candidateRepo.Size());

            candidateRepo.Delete(c2.Id);
            Assert.IsFalse(candidateRepo.All().Contains(c2));
            Assert.AreEqual(1, candidateRepo.Size());

            candidateRepo.Delete(c3.Id);
            Assert.IsFalse(candidateRepo.All().Contains(c3));
            Assert.AreEqual(0, candidateRepo.Size());
        }

        [TestMethod()]
        public void InsertTest()
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();
            Candidate c1 = new Candidate(1, "candidate1", "123456789", "address1");
            Candidate c2 = new Candidate(2, "candidate2", "123456789", "address2");
            Candidate c3 = new Candidate(3, "candidate3", "123456789", "address3");

            Assert.AreEqual(0, candidateRepo.Size());

            candidateRepo.Insert(c1);
            Assert.IsTrue(candidateRepo.All().Contains(c1));
            Assert.AreEqual(1, candidateRepo.Size());

            candidateRepo.Insert(c2);
            Assert.IsTrue(candidateRepo.All().Contains(c1));
            Assert.IsTrue(candidateRepo.All().Contains(c2));
            Assert.AreEqual(2, candidateRepo.Size());

            candidateRepo.Insert(c3);
            Assert.IsTrue(candidateRepo.All().Contains(c1));
            Assert.IsTrue(candidateRepo.All().Contains(c2));
            Assert.IsTrue(candidateRepo.All().Contains(c3));
            Assert.AreEqual(3, candidateRepo.Size());
        }

        [TestMethod()]
        public void SizeTest()
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();
            Candidate c1 = new Candidate(1, "candidate1", "123456789", "address1");

            Assert.AreEqual(0, candidateRepo.Size());
            candidateRepo.Insert(c1);
            Assert.AreEqual(1, candidateRepo.Size());

            candidateRepo.Delete(c1.Id);
            Assert.AreEqual(0, candidateRepo.Size());
        }

        [TestMethod()]
        public void UpdateTest()
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();
            candidateRepo.Insert(new Candidate(1, "candidate1", "123456789", "address1"));
            candidateRepo.Insert(new Candidate(2, "candidate2", "123456789", "address2"));
            candidateRepo.Insert(new Candidate(3, "candidate3", "123456789", "address3"));

            Assert.AreEqual("candidate3", candidateRepo.FindById(3).Name);

            candidateRepo.Update(new Candidate(3, "newname", "312", "addr"));

            Assert.AreEqual("newname", candidateRepo.FindById(3).Name);
        }

        [TestMethod()]
        [ExpectedException(typeof(IdNotFoundException))]
        public void FindByIdTest()
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();
            candidateRepo.Insert(new Candidate(1, "candidate1", "123456789", "address1"));
            candidateRepo.Insert(new Candidate(2, "candidate2", "123456789", "address2"));

            Assert.AreEqual(1, candidateRepo.FindById(1).Id);
            Assert.AreEqual(2, candidateRepo.FindById(2).Id);

            candidateRepo.FindById(123);
        }

        [TestMethod()]
        [ExpectedException(typeof(DuplicateIdException))]
        public void InsertTestThrowsException()
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();
            candidateRepo.Insert(new Candidate(1, "candidate1", "123456789", "address1"));
            candidateRepo.Insert(new Candidate(2, "candidate2", "123456789", "address2"));

            Assert.AreEqual(1, candidateRepo.FindById(1).Id);
            Assert.AreEqual(2, candidateRepo.FindById(2).Id);

            candidateRepo.Insert(new Candidate(2, "some candidate", "23423", "addr"));
        }
    }
}