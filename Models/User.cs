public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public User(int id, string name, string email, string phone, string password, int age, string address)
    {
        ID = id;
        Name = name;
        Email = email;
        Phone = phone;
        Password = password;
        Age = age;
        Address = address;
    }
}
