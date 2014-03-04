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
    /// Describe Orderable D B Instance Options Request Marshaller
    /// </summary>       
    public class DescribeOrderableDBInstanceOptionsRequestMarshaller : IMarshaller<IRequest, DescribeOrderableDBInstanceOptionsRequest>
    {
        public IRequest Marshall(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest)
        {
            IRequest request = new DefaultRequest(describeOrderableDBInstanceOptionsRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeOrderableDBInstanceOptions");
            request.Parameters.Add("Version", "2013-09-09");
            if (describeOrderableDBInstanceOptionsRequest != null && describeOrderableDBInstanceOptionsRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(describeOrderableDBInstanceOptionsRequest.Engine));
            }
            if (describeOrderableDBInstanceOptionsRequest != null && describeOrderableDBInstanceOptionsRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(describeOrderableDBInstanceOptionsRequest.EngineVersion));
            }
            if (describeOrderableDBInstanceOptionsRequest != null && describeOrderableDBInstanceOptionsRequest.IsSetDBInstanceClass())
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(describeOrderableDBInstanceOptionsRequest.DBInstanceClass));
            }
            if (describeOrderableDBInstanceOptionsRequest != null && describeOrderableDBInstanceOptionsRequest.IsSetLicenseModel())
            {
                request.Parameters.Add("LicenseModel", StringUtils.FromString(describeOrderableDBInstanceOptionsRequest.LicenseModel));
            }
            if (describeOrderableDBInstanceOptionsRequest != null && describeOrderableDBInstanceOptionsRequest.IsSetVpc())
            {
                request.Parameters.Add("Vpc", StringUtils.FromBool(describeOrderableDBInstanceOptionsRequest.Vpc));
            }
            if (describeOrderableDBInstanceOptionsRequest != null && describeOrderableDBInstanceOptionsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeOrderableDBInstanceOptionsRequest.MaxRecords));
            }
            if (describeOrderableDBInstanceOptionsRequest != null && describeOrderableDBInstanceOptionsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeOrderableDBInstanceOptionsRequest.Marker));
            }

            return request;
        }
    }
}
