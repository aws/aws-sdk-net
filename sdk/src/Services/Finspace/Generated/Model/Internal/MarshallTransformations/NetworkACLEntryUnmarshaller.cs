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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkACLEntry Object
    /// </summary>  
    public class NetworkACLEntryUnmarshaller : IJsonUnmarshaller<NetworkACLEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkACLEntry Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            NetworkACLEntry unmarshalledObject = new NetworkACLEntry();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CidrBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("icmpTypeCode", targetDepth))
                {
                    var unmarshaller = IcmpTypeCodeUnmarshaller.Instance;
                    unmarshalledObject.IcmpTypeCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("portRange", targetDepth))
                {
                    var unmarshaller = PortRangeUnmarshaller.Instance;
                    unmarshalledObject.PortRange = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("protocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Protocol = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ruleAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuleAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ruleNumber", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RuleNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NetworkACLEntryUnmarshaller _instance = new NetworkACLEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkACLEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}