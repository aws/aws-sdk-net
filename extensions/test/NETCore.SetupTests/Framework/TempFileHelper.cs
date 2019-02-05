using System;
using System.IO;

namespace Amazon.NETCore.SetupTests
{
    public class TempFileHelper : IDisposable
    {
        public readonly string Path;

        public TempFileHelper()
        {
            Path = System.IO.Path.GetTempFileName();
        }
        public TempFileHelper(string contents) : this()
        {
            Write(contents);
        }

        public TempFileHelper Write(string contents)
        {
            File.WriteAllText(Path, contents);
            return this;
        }

        public void Dispose()
        {
            try
            {
                File.Delete(Path);
            } catch{}
        }
    }
}
