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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Environments Request Marshaller
    /// </summary>       
    public class DescribeEnvironmentsRequestMarshaller : IMarshaller<IRequest, DescribeEnvironmentsRequest>
    {
        public IRequest Marshall(DescribeEnvironmentsRequest describeEnvironmentsRequest)
        {
            IRequest request = new DefaultRequest(describeEnvironmentsRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "DescribeEnvironments");
            request.Parameters.Add("Version", "2010-12-01");
            if (describeEnvironmentsRequest != null && describeEnvironmentsRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(describeEnvironmentsRequest.ApplicationName));
            }
            if (describeEnvironmentsRequest != null && describeEnvironmentsRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(describeEnvironmentsRequest.VersionLabel));
            }
            if (describeEnvironmentsRequest != null)
            {
                List<string> environmentIdsList = describeEnvironmentsRequest.EnvironmentIds;

                int environmentIdsListIndex = 1;
                foreach (string environmentIdsListValue in environmentIdsList)
                { 
                    request.Parameters.Add("EnvironmentIds.member." + environmentIdsListIndex, StringUtils.FromString(environmentIdsListValue));
                    environmentIdsListIndex++;
                }
            }
            if (describeEnvironmentsRequest != null)
            {
                List<string> environmentNamesList = describeEnvironmentsRequest.EnvironmentNames;

                int environmentNamesListIndex = 1;
                foreach (string environmentNamesListValue in environmentNamesList)
                { 
                    request.Parameters.Add("EnvironmentNames.member." + environmentNamesListIndex, StringUtils.FromString(environmentNamesListValue));
                    environmentNamesListIndex++;
                }
            }
            if (describeEnvironmentsRequest != null && describeEnvironmentsRequest.IsSetIncludeDeleted())
            {
                request.Parameters.Add("IncludeDeleted", StringUtils.FromBool(describeEnvironmentsRequest.IncludeDeleted));
            }
            if (describeEnvironmentsRequest != null && describeEnvironmentsRequest.IsSetIncludedDeletedBackTo())
            {
                request.Parameters.Add("IncludedDeletedBackTo", StringUtils.FromDateTime(describeEnvironmentsRequest.IncludedDeletedBackTo));
            }

            return request;
        }
    }
}
