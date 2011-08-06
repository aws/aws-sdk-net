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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Transform
{
    /// <summary>
    /// Describe Launch Configurations Request Marshaller
    /// </summary>       
    public class DescribeLaunchConfigurationsRequestMarshaller : IMarshaller<IRequest<DescribeLaunchConfigurationsRequest>, DescribeLaunchConfigurationsRequest> 
    {

        public IRequest<DescribeLaunchConfigurationsRequest> Marshall(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest) 
        {
            IRequest<DescribeLaunchConfigurationsRequest> request = new DefaultRequest<DescribeLaunchConfigurationsRequest>(describeLaunchConfigurationsRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DescribeLaunchConfigurations");
            request.Parameters.Add("Version", "2011-01-01");
            if (describeLaunchConfigurationsRequest != null) 
            {
                List<string> launchConfigurationNamesList = describeLaunchConfigurationsRequest.LaunchConfigurationNames;

                int launchConfigurationNamesListIndex = 1;
                foreach (string launchConfigurationNamesListValue in launchConfigurationNamesList) 
                { 
                    request.Parameters.Add("LaunchConfigurationNames.member." + launchConfigurationNamesListIndex, StringUtils.FromString(launchConfigurationNamesListValue));
                    launchConfigurationNamesListIndex++;
                }
            }
            if (describeLaunchConfigurationsRequest != null && describeLaunchConfigurationsRequest.IsSetNextToken()) 
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeLaunchConfigurationsRequest.NextToken));
            }
            if (describeLaunchConfigurationsRequest != null && describeLaunchConfigurationsRequest.IsSetMaxRecords()) 
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeLaunchConfigurationsRequest.MaxRecords));
            }


            return request;
        }
    }
}
