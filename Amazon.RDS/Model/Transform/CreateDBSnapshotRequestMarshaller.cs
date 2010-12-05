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
    /// Create D B Snapshot Request Marshaller
    /// </summary>       
    public class CreateDBSnapshotRequestMarshaller : IMarshaller<IRequest<CreateDBSnapshotRequest>, CreateDBSnapshotRequest> 
    {

        public IRequest<CreateDBSnapshotRequest> Marshall(CreateDBSnapshotRequest createDBSnapshotRequest) 
        {
            IRequest<CreateDBSnapshotRequest> request = new DefaultRequest<CreateDBSnapshotRequest>(createDBSnapshotRequest, "AmazonRDS");
            request.Parameters.Add("Action", "CreateDBSnapshot");
            request.Parameters.Add("Version", "2010-07-28");
            if (createDBSnapshotRequest != null && createDBSnapshotRequest.IsSetDBSnapshotIdentifier()) 
            {
                request.Parameters.Add("DBSnapshotIdentifier", StringUtils.FromString(createDBSnapshotRequest.DBSnapshotIdentifier));
            }
            if (createDBSnapshotRequest != null && createDBSnapshotRequest.IsSetDBInstanceIdentifier()) 
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(createDBSnapshotRequest.DBInstanceIdentifier));
            }


            return request;
        }
    }
}
