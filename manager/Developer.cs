class Developer:Employee
    {
        string programminglanaguage;
        public Developer(string programminglanaguage,string name,int empId,decimal Salary):base(name,empId,Salary)
        {
            this.programminglanaguage = programminglanaguage;
        }
        public Developer(string programminglanaguage, string name)
            : base(name,0,0)
        {
            this.programminglanaguage = programminglanaguage;
        }
        public Developer(string programminglanaguage, string name, int empId)
            : base(name, empId, 0)
        {
            this.programminglanaguage = programminglanaguage;
        }
        public string ProgrammingLanaguage { 
            get { return this.programminglanaguage; }
            set { this.programminglanaguage = value; }
        }
        public void WriteCode() { Console.WriteLine("Developer is wirting"); }
        public override void GetSalaryDetail()
        {
            Console.WriteLine("Name: {0}\nId: {1}\nProgrammingLanaguage: {2}\nSalary: {3}", this.Name, this.employeeId, this.programminglanaguage, this.salary);
        }
    }

