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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsAmazonMqBrokerDetails Object
    /// </summary>  
    public class AwsAmazonMqBrokerDetailsUnmarshaller : IUnmarshaller<AwsAmazonMqBrokerDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsAmazonMqBrokerDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsAmazonMqBrokerDetails IUnmarshaller<AwsAmazonMqBrokerDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsAmazonMqBrokerDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsAmazonMqBrokerDetails unmarshalledObject = new AwsAmazonMqBrokerDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AuthenticationStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuthenticationStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoMinorVersionUpgrade = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BrokerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BrokerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BrokerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BrokerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BrokerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BrokerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionOptions", targetDepth))
                {
                    var unmarshaller = AwsAmazonMqBrokerEncryptionOptionsDetailsUnmarshaller.Instance;
                    unmarshalledObject.EncryptionOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HostInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HostInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LdapServerMetadata", targetDepth))
                {
                    var unmarshaller = AwsAmazonMqBrokerLdapServerMetadataDetailsUnmarshaller.Instance;
                    unmarshalledObject.LdapServerMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Logs", targetDepth))
                {
                    var unmarshaller = AwsAmazonMqBrokerLogsDetailsUnmarshaller.Instance;
                    unmarshalledObject.Logs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaintenanceWindowStartTime", targetDepth))
                {
                    var unmarshaller = AwsAmazonMqBrokerMaintenanceWindowStartTimeDetailsUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceWindowStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PubliclyAccessible", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SubnetIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Users", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsAmazonMqBrokerUsersDetails, AwsAmazonMqBrokerUsersDetailsUnmarshaller>(AwsAmazonMqBrokerUsersDetailsUnmarshaller.Instance);
                    unmarshalledObject.Users = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsAmazonMqBrokerDetailsUnmarshaller _instance = new AwsAmazonMqBrokerDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsAmazonMqBrokerDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}