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
    /// Promote Read Replica Request Marshaller
    /// </summary>       
    public class PromoteReadReplicaRequestMarshaller : IMarshaller<IRequest, PromoteReadReplicaRequest>
    {
        public IRequest Marshall(PromoteReadReplicaRequest promoteReadReplicaRequest)
        {
            IRequest request = new DefaultRequest(promoteReadReplicaRequest, "AmazonRDS");
            request.Parameters.Add("Action", "PromoteReadReplica");
            request.Parameters.Add("Version", "2013-09-09");
            if (promoteReadReplicaRequest != null && promoteReadReplicaRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(promoteReadReplicaRequest.DBInstanceIdentifier));
            }
            if (promoteReadReplicaRequest != null && promoteReadReplicaRequest.IsSetBackupRetentionPeriod())
            {
                request.Parameters.Add("BackupRetentionPeriod", StringUtils.FromInt(promoteReadReplicaRequest.BackupRetentionPeriod));
            }
            if (promoteReadReplicaRequest != null && promoteReadReplicaRequest.IsSetPreferredBackupWindow())
            {
                request.Parameters.Add("PreferredBackupWindow", StringUtils.FromString(promoteReadReplicaRequest.PreferredBackupWindow));
            }

            return request;
        }
    }
}
