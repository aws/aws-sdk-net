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
    /// Describe D B Parameters Request Marshaller
    /// </summary>       
    public class DescribeDBParametersRequestMarshaller : IMarshaller<IRequest<DescribeDBParametersRequest>, DescribeDBParametersRequest> 
    {

        public IRequest<DescribeDBParametersRequest> Marshall(DescribeDBParametersRequest describeDBParametersRequest) 
        {
            IRequest<DescribeDBParametersRequest> request = new DefaultRequest<DescribeDBParametersRequest>(describeDBParametersRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeDBParameters");
            request.Parameters.Add("Version", "2010-07-28");
            if (describeDBParametersRequest != null && describeDBParametersRequest.IsSetDBParameterGroupName()) 
            {
                request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(describeDBParametersRequest.DBParameterGroupName));
            }
            if (describeDBParametersRequest != null && describeDBParametersRequest.IsSetSource()) 
            {
                request.Parameters.Add("Source", StringUtils.FromString(describeDBParametersRequest.Source));
            }
            if (describeDBParametersRequest != null && describeDBParametersRequest.IsSetMaxRecords()) 
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeDBParametersRequest.MaxRecords));
            }
            if (describeDBParametersRequest != null && describeDBParametersRequest.IsSetMarker()) 
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeDBParametersRequest.Marker));
            }


            return request;
        }
    }
}
