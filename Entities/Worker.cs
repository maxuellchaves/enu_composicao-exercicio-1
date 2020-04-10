using Composição_exercicio_1.Entities.Enums;


namespace Composição_exercicio_1.Entities
{
    class Worker
    {
        public string  Name { get; set; }
        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }
        public Department Department { get; set; }

    }
}
