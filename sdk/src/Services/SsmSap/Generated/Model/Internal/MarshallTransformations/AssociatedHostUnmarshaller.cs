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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SsmSap.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SsmSap.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssociatedHost Object
    /// </summary>  
    public class AssociatedHostUnmarshaller : IUnmarshaller<AssociatedHost, XmlUnmarshallerContext>, IUnmarshaller<AssociatedHost, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssociatedHost IUnmarshaller<AssociatedHost, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AssociatedHost Unmarshall(JsonUnmarshallerContext context)
        {
            AssociatedHost unmarshalledObject = new AssociatedHost();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Ec2InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Hostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpAddresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IpAddressMember, IpAddressMemberUnmarshaller>(IpAddressMemberUnmarshaller.Instance);
                    unmarshalledObject.IpAddresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OsVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OsVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AssociatedHostUnmarshaller _instance = new AssociatedHostUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociatedHostUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618