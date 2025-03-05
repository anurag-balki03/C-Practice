using System;

public class Manager
{
    public string Name { get; set; }
}

public class Department
{
    public Manager Manager { get; set; }

    // Shallow Copy
    public Department ShallowCopy()
    {
        return (Department)this.MemberwiseClone();
    }

    // Deep Copy
    public Department DeepCopy()
    {
        Department clone = (Department)this.MemberwiseClone();
        clone.Manager = new Manager { Name = this.Manager.Name };
        return clone;
    }
}
