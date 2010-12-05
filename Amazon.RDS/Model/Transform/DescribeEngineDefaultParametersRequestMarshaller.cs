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
    /// Describe Engine Default Parameters Request Marshaller
    /// </summary>       
    public class DescribeEngineDefaultParametersRequestMarshaller : IMarshaller<IRequest<DescribeEngineDefaultParametersRequest>, DescribeEngineDefaultParametersRequest> 
    {

        public IRequest<DescribeEngineDefaultParametersRequest> Marshall(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest) 
        {
            IRequest<DescribeEngineDefaultParametersRequest> request = new DefaultRequest<DescribeEngineDefaultParametersRequest>(describeEngineDefaultParametersRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeEngineDefaultParameters");
            request.Parameters.Add("Version", "2010-07-28");
            if (describeEngineDefaultParametersRequest != null && describeEngineDefaultParametersRequest.IsSetDBParameterGroupFamily()) 
            {
                request.Parameters.Add("DBParameterGroupFamily", StringUtils.FromString(describeEngineDefaultParametersRequest.DBParameterGroupFamily));
            }
            if (describeEngineDefaultParametersRequest != null && describeEngineDefaultParametersRequest.IsSetMaxRecords()) 
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeEngineDefaultParametersRequest.MaxRecords));
            }
            if (describeEngineDefaultParametersRequest != null && describeEngineDefaultParametersRequest.IsSetMarker()) 
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeEngineDefaultParametersRequest.Marker));
            }


            return request;
        }
    }
}
