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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CloudAutonomousVmClusterSummary Object
    /// </summary>  
    public class CloudAutonomousVmClusterSummaryUnmarshaller : IJsonUnmarshaller<CloudAutonomousVmClusterSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CloudAutonomousVmClusterSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CloudAutonomousVmClusterSummary unmarshalledObject = new CloudAutonomousVmClusterSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("autonomousDataStoragePercentage", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.AutonomousDataStoragePercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autonomousDataStorageSizeInTBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.AutonomousDataStorageSizeInTBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availableAutonomousDataStorageSizeInTBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.AvailableAutonomousDataStorageSizeInTBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availableContainerDatabases", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AvailableContainerDatabases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availableCpus", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.AvailableCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloudAutonomousVmClusterArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudAutonomousVmClusterArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloudAutonomousVmClusterId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudAutonomousVmClusterId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloudExadataInfrastructureArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudExadataInfrastructureArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloudExadataInfrastructureId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudExadataInfrastructureId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("computeModel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputeModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpuCoreCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CpuCoreCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpuCoreCountPerNode", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CpuCoreCountPerNode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpuPercentage", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.CpuPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataStorageSizeInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.DataStorageSizeInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataStorageSizeInTBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.DataStorageSizeInTBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dbNodeStorageSizeInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DbNodeStorageSizeInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dbServers", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DbServers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("domain", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Domain = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("exadataStorageInTBsLowestScaledValue", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.ExadataStorageInTBsLowestScaledValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hostname", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iamRoles", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IamRole, IamRoleUnmarshaller>(IamRoleUnmarshaller.Instance);
                    unmarshalledObject.IamRoles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isMtlsEnabledVmCluster", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsMtlsEnabledVmCluster = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("licenseModel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maintenanceWindow", targetDepth, ref reader))
                {
                    var unmarshaller = MaintenanceWindowUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceWindow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maxAcdsLowestScaledValue", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxAcdsLowestScaledValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryPerOracleComputeUnitInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MemoryPerOracleComputeUnitInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memorySizeInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MemorySizeInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NodeCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nonProvisionableAutonomousContainerDatabases", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NonProvisionableAutonomousContainerDatabases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ocid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ocid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ociResourceAnchorName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OciResourceAnchorName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ociUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OciUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("odbNetworkArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbNetworkArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("odbNetworkId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbNetworkId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("percentProgress", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.PercentProgress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("provisionableAutonomousContainerDatabases", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ProvisionableAutonomousContainerDatabases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("provisionedAutonomousContainerDatabases", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedAutonomousContainerDatabases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("provisionedCpus", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reclaimableCpus", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.ReclaimableCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reservedCpus", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.ReservedCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scanListenerPortNonTls", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ScanListenerPortNonTls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scanListenerPortTls", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ScanListenerPortTls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("shape", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Shape = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeDatabaseSslCertificateExpires", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeDatabaseSslCertificateExpires = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOrdsCertificateExpires", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOrdsCertificateExpires = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeZone", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalContainerDatabases", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TotalContainerDatabases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CloudAutonomousVmClusterSummaryUnmarshaller _instance = new CloudAutonomousVmClusterSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CloudAutonomousVmClusterSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}