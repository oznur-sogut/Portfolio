namespace Portfolio.DataAccessLayer.Entities
{
	public class ToDoList
	{
		public int ToDoListID { get; set; }
		public string ToDoListName { get; set; }
		public DateTime ToDoListDate { get; set; }
		public string ToDoListImageUrl { get; set; }
		public bool ToDoListStatus { get; set; }
	}
}
