abstract class Employee{
        string name;
        int EmployeeId;
        decimal Salary;
        public Employee(string name,int EmployeeId,decimal Salary){
            this.name = name;
            this.EmployeeId = EmployeeId;
            this.Salary = Salary;
        }
        public Employee(string name)
            :this(name,0,0)
        {
        }
        public Employee(string name,int EmployeeId)
            : this(name, EmployeeId, 0)
        {
        }
        
        public string Name { 
            get { return this.name; } 
            set{ this.name=value;}                
        }
        public int employeeId { 
            get { return this.EmployeeId; } 
            set{ this.EmployeeId=value;}
        }
        public decimal salary { 
            get { return this.Salary; }
            set{ this.Salary=value;}
        }
        public abstract void GetSalaryDetail();

}
