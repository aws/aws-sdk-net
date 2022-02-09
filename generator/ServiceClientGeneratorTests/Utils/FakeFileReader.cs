using ServiceClientGenerator;

namespace ServiceClientGeneratorTests.Utils
{
    public class FakeFileReader : IFileReader
    {
        private readonly string _contents;

        public FakeFileReader(string contents)
        {
            _contents = contents;
        }

        public string ReadAllText(string path)
        {
            return _contents;
        }
    }
}