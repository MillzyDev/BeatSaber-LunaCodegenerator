namespace LunaCodegenerator.Quest
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Drag and drop the codegen JSON output file into this window and press Enter.");
                string jsonPath = Console.ReadLine();

                Console.WriteLine("Enter the output path for the project and press Enter.");
                string outputPath = Console.ReadLine();

#if DEBUG
                Console.WriteLine($"jsonPath={jsonPath}\noutputPath={outputPath}");
#endif
                var config = new GenerationConfig(new IO(), jsonPath, outputPath);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void Generate(GenerationConfig config)
        {

        }
    }
}