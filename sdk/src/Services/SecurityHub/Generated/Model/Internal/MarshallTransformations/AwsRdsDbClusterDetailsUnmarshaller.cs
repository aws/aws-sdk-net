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
    /// Response Unmarshaller for AwsRdsDbClusterDetails Object
    /// </summary>  
    public class AwsRdsDbClusterDetailsUnmarshaller : IUnmarshaller<AwsRdsDbClusterDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsRdsDbClusterDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsRdsDbClusterDetails IUnmarshaller<AwsRdsDbClusterDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsRdsDbClusterDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsRdsDbClusterDetails unmarshalledObject = new AwsRdsDbClusterDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActivityStreamStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActivityStreamStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AllocatedStorage", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AllocatedStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssociatedRoles", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbClusterAssociatedRole, AwsRdsDbClusterAssociatedRoleUnmarshaller>(AwsRdsDbClusterAssociatedRoleUnmarshaller.Instance);
                    unmarshalledObject.AssociatedRoles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailabilityZones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BackupRetentionPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterCreateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterCreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CopyTagsToSnapshot", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTagsToSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrossAccountClone", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrossAccountClone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomEndpoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CustomEndpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbClusterIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbClusterIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbClusterMembers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbClusterMember, AwsRdsDbClusterMemberUnmarshaller>(AwsRdsDbClusterMemberUnmarshaller.Instance);
                    unmarshalledObject.DbClusterMembers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbClusterOptionGroupMemberships", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbClusterOptionGroupMembership, AwsRdsDbClusterOptionGroupMembershipUnmarshaller>(AwsRdsDbClusterOptionGroupMembershipUnmarshaller.Instance);
                    unmarshalledObject.DbClusterOptionGroupMemberships = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbClusterParameterGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbClusterParameterGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbClusterResourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbClusterResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbSubnetGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbSubnetGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeletionProtection", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeletionProtection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainMemberships", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbDomainMembership, AwsRdsDbDomainMembershipUnmarshaller>(AwsRdsDbDomainMembershipUnmarshaller.Instance);
                    unmarshalledObject.DomainMemberships = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnabledCloudWatchLogsExports", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EnabledCloudWatchLogsExports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Engine", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HostedZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HostedZoneId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpEndpointEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.HttpEndpointEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IamDatabaseAuthenticationEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IamDatabaseAuthenticationEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiAz", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MultiAz = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Port", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredBackupWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredBackupWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReaderEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReaderEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadReplicaIdentifiers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReadReplicaIdentifiers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageEncrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StorageEncrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbInstanceVpcSecurityGroup, AwsRdsDbInstanceVpcSecurityGroupUnmarshaller>(AwsRdsDbInstanceVpcSecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.VpcSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsRdsDbClusterDetailsUnmarshaller _instance = new AwsRdsDbClusterDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsRdsDbClusterDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}