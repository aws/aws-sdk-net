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
    /// Create D B Instance Read Replica Request Marshaller
    /// </summary>       
    public class CreateDBInstanceReadReplicaRequestMarshaller : IMarshaller<IRequest, CreateDBInstanceReadReplicaRequest>
    {
        public IRequest Marshall(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest)
        {
            IRequest request = new DefaultRequest(createDBInstanceReadReplicaRequest, "AmazonRDS");
            request.Parameters.Add("Action", "CreateDBInstanceReadReplica");
            request.Parameters.Add("Version", "2013-01-10");
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
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(createDBInstanceReadReplicaRequest.Iops));
            }
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(createDBInstanceReadReplicaRequest.OptionGroupName));
            }
            if (createDBInstanceReadReplicaRequest != null && createDBInstanceReadReplicaRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(createDBInstanceReadReplicaRequest.PubliclyAccessible));
            }

            return request;
        }
    }
}
