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

using Amazon.ElasticLoadBalancing.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfigureHealthCheck Request Marshaller
    /// </summary>
    public partial class ConfigureHealthCheckRequestMarshaller : IMarshaller<IRequest, ConfigureHealthCheckRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ConfigureHealthCheckRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ConfigureHealthCheckRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ConfigureHealthCheck");
            request.Parameters.Add("Version", "2012-06-01");

            if (publicRequest.IsSetHealthCheck())
            {
                if (publicRequest.HealthCheck.IsSetHealthyThreshold())
                {
                    request.Parameters.Add("HealthCheck" + ".HealthyThreshold", StringUtils.FromInt(publicRequest.HealthCheck.HealthyThreshold.Value));
                }
                if (publicRequest.HealthCheck.IsSetInterval())
                {
                    request.Parameters.Add("HealthCheck" + ".Interval", StringUtils.FromInt(publicRequest.HealthCheck.Interval.Value));
                }
                if (publicRequest.HealthCheck.IsSetTarget())
                {
                    request.Parameters.Add("HealthCheck" + ".Target", StringUtils.FromString(publicRequest.HealthCheck.Target));
                }
                if (publicRequest.HealthCheck.IsSetTimeout())
                {
                    request.Parameters.Add("HealthCheck" + ".Timeout", StringUtils.FromInt(publicRequest.HealthCheck.Timeout.Value));
                }
                if (publicRequest.HealthCheck.IsSetUnhealthyThreshold())
                {
                    request.Parameters.Add("HealthCheck" + ".UnhealthyThreshold", StringUtils.FromInt(publicRequest.HealthCheck.UnhealthyThreshold.Value));
                }
            }
            if (publicRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ConfigureHealthCheckRequestMarshaller _instance = new();

        internal static ConfigureHealthCheckRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ConfigureHealthCheckRequestMarshaller Instance => _instance;
    }
}
