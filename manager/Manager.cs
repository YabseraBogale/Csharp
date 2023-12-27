abstract class Manager:Employee{
        string department;
        public Manager(string department, string name, int EmployeeId, decimal Salary)
            : base(name, EmployeeId, Salary)
        {
            this.department = department;
        }
        public Manager(string department)
            : base("", 0, 0)
        {
            this.department = department;
        }
        public Manager(string department, string name)
            : base(name, 0, 0)
        {
            this.department = department;
        }
        public string Department{ 
            get{ return this.department;}
            set { this.department = value; }
        }
        public override void GetSalaryDetail() {
            Console.WriteLine("Name: {0}\nId: {1}\nDepartment: {2}\nSalary: {3}",this.Name,this.employeeId,this.Department,this.salary);
        }
        public abstract void AssignTask();
}

