
    public class Employee
    {

        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }

        public Employee(string csv)
        {
            var values = csv.Split(',');
            if (values.Length == 4)
            {
                Name = values[0];
                Account = values[1];
                Password = values[2];
                Level = int.Parse(values[3]);
            }
            else
            {
                throw new ArgumentException("CSV格式不正確");
            }
        }
    }



