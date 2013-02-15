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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Cluster Parameters Request Marshaller
    /// </summary>       
    public class DescribeClusterParametersRequestMarshaller : IMarshaller<IRequest, DescribeClusterParametersRequest>
    {
        public IRequest Marshall(DescribeClusterParametersRequest describeClusterParametersRequest)
        {
            IRequest request = new DefaultRequest(describeClusterParametersRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DescribeClusterParameters");
            request.Parameters.Add("Version", "2012-12-01");
            if (describeClusterParametersRequest != null && describeClusterParametersRequest.IsSetParameterGroupName())
            {
                request.Parameters.Add("ParameterGroupName", StringUtils.FromString(describeClusterParametersRequest.ParameterGroupName));
            }
            if (describeClusterParametersRequest != null && describeClusterParametersRequest.IsSetSource())
            {
                request.Parameters.Add("Source", StringUtils.FromString(describeClusterParametersRequest.Source));
            }
            if (describeClusterParametersRequest != null && describeClusterParametersRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeClusterParametersRequest.MaxRecords));
            }
            if (describeClusterParametersRequest != null && describeClusterParametersRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeClusterParametersRequest.Marker));
            }

            return request;
        }
    }
}
