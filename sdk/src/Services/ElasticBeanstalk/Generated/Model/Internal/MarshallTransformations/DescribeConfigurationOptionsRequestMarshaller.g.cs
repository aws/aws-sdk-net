/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElasticBeanstalk.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeConfigurationOptions Request Marshaller
    /// </summary>
    public partial class DescribeConfigurationOptionsRequestMarshaller : IMarshaller<IRequest, DescribeConfigurationOptionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeConfigurationOptionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeConfigurationOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeConfigurationOptions");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
            }
            if (publicRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
            }
            if (publicRequest.IsSetOptions())
            {
                if (publicRequest.Options.Count == 0)
                {
                    request.Parameters.Add("Options", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Options)
                    {
                        if (item0.IsSetNamespace())
                        {
                            request.Parameters.Add("Options" + ".member" + "." + index0 + ".Namespace", StringUtils.FromString(item0.Namespace));
                        }
                        if (item0.IsSetOptionName())
                        {
                            request.Parameters.Add("Options" + ".member" + "." + index0 + ".OptionName", StringUtils.FromString(item0.OptionName));
                        }
                        if (item0.IsSetResourceName())
                        {
                            request.Parameters.Add("Options" + ".member" + "." + index0 + ".ResourceName", StringUtils.FromString(item0.ResourceName));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPlatformArn())
            {
                request.Parameters.Add("PlatformArn", StringUtils.FromString(publicRequest.PlatformArn));
            }
            if (publicRequest.IsSetSolutionStackName())
            {
                request.Parameters.Add("SolutionStackName", StringUtils.FromString(publicRequest.SolutionStackName));
            }
            if (publicRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(publicRequest.TemplateName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeConfigurationOptionsRequestMarshaller _instance = new();

        internal static DescribeConfigurationOptionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeConfigurationOptionsRequestMarshaller Instance => _instance;
    }
}
