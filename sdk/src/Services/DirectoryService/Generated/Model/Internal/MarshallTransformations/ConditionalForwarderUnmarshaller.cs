/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConditionalForwarder Object
    /// </summary>  
    public class ConditionalForwarderUnmarshaller : IUnmarshaller<ConditionalForwarder, XmlUnmarshallerContext>, IUnmarshaller<ConditionalForwarder, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConditionalForwarder IUnmarshaller<ConditionalForwarder, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConditionalForwarder Unmarshall(JsonUnmarshallerContext context)
        {
            ConditionalForwarder unmarshalledObject = new ConditionalForwarder();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DnsIpAddrs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsIpAddrs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsIpv6Addrs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsIpv6Addrs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RemoteDomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteDomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationScope = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConditionalForwarderUnmarshaller _instance = new ConditionalForwarderUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConditionalForwarderUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}