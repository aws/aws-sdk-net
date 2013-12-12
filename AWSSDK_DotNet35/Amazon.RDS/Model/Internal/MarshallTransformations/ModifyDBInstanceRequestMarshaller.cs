/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Modify D B Instance Request Marshaller
    /// </summary>       
    public class ModifyDBInstanceRequestMarshaller : IMarshaller<IRequest, ModifyDBInstanceRequest>
    {
        public IRequest Marshall(ModifyDBInstanceRequest modifyDBInstanceRequest)
        {
            IRequest request = new DefaultRequest(modifyDBInstanceRequest, "AmazonRDS");
            request.Parameters.Add("Action", "ModifyDBInstance");
            request.Parameters.Add("Version", "2013-09-09");
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(modifyDBInstanceRequest.DBInstanceIdentifier));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetAllocatedStorage())
            {
                request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(modifyDBInstanceRequest.AllocatedStorage));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetDBInstanceClass())
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(modifyDBInstanceRequest.DBInstanceClass));
            }
            if (modifyDBInstanceRequest != null)
            {
                List<string> dBSecurityGroupsList = modifyDBInstanceRequest.DBSecurityGroups;

                int dBSecurityGroupsListIndex = 1;
                foreach (string dBSecurityGroupsListValue in dBSecurityGroupsList)
                { 
                    request.Parameters.Add("DBSecurityGroups.member." + dBSecurityGroupsListIndex, StringUtils.FromString(dBSecurityGroupsListValue));
                    dBSecurityGroupsListIndex++;
                }
            }
            if (modifyDBInstanceRequest != null)
            {
                List<string> vpcSecurityGroupIdsList = modifyDBInstanceRequest.VpcSecurityGroupIds;

                int vpcSecurityGroupIdsListIndex = 1;
                foreach (string vpcSecurityGroupIdsListValue in vpcSecurityGroupIdsList)
                { 
                    request.Parameters.Add("VpcSecurityGroupIds.member." + vpcSecurityGroupIdsListIndex, StringUtils.FromString(vpcSecurityGroupIdsListValue));
                    vpcSecurityGroupIdsListIndex++;
                }
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(modifyDBInstanceRequest.ApplyImmediately));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(modifyDBInstanceRequest.MasterUserPassword));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetDBParameterGroupName())
            {
                request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(modifyDBInstanceRequest.DBParameterGroupName));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetBackupRetentionPeriod())
            {
                request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(modifyDBInstanceRequest.BackupRetentionPeriod));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetPreferredBackupWindow())
            {
                request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(modifyDBInstanceRequest.PreferredBackupWindow));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(modifyDBInstanceRequest.PreferredMaintenanceWindow));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetMultiAZ())
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(modifyDBInstanceRequest.MultiAZ));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(modifyDBInstanceRequest.EngineVersion));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetAllowMajorVersionUpgrade())
            {
                request.Parameters.Add("AllowMajorVersionUpgrade", StringUtils.FromBool(modifyDBInstanceRequest.AllowMajorVersionUpgrade));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(modifyDBInstanceRequest.AutoMinorVersionUpgrade));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(modifyDBInstanceRequest.Iops));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(modifyDBInstanceRequest.OptionGroupName));
            }
            if (modifyDBInstanceRequest != null && modifyDBInstanceRequest.IsSetNewDBInstanceIdentifier())
            {
                request.Parameters.Add("NewDBInstanceIdentifier", StringUtils.FromString(modifyDBInstanceRequest.NewDBInstanceIdentifier));
            }

            return request;
        }
    }
}
