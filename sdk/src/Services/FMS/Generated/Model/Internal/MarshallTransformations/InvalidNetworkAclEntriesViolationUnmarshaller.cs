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
    /// Response Unmarshaller for InvalidNetworkAclEntriesViolation Object
    /// </summary>  
    public class InvalidNetworkAclEntriesViolationUnmarshaller : IUnmarshaller<InvalidNetworkAclEntriesViolation, XmlUnmarshallerContext>, IUnmarshaller<InvalidNetworkAclEntriesViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InvalidNetworkAclEntriesViolation IUnmarshaller<InvalidNetworkAclEntriesViolation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InvalidNetworkAclEntriesViolation Unmarshall(JsonUnmarshallerContext context)
        {
            InvalidNetworkAclEntriesViolation unmarshalledObject = new InvalidNetworkAclEntriesViolation();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrentAssociatedNetworkAcl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentAssociatedNetworkAcl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntryViolations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EntryViolation, EntryViolationUnmarshaller>(EntryViolationUnmarshaller.Instance);
                    unmarshalledObject.EntryViolations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Subnet", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Subnet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetAvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Vpc", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Vpc = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InvalidNetworkAclEntriesViolationUnmarshaller _instance = new InvalidNetworkAclEntriesViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvalidNetworkAclEntriesViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}