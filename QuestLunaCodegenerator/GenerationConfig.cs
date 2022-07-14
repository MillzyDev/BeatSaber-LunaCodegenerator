/// <summary>
/// Watashi no na wa “kirayoshikage” nenrei 33 - sai jitaku wa moriōchō hokutō-bu no bessō chitai ni ari… 
/// kekkon wa shite inai… shigoto wa “kameyūchēn - ten” no kaishain de mainichi osokutomo yoru 8-ji made 
/// ni wa kitaku suru tabako wa suwanai sake wa tashinamu teido yoru 11 tokiniha yuka ni tsuki kanarazu 
/// 8-jikan wa suimin o toru yō ni shite iru… nerumae ni atatakai miruku o nomi 20-bu hodo no sutoretchi
/// de karada o hogushite kara yuka ni tsuku to hotondo asamade jukusui-sa… akanbō no yō ni hirō ya 
/// sutoresu o nokosazu ni asa-me o samaseru nda… kenkōshinda demo ijō nashi to iwa reta yo
/// </summary>

namespace LunaCodegenerator.Quest
{
    public class GenerationConfig
    {
        private static GenerationConfig s_instance;

        public GenerationConfig(IIO io, string codegenJsonPath, string projectOutputPath)
        {
            // DIO!
            IO = io;
            CodegenJsonPath = codegenJsonPath;
            ProjectOutputPath = projectOutputPath;

            s_instance = this;
        }

        public static GenerationConfig Instance { get => s_instance; }

        public IIO IO { get; set; }
        public string CodegenJsonPath { get; set; }
        public string ProjectOutputPath { get; set; }
    }
}
