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
    public enum ServiceType { Json, Query, Rest_Xml, Rest_Json, Cbor };

    /// <summary>
    /// Where the properties of the request should be placed
    /// </summary>
    public enum MarshallLocation { Header, Uri, QueryString, StatusCode, Body, Headers };

    /// <summary>
    /// What type of Model is being generated
    /// </summary>
    public enum StructureType { Structure, Request, Response, Result };

    /// <summary>
    /// TimestampFormat that may be specified  on a member or a shape.
    /// Here is how we determine the timestampFormat to be used.
    /// 
    /// 1. Use the timestampFormat trait of the member reference if present.
    /// 2. Use the timestampFormat trait of the shape if present.
    /// 3. Use the format required by the protocol for the given location.
    /// 
    /// Rules used to default the format if timestampFormat is not specified.
    /// 1. All timestamp values serialized in HTTP headers are formatted using rfc822 by default.
    /// 2. All timestamp values serialized in query strings are formatted using iso8601 by default.
    /// 3. The default timestamp formats per protocol for structured payload shapes are as follows. 
    ///     rest-json: unixTimestamp
    ///     jsonrpc: unixTimestamp
    ///     rest-xml: iso8601
    ///     query: iso8601
    ///     ec2: iso8601
    /// </summary>
    public enum TimestampFormat { None, ISO8601, RFC822, UnixTimestamp }
    
}
