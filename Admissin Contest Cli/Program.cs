using Admission_Contest_Cli.Model;
using Admission_Contest_Cli.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<int, Candidate> candidateRepo = new MemoryRepository<int, Candidate>();

            candidateRepo.Insert(new Candidate(1, "candidate1", "123456789", "address1"));
            candidateRepo.Insert(new Candidate(2, "candidate2", "123456789", "address2"));
            candidateRepo.Insert(new Candidate(3, "candidate3", "123456789", "address3"));
            candidateRepo.Insert(new Candidate(4, "candidate4", "123456789", "address4"));
            candidateRepo.Insert(new Candidate(5, "candidate5", "123456789", "address5"));

            foreach(Object obj in candidateRepo.All())
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
