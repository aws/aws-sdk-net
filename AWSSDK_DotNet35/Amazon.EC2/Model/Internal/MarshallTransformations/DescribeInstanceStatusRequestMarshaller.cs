/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Instance Status Request Marshaller
    /// </summary>       
    public class DescribeInstanceStatusRequestMarshaller : IMarshaller<IRequest, DescribeInstanceStatusRequest>
    {
        public IRequest Marshall(DescribeInstanceStatusRequest describeInstanceStatusRequest)
        {
            IRequest request = new DefaultRequest(describeInstanceStatusRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DescribeInstanceStatus");
            request.Parameters.Add("Version", "2014-05-01");
            if (describeInstanceStatusRequest != null)
            {
                List<string> instanceIdsList = describeInstanceStatusRequest.InstanceIds;

                int instanceIdsListIndex = 1;
                foreach (string instanceIdsListValue in instanceIdsList)
                { 
                    request.Parameters.Add("InstanceId." + instanceIdsListIndex, StringUtils.FromString(instanceIdsListValue));
                    instanceIdsListIndex++;
                }
            }

            if (describeInstanceStatusRequest != null)
            {
                List<Filter> filtersList = describeInstanceStatusRequest.Filters;
                int filtersListIndex = 1;
                foreach (Filter filtersListValue in filtersList)
                {
                    if (filtersListValue != null && filtersListValue.IsSetName())
                    {
                        request.Parameters.Add("Filter." + filtersListIndex + ".Name", StringUtils.FromString(filtersListValue.Name));
                    }
                    if (filtersListValue != null)
                    {
                        List<string> valuesList = filtersListValue.Values;

                        int valuesListIndex = 1;
                        foreach (string valuesListValue in valuesList)
                        { 
                            request.Parameters.Add("Filter." + filtersListIndex + ".Value." + valuesListIndex, StringUtils.FromString(valuesListValue));
                            valuesListIndex++;
                        }
                    }

                    filtersListIndex++;
                }
            }
            if (describeInstanceStatusRequest != null && describeInstanceStatusRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeInstanceStatusRequest.NextToken));
            }
            if (describeInstanceStatusRequest != null && describeInstanceStatusRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(describeInstanceStatusRequest.MaxResults));
            }
            if (describeInstanceStatusRequest != null && describeInstanceStatusRequest.IsSetIncludeAllInstances())
            {
                request.Parameters.Add("IncludeAllInstances", StringUtils.FromBool(describeInstanceStatusRequest.IncludeAllInstances));
            }

            return request;
        }
    }
}
