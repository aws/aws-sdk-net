using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator.ModelReader
{
    public class ResourceModel
    {
        public Service Service { get; set; }
        public Dictionary<string, Resource> Resources { get; set; }        
    }

    public class Service
    {
        public Dictionary<string, Action> Actions { get; set; }
        public Dictionary<string, Action> HasMany { get; set; }
    }

    public class Action
    {
        public Request Request { get; set; }
        public ResourceMapping Resource { get; set; }
        public string Path { get; set; }
    }

    public class Request
    {
        public string Operation { get; set; }
        public List<IdentifierMapping> Params { get; set; }
    }

    public class ResourceMapping
    {
        public string Type { get; set; }
        public List<IdentifierMapping> Identifiers { get; set; }
        public string Path { get; set; }
    }

    public class IdentifierMapping
    {
        public ResourcesApi.SourceType SourceType { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
    }

    public class Resource
    {
        public List<Identifier> Identifiers { get; set; }
        public string Shape { get; set; }
        public Dictionary<string, Action> Actions { get; set; }
        public Action Load { get; set; }
        public Dictionary<string, Action> HasMany { get; set; }
        public Dictionary<string, Action> BelongsTo { get; set; }
        public SubResources SubResources { get; set; }
    }

    public class Identifier
    {
        public string Name { get; set; }
        public string MemberName { get; set; }
    }

    public class SubResources
    {
        public List<string> Resources { get; set; }
        public Dictionary<string,string> Identifiers { get; set; }

    }

    



    //public class ResourceCollection
    //{
    //    public Request request { get; set; }
    //    public ResourceMapping resource { get; set; }

    //}
}
