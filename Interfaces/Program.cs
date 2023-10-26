interface Iperson
{
  int Id { get; set; }
  int FirstName { get; set; }
  int LastName { get; set; }  
}

class Customer : Iperson
{
   public int Id { get; set; }
   public int FirstName { get; set; }
   public int LastName { get; set; } 
   public string Address { get; set; }

}
class Student : Iperson
{

    public int Id { get; set; }
    public int FirstName { get; set; }
    public int LastName { get; set; }

    public string Departmant { get; set; }
}