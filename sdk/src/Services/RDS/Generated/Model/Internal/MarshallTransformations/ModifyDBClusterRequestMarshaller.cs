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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBCluster Request Marshaller
    /// </summary>       
    public class ModifyDBClusterRequestMarshaller : IMarshaller<IRequest, ModifyDBClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBClusterRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyDBClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ModifyDBCluster");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllowMajorVersionUpgrade())
                {
                    request.Parameters.Add("AllowMajorVersionUpgrade", StringUtils.FromBool(publicRequest.AllowMajorVersionUpgrade));
                }
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
                if(publicRequest.IsSetBacktrackWindow())
                {
                    request.Parameters.Add("BacktrackWindow", StringUtils.FromLong(publicRequest.BacktrackWindow));
                }
                if(publicRequest.IsSetBackupRetentionPeriod())
                {
                    request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(publicRequest.BackupRetentionPeriod));
                }
                if(publicRequest.IsSetCloudwatchLogsExportConfiguration())
                {
                    if(publicRequest.CloudwatchLogsExportConfiguration.IsSetDisableLogTypes())
                    {
                        int publicRequestCloudwatchLogsExportConfigurationlistValueIndex = 1;
                        foreach(var publicRequestCloudwatchLogsExportConfigurationlistValue in publicRequest.CloudwatchLogsExportConfiguration.DisableLogTypes)
                        {
                            request.Parameters.Add("CloudwatchLogsExportConfiguration" + "." + "DisableLogTypes" + "." + "member" + "." + publicRequestCloudwatchLogsExportConfigurationlistValueIndex, StringUtils.FromString(publicRequestCloudwatchLogsExportConfigurationlistValue));
                            publicRequestCloudwatchLogsExportConfigurationlistValueIndex++;
                        }
                    }
                    if(publicRequest.CloudwatchLogsExportConfiguration.IsSetEnableLogTypes())
                    {
                        int publicRequestCloudwatchLogsExportConfigurationlistValueIndex = 1;
                        foreach(var publicRequestCloudwatchLogsExportConfigurationlistValue in publicRequest.CloudwatchLogsExportConfiguration.EnableLogTypes)
                        {
                            request.Parameters.Add("CloudwatchLogsExportConfiguration" + "." + "EnableLogTypes" + "." + "member" + "." + publicRequestCloudwatchLogsExportConfigurationlistValueIndex, StringUtils.FromString(publicRequestCloudwatchLogsExportConfigurationlistValue));
                            publicRequestCloudwatchLogsExportConfigurationlistValueIndex++;
                        }
                    }
                }
                if(publicRequest.IsSetCopyTagsToSnapshot())
                {
                    request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot));
                }
                if(publicRequest.IsSetDBClusterIdentifier())
                {
                    request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
                }
                if(publicRequest.IsSetDBClusterParameterGroupName())
                {
                    request.Parameters.Add("DBClusterParameterGroupName", StringUtils.FromString(publicRequest.DBClusterParameterGroupName));
                }
                if(publicRequest.IsSetDBInstanceParameterGroupName())
                {
                    request.Parameters.Add("DBInstanceParameterGroupName", StringUtils.FromString(publicRequest.DBInstanceParameterGroupName));
                }
                if(publicRequest.IsSetDeletionProtection())
                {
                    request.Parameters.Add("DeletionProtection", StringUtils.FromBool(publicRequest.DeletionProtection));
                }
                if(publicRequest.IsSetDomain())
                {
                    request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
                }
                if(publicRequest.IsSetDomainIAMRoleName())
                {
                    request.Parameters.Add("DomainIAMRoleName", StringUtils.FromString(publicRequest.DomainIAMRoleName));
                }
                if(publicRequest.IsSetEnableGlobalWriteForwarding())
                {
                    request.Parameters.Add("EnableGlobalWriteForwarding", StringUtils.FromBool(publicRequest.EnableGlobalWriteForwarding));
                }
                if(publicRequest.IsSetEnableHttpEndpoint())
                {
                    request.Parameters.Add("EnableHttpEndpoint", StringUtils.FromBool(publicRequest.EnableHttpEndpoint));
                }
                if(publicRequest.IsSetEnableIAMDatabaseAuthentication())
                {
                    request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication));
                }
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
                if(publicRequest.IsSetMasterUserPassword())
                {
                    request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
                }
                if(publicRequest.IsSetNewDBClusterIdentifier())
                {
                    request.Parameters.Add("NewDBClusterIdentifier", StringUtils.FromString(publicRequest.NewDBClusterIdentifier));
                }
                if(publicRequest.IsSetOptionGroupName())
                {
                    request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetPreferredBackupWindow())
                {
                    request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(publicRequest.PreferredBackupWindow));
                }
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
                if(publicRequest.IsSetScalingConfiguration())
                {
                    if(publicRequest.ScalingConfiguration.IsSetAutoPause())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "AutoPause", StringUtils.FromBool(publicRequest.ScalingConfiguration.AutoPause));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetMaxCapacity())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "MaxCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MaxCapacity));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetMinCapacity())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "MinCapacity", StringUtils.FromInt(publicRequest.ScalingConfiguration.MinCapacity));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetSecondsUntilAutoPause())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "SecondsUntilAutoPause", StringUtils.FromInt(publicRequest.ScalingConfiguration.SecondsUntilAutoPause));
                    }
                    if(publicRequest.ScalingConfiguration.IsSetTimeoutAction())
                    {
                        request.Parameters.Add("ScalingConfiguration" + "." + "TimeoutAction", StringUtils.FromString(publicRequest.ScalingConfiguration.TimeoutAction));
                    }
                }
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static ModifyDBClusterRequestMarshaller _instance = new ModifyDBClusterRequestMarshaller();        

        internal static ModifyDBClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}