using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public class MyClass
    {
        public string GetOutput(string[] args)
        {
            string result = string.Empty;

            if (args.Length == 2)
            {
                string[] arrayToPrintVersion = { "-v", "--v", "/v", "--version" };
                string[] arrayToPrintSize = { "-s", "--s", "/s", "--size" };
                if (arrayToPrintVersion.Contains(args[0]))
                {
                    FileDetails fileDetails = new FileDetails();
                    result = string.Format("Version = {0}", fileDetails.Version(args[1]));
                }
                else if (arrayToPrintSize.Contains(args[0]))
                {
                    FileDetails fileDetails = new FileDetails();
                    result = string.Format("Size = {0}", fileDetails.Size(args[1]));
                }
                else
                {
                    result = "Please enter valid inputs";
                }
            }
            else
            {
                result = "Please enter valid inputs";
            }

            return result;
        }
    }
}