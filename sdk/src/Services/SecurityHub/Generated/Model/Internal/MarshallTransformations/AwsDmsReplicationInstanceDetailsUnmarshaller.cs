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

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsDmsReplicationInstanceDetails Object
    /// </summary>  
    public class AwsDmsReplicationInstanceDetailsUnmarshaller : IUnmarshaller<AwsDmsReplicationInstanceDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsDmsReplicationInstanceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsDmsReplicationInstanceDetails IUnmarshaller<AwsDmsReplicationInstanceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsDmsReplicationInstanceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            AwsDmsReplicationInstanceDetails unmarshalledObject = new AwsDmsReplicationInstanceDetails();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllocatedStorage", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AllocatedStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoMinorVersionUpgrade = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiAZ", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MultiAZ = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PubliclyAccessible", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationSubnetGroup", targetDepth))
                {
                    var unmarshaller = AwsDmsReplicationInstanceReplicationSubnetGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.ReplicationSubnetGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsDmsReplicationInstanceVpcSecurityGroupsDetails, AwsDmsReplicationInstanceVpcSecurityGroupsDetailsUnmarshaller>(AwsDmsReplicationInstanceVpcSecurityGroupsDetailsUnmarshaller.Instance);
                    unmarshalledObject.VpcSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsDmsReplicationInstanceDetailsUnmarshaller _instance = new AwsDmsReplicationInstanceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsDmsReplicationInstanceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618