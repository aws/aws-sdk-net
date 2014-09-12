using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// The set of data protocols used by AWS services
    /// </summary>
    public enum ServiceType { Json, Query, Rest_Xml, Rest_Json };

    /// <summary>
    /// Where the properties of the request should be placed
    /// </summary>
    public enum MarshallLocation { Header, Uri, QueryString, StatusCode, Body };

    /// <summary>
    /// What type of Model is being generated
    /// </summary>
    public enum StructureType { Structure, Request, Response, Result };
}
