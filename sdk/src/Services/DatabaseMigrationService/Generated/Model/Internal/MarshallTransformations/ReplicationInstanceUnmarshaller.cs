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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReplicationInstance Object
    /// </summary>  
    public class ReplicationInstanceUnmarshaller : IJsonUnmarshaller<ReplicationInstance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ReplicationInstance Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ReplicationInstance unmarshalledObject = new ReplicationInstance();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AllocatedStorage", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AllocatedStorage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AutoMinorVersionUpgrade = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsNameServers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DnsNameServers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FreeUntil", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.FreeUntil = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InstanceCreateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.InstanceCreateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KerberosAuthenticationSettings", targetDepth))
                {
                    var unmarshaller = KerberosAuthenticationSettingsUnmarshaller.Instance;
                    unmarshalledObject.KerberosAuthenticationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MultiAZ", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.MultiAZ = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PendingModifiedValues", targetDepth))
                {
                    var unmarshaller = ReplicationPendingModifiedValuesUnmarshaller.Instance;
                    unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PubliclyAccessible", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceClass = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceIdentifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceIpv6Addresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReplicationInstanceIpv6Addresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstancePrivateIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstancePrivateIpAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstancePrivateIpAddresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReplicationInstancePrivateIpAddresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstancePublicIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstancePublicIpAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstancePublicIpAddresses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReplicationInstancePublicIpAddresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicationSubnetGroup", targetDepth))
                {
                    var unmarshaller = ReplicationSubnetGroupUnmarshaller.Instance;
                    unmarshalledObject.ReplicationSubnetGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecondaryAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecondaryAvailabilityZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcSecurityGroups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<VpcSecurityGroupMembership, VpcSecurityGroupMembershipUnmarshaller>(VpcSecurityGroupMembershipUnmarshaller.Instance);
                    unmarshalledObject.VpcSecurityGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReplicationInstanceUnmarshaller _instance = new ReplicationInstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}