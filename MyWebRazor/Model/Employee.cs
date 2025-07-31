namespace MyWebRazor.Model
{
	public class Employee
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Position { get; set; }

		public int DepartmentId { get; set; }


		public Department? Department { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.Now;



	}
}
	