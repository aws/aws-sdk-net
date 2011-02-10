/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticBeanstalk.Model.Transform
{
    /// <summary>
    /// Describe Applications Request Marshaller
    /// </summary>       
    public class DescribeApplicationsRequestMarshaller : IMarshaller<IRequest<DescribeApplicationsRequest>, DescribeApplicationsRequest> 
    {

        public IRequest<DescribeApplicationsRequest> Marshall(DescribeApplicationsRequest describeApplicationsRequest) 
        {
            IRequest<DescribeApplicationsRequest> request = new DefaultRequest<DescribeApplicationsRequest>(describeApplicationsRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "DescribeApplications");
            request.Parameters.Add("Version", "2010-12-01");
            if (describeApplicationsRequest != null) 
            {
                List<string> applicationNamesList = describeApplicationsRequest.ApplicationNames;
                int applicationNamesListIndex = 1;
                foreach (string applicationNamesListValue in applicationNamesList) 
                { 
                    request.Parameters.Add("ApplicationNames.member." + applicationNamesListIndex, StringUtils.FromString(applicationNamesListValue));
                    applicationNamesListIndex++;
                }
            }


            return request;
        }
    }
}
