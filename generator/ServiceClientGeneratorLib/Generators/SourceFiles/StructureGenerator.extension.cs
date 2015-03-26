namespace ServiceClientGenerator.Generators.SourceFiles
{
    public partial class StructureGenerator
    {
        public string BaseClassString
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.BaseClass))
                {
                    return " : " + this.BaseClass;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
