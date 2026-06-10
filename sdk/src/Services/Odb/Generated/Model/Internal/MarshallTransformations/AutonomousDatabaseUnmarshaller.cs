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
    /// Response Unmarshaller for AutonomousDatabase Object
    /// </summary>  
    public class AutonomousDatabaseUnmarshaller : IJsonUnmarshaller<AutonomousDatabase, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AutonomousDatabase Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AutonomousDatabase unmarshalledObject = new AutonomousDatabase();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actualUsedDataStorageSizeInTBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.ActualUsedDataStorageSizeInTBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("allocatedStorageSizeInTBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.AllocatedStorageSizeInTBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("allowlistedIps", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowlistedIps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("apexDetails", targetDepth, ref reader))
                {
                    var unmarshaller = AutonomousDatabaseApexUnmarshaller.Instance;
                    unmarshalledObject.ApexDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autonomousDatabaseArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutonomousDatabaseArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autonomousDatabaseId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutonomousDatabaseId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autonomousMaintenanceScheduleType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutonomousMaintenanceScheduleType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autoRefreshFrequencyInSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AutoRefreshFrequencyInSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autoRefreshPointLagInSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AutoRefreshPointLagInSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availabilityZone", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availabilityZoneId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availableUpgradeVersions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailableUpgradeVersions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("backupRetentionPeriodInDays", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.BackupRetentionPeriodInDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("byolComputeCountLimit", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ByolComputeCountLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("characterSet", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CharacterSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cloneTableSpaceList", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.CloneTableSpaceList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("computeCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.ComputeCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("computeModel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputeModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectionStringDetails", targetDepth, ref reader))
                {
                    var unmarshaller = AutonomousDatabaseConnectionStringsUnmarshaller.Instance;
                    unmarshalledObject.ConnectionStringDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("connectionUrls", targetDepth, ref reader))
                {
                    var unmarshaller = AutonomousDatabaseConnectionUrlsUnmarshaller.Instance;
                    unmarshalledObject.ConnectionUrls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cpuCoreCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CpuCoreCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("customerContacts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<CustomerContact, CustomerContactUnmarshaller>(CustomerContactUnmarshaller.Instance);
                    unmarshalledObject.CustomerContacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("databaseEdition", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseEdition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("databaseManagementStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseManagementStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("databaseType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataSafeStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataSafeStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataStorageSizeInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataStorageSizeInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataStorageSizeInTBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.DataStorageSizeInTBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dbName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dbToolsDetails", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DatabaseTool, DatabaseToolUnmarshaller>(DatabaseToolUnmarshaller.Instance);
                    unmarshalledObject.DbToolsDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dbVersion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dbWorkload", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbWorkload = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("encryptionSummary", targetDepth, ref reader))
                {
                    var unmarshaller = EncryptionSummaryUnmarshaller.Instance;
                    unmarshalledObject.EncryptionSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("failedDataRecoveryInSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FailedDataRecoveryInSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inMemoryAreaInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InMemoryAreaInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isAutoScalingEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsAutoScalingEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isAutoScalingForStorageEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsAutoScalingForStorageEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isBackupRetentionLocked", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsBackupRetentionLocked = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isLocalDataGuardEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsLocalDataGuardEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isMtlsConnectionRequired", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsMtlsConnectionRequired = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isReconnectCloneEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsReconnectCloneEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isRefreshableClone", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsRefreshableClone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isRemoteDataGuardEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsRemoteDataGuardEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("licenseModel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localAdgAutoFailoverMaxDataLossLimit", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.LocalAdgAutoFailoverMaxDataLossLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localDisasterRecoveryType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalDisasterRecoveryType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localStandbyDb", targetDepth, ref reader))
                {
                    var unmarshaller = DatabaseStandbySummaryUnmarshaller.Instance;
                    unmarshalledObject.LocalStandbyDb = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("longTermBackupSchedule", targetDepth, ref reader))
                {
                    var unmarshaller = LongTermBackupScheduleUnmarshaller.Instance;
                    unmarshalledObject.LongTermBackupSchedule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maintenanceTargetComponent", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceTargetComponent = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryPerOracleComputeUnitInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MemoryPerOracleComputeUnitInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ncharacterSet", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NcharacterSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("netServicesArchitecture", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetServicesArchitecture = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nextLongTermBackupTimeStamp", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.NextLongTermBackupTimeStamp = unmarshaller.Unmarshall(context, ref reader);
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
                if (context.TestExpression("openMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpenMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("operationsInsightsStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperationsInsightsStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("peerDbIds", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PeerDbIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("percentProgress", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.PercentProgress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("permissionLevel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PermissionLevel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privateEndpoint", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateEndpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privateEndpointIp", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateEndpointIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privateEndpointLabel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateEndpointLabel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("provisionableCpus", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.ProvisionableCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("refreshableMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RefreshableMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("refreshableStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RefreshableStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("remoteDisasterRecoveryConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = DisasterRecoveryConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RemoteDisasterRecoveryConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourcePoolLeaderId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourcePoolLeaderId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourcePoolSummary", targetDepth, ref reader))
                {
                    var unmarshaller = ResourcePoolSummaryUnmarshaller.Instance;
                    unmarshalledObject.ResourcePoolSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("role", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Role = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scheduledOperations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ScheduledOperationDetails, ScheduledOperationDetailsUnmarshaller>(ScheduledOperationDetailsUnmarshaller.Instance);
                    unmarshalledObject.ScheduledOperations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceConsoleUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceConsoleUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sourceId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sqlWebDeveloperUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SqlWebDeveloperUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("standbyAllowlistedIps", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StandbyAllowlistedIps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("standbyAllowlistedIpsSource", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StandbyAllowlistedIpsSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("standbyDb", targetDepth, ref reader))
                {
                    var unmarshaller = DatabaseStandbySummaryUnmarshaller.Instance;
                    unmarshalledObject.StandbyDb = unmarshaller.Unmarshall(context, ref reader);
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
                if (context.TestExpression("timeDataGuardRoleChanged", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeDataGuardRoleChanged = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeDeletionOfFreeAutonomousDatabase", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeDeletionOfFreeAutonomousDatabase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeDisasterRecoveryRoleChanged", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeDisasterRecoveryRoleChanged = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeLocalDataGuardEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeLocalDataGuardEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeMaintenanceBegin", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeMaintenanceBegin = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeMaintenanceEnd", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeMaintenanceEnd = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOfAutoRefreshStart", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOfAutoRefreshStart = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOfLastBackup", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOfLastBackup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOfLastFailover", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOfLastFailover = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOfLastRefresh", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOfLastRefresh = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOfLastRefreshPoint", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOfLastRefreshPoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOfLastSwitchover", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOfLastSwitchover = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeOfNextRefresh", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeOfNextRefresh = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeReclamationOfFreeAutonomousDatabase", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeReclamationOfFreeAutonomousDatabase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeUndeleted", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeUndeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeUntilReconnectCloneEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeUntilReconnectCloneEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalBackupStorageSizeInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.TotalBackupStorageSizeInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("usedDataStorageSizeInGBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.UsedDataStorageSizeInGBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("usedDataStorageSizeInTBs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.UsedDataStorageSizeInTBs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutonomousDatabaseUnmarshaller _instance = new AutonomousDatabaseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutonomousDatabaseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}