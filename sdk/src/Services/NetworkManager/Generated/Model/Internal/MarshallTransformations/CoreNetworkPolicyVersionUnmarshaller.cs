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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CoreNetworkPolicyVersion Object
    /// </summary>  
    public class CoreNetworkPolicyVersionUnmarshaller : IUnmarshaller<CoreNetworkPolicyVersion, XmlUnmarshallerContext>, IUnmarshaller<CoreNetworkPolicyVersion, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CoreNetworkPolicyVersion IUnmarshaller<CoreNetworkPolicyVersion, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CoreNetworkPolicyVersion Unmarshall(JsonUnmarshallerContext context)
        {
            CoreNetworkPolicyVersion unmarshalledObject = new CoreNetworkPolicyVersion();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Alias", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Alias = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChangeSetState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChangeSetState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CoreNetworkId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CoreNetworkId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyVersionId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PolicyVersionId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CoreNetworkPolicyVersionUnmarshaller _instance = new CoreNetworkPolicyVersionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CoreNetworkPolicyVersionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618