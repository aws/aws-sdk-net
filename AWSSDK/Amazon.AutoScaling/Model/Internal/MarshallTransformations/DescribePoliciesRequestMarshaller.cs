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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Policies Request Marshaller
    /// </summary>       
    public class DescribePoliciesRequestMarshaller : IMarshaller<IRequest, DescribePoliciesRequest>
    {
        public IRequest Marshall(DescribePoliciesRequest describePoliciesRequest)
        {
            IRequest request = new DefaultRequest(describePoliciesRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DescribePolicies");
            request.Parameters.Add("Version", "2011-01-01");
            if (describePoliciesRequest != null && describePoliciesRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(describePoliciesRequest.AutoScalingGroupName));
            }
            if (describePoliciesRequest != null)
            {
                List<string> policyNamesList = describePoliciesRequest.PolicyNames;

                int policyNamesListIndex = 1;
                foreach (string policyNamesListValue in policyNamesList)
                { 
                    request.Parameters.Add("PolicyNames.member." + policyNamesListIndex, StringUtils.FromString(policyNamesListValue));
                    policyNamesListIndex++;
                }
            }
            if (describePoliciesRequest != null && describePoliciesRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describePoliciesRequest.NextToken));
            }
            if (describePoliciesRequest != null && describePoliciesRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describePoliciesRequest.MaxRecords));
            }

            return request;
        }
    }
}
