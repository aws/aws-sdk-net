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
    /// Describe Default Cluster Parameters Request Marshaller
    /// </summary>       
    public class DescribeDefaultClusterParametersRequestMarshaller : IMarshaller<IRequest, DescribeDefaultClusterParametersRequest>
    {
        public IRequest Marshall(DescribeDefaultClusterParametersRequest describeDefaultClusterParametersRequest)
        {
            IRequest request = new DefaultRequest(describeDefaultClusterParametersRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DescribeDefaultClusterParameters");
            request.Parameters.Add("Version", "2012-12-01");
            if (describeDefaultClusterParametersRequest != null && describeDefaultClusterParametersRequest.IsSetParameterGroupFamily())
            {
                request.Parameters.Add("ParameterGroupFamily", StringUtils.FromString(describeDefaultClusterParametersRequest.ParameterGroupFamily));
            }
            if (describeDefaultClusterParametersRequest != null && describeDefaultClusterParametersRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeDefaultClusterParametersRequest.MaxRecords));
            }
            if (describeDefaultClusterParametersRequest != null && describeDefaultClusterParametersRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeDefaultClusterParametersRequest.Marker));
            }

            return request;
        }
    }
}
