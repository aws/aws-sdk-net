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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkAclEntrySet Object
    /// </summary>  
    public class NetworkAclEntrySetUnmarshaller : IUnmarshaller<NetworkAclEntrySet, XmlUnmarshallerContext>, IUnmarshaller<NetworkAclEntrySet, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkAclEntrySet IUnmarshaller<NetworkAclEntrySet, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkAclEntrySet Unmarshall(JsonUnmarshallerContext context)
        {
            NetworkAclEntrySet unmarshalledObject = new NetworkAclEntrySet();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FirstEntries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkAclEntry, NetworkAclEntryUnmarshaller>(NetworkAclEntryUnmarshaller.Instance);
                    unmarshalledObject.FirstEntries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForceRemediateForFirstEntries", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ForceRemediateForFirstEntries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForceRemediateForLastEntries", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ForceRemediateForLastEntries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastEntries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkAclEntry, NetworkAclEntryUnmarshaller>(NetworkAclEntryUnmarshaller.Instance);
                    unmarshalledObject.LastEntries = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NetworkAclEntrySetUnmarshaller _instance = new NetworkAclEntrySetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkAclEntrySetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}