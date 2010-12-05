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
    /// Delete D B Instance Request Marshaller
    /// </summary>       
    public class DeleteDBInstanceRequestMarshaller : IMarshaller<IRequest<DeleteDBInstanceRequest>, DeleteDBInstanceRequest> 
    {

        public IRequest<DeleteDBInstanceRequest> Marshall(DeleteDBInstanceRequest deleteDBInstanceRequest) 
        {
            IRequest<DeleteDBInstanceRequest> request = new DefaultRequest<DeleteDBInstanceRequest>(deleteDBInstanceRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DeleteDBInstance");
            request.Parameters.Add("Version", "2010-07-28");
            if (deleteDBInstanceRequest != null && deleteDBInstanceRequest.IsSetDBInstanceIdentifier()) 
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(deleteDBInstanceRequest.DBInstanceIdentifier));
            }
            if (deleteDBInstanceRequest != null && deleteDBInstanceRequest.IsSetSkipFinalSnapshot()) 
            {
                request.Parameters.Add("SkipFinalSnapshot", StringUtils.FromBool(deleteDBInstanceRequest.SkipFinalSnapshot));
            }
            if (deleteDBInstanceRequest != null && deleteDBInstanceRequest.IsSetFinalDBSnapshotIdentifier()) 
            {
                request.Parameters.Add("FinalDBSnapshotIdentifier", StringUtils.FromString(deleteDBInstanceRequest.FinalDBSnapshotIdentifier));
            }


            return request;
        }
    }
}
