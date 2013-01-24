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
    /// Describe Configuration Options Request Marshaller
    /// </summary>       
    public class DescribeConfigurationOptionsRequestMarshaller : IMarshaller<IRequest, DescribeConfigurationOptionsRequest>
    {
        public IRequest Marshall(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest)
        {
            IRequest request = new DefaultRequest(describeConfigurationOptionsRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "DescribeConfigurationOptions");
            request.Parameters.Add("Version", "2010-12-01");
            if (describeConfigurationOptionsRequest != null && describeConfigurationOptionsRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(describeConfigurationOptionsRequest.ApplicationName));
            }
            if (describeConfigurationOptionsRequest != null && describeConfigurationOptionsRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(describeConfigurationOptionsRequest.TemplateName));
            }
            if (describeConfigurationOptionsRequest != null && describeConfigurationOptionsRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(describeConfigurationOptionsRequest.EnvironmentName));
            }
            if (describeConfigurationOptionsRequest != null && describeConfigurationOptionsRequest.IsSetSolutionStackName())
            {
                request.Parameters.Add("SolutionStackName", StringUtils.FromString(describeConfigurationOptionsRequest.SolutionStackName));
            }

            if (describeConfigurationOptionsRequest != null)
            {
                List<OptionSpecification> optionsList = describeConfigurationOptionsRequest.Options;
                int optionsListIndex = 1;
                foreach (OptionSpecification optionsListValue in optionsList)
                {
                    if (optionsListValue != null && optionsListValue.IsSetNamespace())
                    {
                        request.Parameters.Add("Options.member." + optionsListIndex + ".Namespace", StringUtils.FromString(optionsListValue.Namespace));
                    }
                    if (optionsListValue != null && optionsListValue.IsSetOptionName())
                    {
                        request.Parameters.Add("Options.member." + optionsListIndex + ".OptionName", StringUtils.FromString(optionsListValue.OptionName));
                    }

                    optionsListIndex++;
                }
            }

            return request;
        }
    }
}
