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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Job Flows Request Marshaller
    /// </summary>       
    public class DescribeJobFlowsRequestMarshaller : IMarshaller<IRequest, DescribeJobFlowsRequest>
    {
        public IRequest Marshall(DescribeJobFlowsRequest describeJobFlowsRequest)
        {
            IRequest request = new DefaultRequest(describeJobFlowsRequest, "AmazonElasticMapReduce");
            request.Parameters.Add("Action", "DescribeJobFlows");
            request.Parameters.Add("Version", "2009-03-31");
            if (describeJobFlowsRequest != null && describeJobFlowsRequest.IsSetCreatedAfter())
            {
                request.Parameters.Add("CreatedAfter", StringUtils.FromDateTime(describeJobFlowsRequest.CreatedAfter));
            }
            if (describeJobFlowsRequest != null && describeJobFlowsRequest.IsSetCreatedBefore())
            {
                request.Parameters.Add("CreatedBefore", StringUtils.FromDateTime(describeJobFlowsRequest.CreatedBefore));
            }
            if (describeJobFlowsRequest != null)
            {
                List<string> jobFlowIdsList = describeJobFlowsRequest.JobFlowIds;

                int jobFlowIdsListIndex = 1;
                foreach (string jobFlowIdsListValue in jobFlowIdsList)
                { 
                    request.Parameters.Add("JobFlowIds.member." + jobFlowIdsListIndex, StringUtils.FromString(jobFlowIdsListValue));
                    jobFlowIdsListIndex++;
                }
            }
            if (describeJobFlowsRequest != null)
            {
                List<string> jobFlowStatesList = describeJobFlowsRequest.JobFlowStates;

                int jobFlowStatesListIndex = 1;
                foreach (string jobFlowStatesListValue in jobFlowStatesList)
                { 
                    request.Parameters.Add("JobFlowStates.member." + jobFlowStatesListIndex, StringUtils.FromString(jobFlowStatesListValue));
                    jobFlowStatesListIndex++;
                }
            }

            return request;
        }
    }
}
