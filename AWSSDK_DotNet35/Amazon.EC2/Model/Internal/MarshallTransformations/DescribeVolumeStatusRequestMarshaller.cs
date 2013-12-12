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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Volume Status Request Marshaller
    /// </summary>       
    public class DescribeVolumeStatusRequestMarshaller : IMarshaller<IRequest, DescribeVolumeStatusRequest>
    {
        public IRequest Marshall(DescribeVolumeStatusRequest describeVolumeStatusRequest)
        {
            IRequest request = new DefaultRequest(describeVolumeStatusRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DescribeVolumeStatus");
            request.Parameters.Add("Version", "2013-10-15");
            if (describeVolumeStatusRequest != null)
            {
                List<string> volumeIdsList = describeVolumeStatusRequest.VolumeIds;

                int volumeIdsListIndex = 1;
                foreach (string volumeIdsListValue in volumeIdsList)
                { 
                    request.Parameters.Add("VolumeId." + volumeIdsListIndex, StringUtils.FromString(volumeIdsListValue));
                    volumeIdsListIndex++;
                }
            }

            if (describeVolumeStatusRequest != null)
            {
                List<Filter> filtersList = describeVolumeStatusRequest.Filters;
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
            if (describeVolumeStatusRequest != null && describeVolumeStatusRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeVolumeStatusRequest.NextToken));
            }
            if (describeVolumeStatusRequest != null && describeVolumeStatusRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(describeVolumeStatusRequest.MaxResults));
            }

            return request;
        }
    }
}
