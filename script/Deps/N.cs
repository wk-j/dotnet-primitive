class Program {
    static void Main(string[] args) =>
        System.Console.WriteLine(
            Newtonsoft.Json.JsonConvert.SerializeObject(new { Greeting = "Hello, world!"})
        );
}