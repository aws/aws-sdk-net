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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ArgoCdConfigResponse Object
    /// </summary>  
    public class ArgoCdConfigResponseUnmarshaller : IUnmarshaller<ArgoCdConfigResponse, XmlUnmarshallerContext>, IUnmarshaller<ArgoCdConfigResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ArgoCdConfigResponse IUnmarshaller<ArgoCdConfigResponse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ArgoCdConfigResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ArgoCdConfigResponse unmarshalledObject = new ArgoCdConfigResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("awsIdc", targetDepth))
                {
                    var unmarshaller = ArgoCdAwsIdcConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.AwsIdc = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("namespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Namespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkAccess", targetDepth))
                {
                    var unmarshaller = ArgoCdNetworkAccessConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.NetworkAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rbacRoleMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ArgoCdRoleMapping, ArgoCdRoleMappingUnmarshaller>(ArgoCdRoleMappingUnmarshaller.Instance);
                    unmarshalledObject.RbacRoleMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serverUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ArgoCdConfigResponseUnmarshaller _instance = new ArgoCdConfigResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ArgoCdConfigResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}