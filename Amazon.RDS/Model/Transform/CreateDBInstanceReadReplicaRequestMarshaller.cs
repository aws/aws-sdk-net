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
    /// Create D B Instance Read Replica Request Marshaller
    /// </summary>       
    public class CreateDBInstanceReadReplicaRequestMarshaller : IMarshaller<IRequest<CreateDBInstanceReadReplicaRequest>, CreateDBInstanceReadReplicaRequest> 
    {

        public IRequest<CreateDBInstanceReadReplicaRequest> Marshall(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest) 
        {
            IRequest<CreateDBInstanceReadReplicaRequest> request = new DefaultRequest<CreateDBInstanceReadReplicaRequest>(createDBInstanceReadReplicaRequest, "AmazonRDS");
            request.Parameters.Add("Action", "CreateDBInstanceReadReplica");
            request.Parameters.Add("Version", "2010-07-28");
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetDBInstanceIdentifier()) 
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(createDBInstanceReadReplicaRequest.DBInstanceIdentifier));
            }
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetSourceDBInstanceIdentifier()) 
            {
                request.Parameters.Add("SourceDBInstanceIdentifier", StringUtils.FromString(createDBInstanceReadReplicaRequest.SourceDBInstanceIdentifier));
            }
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetDBInstanceClass()) 
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(createDBInstanceReadReplicaRequest.DBInstanceClass));
            }
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetAvailabilityZone()) 
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(createDBInstanceReadReplicaRequest.AvailabilityZone));
            }
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetPort()) 
            {
                request.Parameters.Add("Port", StringUtils.FromInt(createDBInstanceReadReplicaRequest.Port));
            }
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetAutoMinorVersionUpgrade()) 
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(createDBInstanceReadReplicaRequest.AutoMinorVersionUpgrade));
            }


            return request;
        }
    }
}
