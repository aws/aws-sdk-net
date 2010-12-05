/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Restore D B Instance From D B Snapshot Request Marshaller
    /// </summary>       
    public class RestoreDBInstanceFromDBSnapshotRequestMarshaller : IMarshaller<IRequest<RestoreDBInstanceFromDBSnapshotRequest>, RestoreDBInstanceFromDBSnapshotRequest> 
    {

        public IRequest<RestoreDBInstanceFromDBSnapshotRequest> Marshall(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest) 
        {
            IRequest<RestoreDBInstanceFromDBSnapshotRequest> request = new DefaultRequest<RestoreDBInstanceFromDBSnapshotRequest>(restoreDBInstanceFromDBSnapshotRequest, "AmazonRDS");
            request.Parameters.Add("Action", "RestoreDBInstanceFromDBSnapshot");
            request.Parameters.Add("Version", "2010-07-28");
            if (restoreDBInstanceFromDBSnapshotRequest != null && restoreDBInstanceFromDBSnapshotRequest.IsSetDBInstanceIdentifier()) 
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(restoreDBInstanceFromDBSnapshotRequest.DBInstanceIdentifier));
            }
            if (restoreDBInstanceFromDBSnapshotRequest != null && restoreDBInstanceFromDBSnapshotRequest.IsSetDBSnapshotIdentifier()) 
            {
                request.Parameters.Add("DBSnapshotIdentifier", StringUtils.FromString(restoreDBInstanceFromDBSnapshotRequest.DBSnapshotIdentifier));
            }
            if (restoreDBInstanceFromDBSnapshotRequest != null && restoreDBInstanceFromDBSnapshotRequest.IsSetDBInstanceClass()) 
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(restoreDBInstanceFromDBSnapshotRequest.DBInstanceClass));
            }
            if (restoreDBInstanceFromDBSnapshotRequest != null && restoreDBInstanceFromDBSnapshotRequest.IsSetPort()) 
            {
                request.Parameters.Add("Port", StringUtils.FromInt(restoreDBInstanceFromDBSnapshotRequest.Port));
            }
            if (restoreDBInstanceFromDBSnapshotRequest != null && restoreDBInstanceFromDBSnapshotRequest.IsSetAvailabilityZone()) 
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(restoreDBInstanceFromDBSnapshotRequest.AvailabilityZone));
            }
            if (restoreDBInstanceFromDBSnapshotRequest != null && restoreDBInstanceFromDBSnapshotRequest.IsSetMultiAZ()) 
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(restoreDBInstanceFromDBSnapshotRequest.MultiAZ));
            }
            if (restoreDBInstanceFromDBSnapshotRequest != null && restoreDBInstanceFromDBSnapshotRequest.IsSetAutoMinorVersionUpgrade()) 
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(restoreDBInstanceFromDBSnapshotRequest.AutoMinorVersionUpgrade));
            }


            return request;
        }
    }
}
