class Person
{

	public int Id {get; set;}
	public string Name {get; set;}
	public DateTime DateInsert {get; set;}
	public bool isActive {get; set;}
	
	// New parameter
	public string Country {get; set;}
	// New parameter State
	public string State {get; set;}
	
	// Dev1 2021.09.09 Saturday
	public void Greetings()
	{
		Console.WriteLine("Hello World");
	}
	
}
