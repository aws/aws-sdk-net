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

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RemediationAction Object
    /// </summary>  
    public class RemediationActionUnmarshaller : IUnmarshaller<RemediationAction, XmlUnmarshallerContext>, IUnmarshaller<RemediationAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RemediationAction IUnmarshaller<RemediationAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RemediationAction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RemediationAction unmarshalledObject = new RemediationAction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2AssociateRouteTableAction", targetDepth))
                {
                    var unmarshaller = EC2AssociateRouteTableActionUnmarshaller.Instance;
                    unmarshalledObject.EC2AssociateRouteTableAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2CopyRouteTableAction", targetDepth))
                {
                    var unmarshaller = EC2CopyRouteTableActionUnmarshaller.Instance;
                    unmarshalledObject.EC2CopyRouteTableAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2CreateRouteAction", targetDepth))
                {
                    var unmarshaller = EC2CreateRouteActionUnmarshaller.Instance;
                    unmarshalledObject.EC2CreateRouteAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2CreateRouteTableAction", targetDepth))
                {
                    var unmarshaller = EC2CreateRouteTableActionUnmarshaller.Instance;
                    unmarshalledObject.EC2CreateRouteTableAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2DeleteRouteAction", targetDepth))
                {
                    var unmarshaller = EC2DeleteRouteActionUnmarshaller.Instance;
                    unmarshalledObject.EC2DeleteRouteAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2ReplaceRouteAction", targetDepth))
                {
                    var unmarshaller = EC2ReplaceRouteActionUnmarshaller.Instance;
                    unmarshalledObject.EC2ReplaceRouteAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2ReplaceRouteTableAssociationAction", targetDepth))
                {
                    var unmarshaller = EC2ReplaceRouteTableAssociationActionUnmarshaller.Instance;
                    unmarshalledObject.EC2ReplaceRouteTableAssociationAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FMSPolicyUpdateFirewallCreationConfigAction", targetDepth))
                {
                    var unmarshaller = FMSPolicyUpdateFirewallCreationConfigActionUnmarshaller.Instance;
                    unmarshalledObject.FMSPolicyUpdateFirewallCreationConfigAction = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RemediationActionUnmarshaller _instance = new RemediationActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemediationActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}