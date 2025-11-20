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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManagedIngressPath Object
    /// </summary>  
    public class ManagedIngressPathUnmarshaller : IUnmarshaller<ManagedIngressPath, XmlUnmarshallerContext>, IUnmarshaller<ManagedIngressPath, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ManagedIngressPath IUnmarshaller<ManagedIngressPath, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ManagedIngressPath Unmarshall(JsonUnmarshallerContext context)
        {
            ManagedIngressPath unmarshalledObject = new ManagedIngressPath();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificate", targetDepth))
                {
                    var unmarshaller = ManagedCertificateUnmarshaller.Instance;
                    unmarshalledObject.Certificate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listener", targetDepth))
                {
                    var unmarshaller = ManagedListenerUnmarshaller.Instance;
                    unmarshalledObject.Listener = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loadBalancer", targetDepth))
                {
                    var unmarshaller = ManagedLoadBalancerUnmarshaller.Instance;
                    unmarshalledObject.LoadBalancer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loadBalancerSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ManagedSecurityGroup, ManagedSecurityGroupUnmarshaller>(ManagedSecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.LoadBalancerSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rule", targetDepth))
                {
                    var unmarshaller = ManagedListenerRuleUnmarshaller.Instance;
                    unmarshalledObject.Rule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ManagedTargetGroup, ManagedTargetGroupUnmarshaller>(ManagedTargetGroupUnmarshaller.Instance);
                    unmarshalledObject.TargetGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ManagedIngressPathUnmarshaller _instance = new ManagedIngressPathUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManagedIngressPathUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}