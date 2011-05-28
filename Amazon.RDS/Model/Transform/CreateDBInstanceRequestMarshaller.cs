/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model.Transform
{
    /// <summary>
    /// Create D B Instance Request Marshaller
    /// </summary>       
    public class CreateDBInstanceRequestMarshaller : IMarshaller<IRequest<CreateDBInstanceRequest>, CreateDBInstanceRequest> 
    {

        public IRequest<CreateDBInstanceRequest> Marshall(CreateDBInstanceRequest createDBInstanceRequest) 
        {
            IRequest<CreateDBInstanceRequest> request = new DefaultRequest<CreateDBInstanceRequest>(createDBInstanceRequest, "AmazonRDS");
            request.Parameters.Add("Action", "CreateDBInstance");
            request.Parameters.Add("Version", "2011-04-01");
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetDBName()) 
            {
                request.Parameters.Add("DBName", StringUtils.FromString(createDBInstanceRequest.DBName));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetDBInstanceIdentifier()) 
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(createDBInstanceRequest.DBInstanceIdentifier));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetAllocatedStorage()) 
            {
                request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(createDBInstanceRequest.AllocatedStorage));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetDBInstanceClass()) 
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(createDBInstanceRequest.DBInstanceClass));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetEngine()) 
            {
                request.Parameters.Add("Engine", StringUtils.FromString(createDBInstanceRequest.Engine));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetMasterUsername()) 
            {
                request.Parameters.Add("MasterUsername", StringUtils.FromString(createDBInstanceRequest.MasterUsername));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetMasterUserPassword()) 
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(createDBInstanceRequest.MasterUserPassword));
            }
            if (createDBInstanceRequest != null) 
            {
                List<string> dBSecurityGroupsList = createDBInstanceRequest.DBSecurityGroups;

                int dBSecurityGroupsListIndex = 1;
                foreach (string dBSecurityGroupsListValue in dBSecurityGroupsList) 
                { 
                    request.Parameters.Add("DBSecurityGroups.member." + dBSecurityGroupsListIndex, StringUtils.FromString(dBSecurityGroupsListValue));
                    dBSecurityGroupsListIndex++;
                }
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetAvailabilityZone()) 
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(createDBInstanceRequest.AvailabilityZone));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetPreferredMaintenanceWindow()) 
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(createDBInstanceRequest.PreferredMaintenanceWindow));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetDBParameterGroupName()) 
            {
                request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(createDBInstanceRequest.DBParameterGroupName));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetBackupRetentionPeriod()) 
            {
                request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(createDBInstanceRequest.BackupRetentionPeriod));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetPreferredBackupWindow()) 
            {
                request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(createDBInstanceRequest.PreferredBackupWindow));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetPort()) 
            {
                request.Parameters.Add("Port", StringUtils.FromInt(createDBInstanceRequest.Port));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetMultiAZ()) 
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(createDBInstanceRequest.MultiAZ));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetEngineVersion()) 
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(createDBInstanceRequest.EngineVersion));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetAutoMinorVersionUpgrade()) 
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(createDBInstanceRequest.AutoMinorVersionUpgrade));
            }
            if (createDBInstanceRequest != null && createDBInstanceRequest.IsSetLicenseModel()) 
            {
                request.Parameters.Add("LicenseModel", StringUtils.FromString(createDBInstanceRequest.LicenseModel));
            }


            return request;
        }
    }
}
