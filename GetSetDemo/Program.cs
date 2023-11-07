using System; 

class Student {

	private int id;
	private string name;


	public int StdProperties {

		set {

			this.id = value;
		}
		get {

			
			return this.id;
		}
	

	
	}


	class Program {


		static void Main(string[] args ) {

			Student abc = new Student();

			abc.StdProperties = 1000;

			abc.name = "Dibyan";

			Console.WriteLine("Your name is:" +abc.name);



		}
	}

}
