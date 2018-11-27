/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServerLaunchConfiguration Object
    /// </summary>  
    public class ServerLaunchConfigurationUnmarshaller : IUnmarshaller<ServerLaunchConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ServerLaunchConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServerLaunchConfiguration IUnmarshaller<ServerLaunchConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServerLaunchConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ServerLaunchConfiguration unmarshalledObject = new ServerLaunchConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("associatePublicIpAddress", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AssociatePublicIpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2KeyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2KeyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logicalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogicalId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("securityGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("server", targetDepth))
                {
                    var unmarshaller = ServerUnmarshaller.Instance;
                    unmarshalledObject.Server = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subnet", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Subnet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userData", targetDepth))
                {
                    var unmarshaller = UserDataUnmarshaller.Instance;
                    unmarshalledObject.UserData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpc", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Vpc = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ServerLaunchConfigurationUnmarshaller _instance = new ServerLaunchConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServerLaunchConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}