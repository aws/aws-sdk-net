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
    /// CreateLoadBalancer Request Marshaller
    /// </summary>
    public partial class CreateLoadBalancerRequestMarshaller : IMarshaller<IRequest, CreateLoadBalancerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLoadBalancerRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLoadBalancerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateLoadBalancer");
            request.Parameters.Add("Version", "2012-06-01");

            if (publicRequest.IsSetAvailabilityZones())
            {
                if (publicRequest.AvailabilityZones.Count == 0)
                {
                    request.Parameters.Add("AvailabilityZones", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AvailabilityZones)
                    {
                        request.Parameters.Add("AvailabilityZones" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetListeners())
            {
                if (publicRequest.Listeners.Count == 0)
                {
                    request.Parameters.Add("Listeners", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Listeners)
                    {
                        if (item0.IsSetInstancePort())
                        {
                            request.Parameters.Add("Listeners" + ".member" + "." + index0 + ".InstancePort", StringUtils.FromInt(item0.InstancePort.Value));
                        }
                        if (item0.IsSetInstanceProtocol())
                        {
                            request.Parameters.Add("Listeners" + ".member" + "." + index0 + ".InstanceProtocol", StringUtils.FromString(item0.InstanceProtocol));
                        }
                        if (item0.IsSetLoadBalancerPort())
                        {
                            request.Parameters.Add("Listeners" + ".member" + "." + index0 + ".LoadBalancerPort", StringUtils.FromInt(item0.LoadBalancerPort.Value));
                        }
                        if (item0.IsSetProtocol())
                        {
                            request.Parameters.Add("Listeners" + ".member" + "." + index0 + ".Protocol", StringUtils.FromString(item0.Protocol));
                        }
                        if (item0.IsSetSSLCertificateId())
                        {
                            request.Parameters.Add("Listeners" + ".member" + "." + index0 + ".SSLCertificateId", StringUtils.FromString(item0.SSLCertificateId));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
            }
            if (publicRequest.IsSetScheme())
            {
                request.Parameters.Add("Scheme", StringUtils.FromString(publicRequest.Scheme));
            }
            if (publicRequest.IsSetSecurityGroups())
            {
                if (publicRequest.SecurityGroups.Count == 0)
                {
                    request.Parameters.Add("SecurityGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroups)
                    {
                        request.Parameters.Add("SecurityGroups" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSubnets())
            {
                if (publicRequest.Subnets.Count == 0)
                {
                    request.Parameters.Add("Subnets", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Subnets)
                    {
                        request.Parameters.Add("Subnets" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateLoadBalancerRequestMarshaller _instance = new();

        internal static CreateLoadBalancerRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLoadBalancerRequestMarshaller Instance => _instance;
    }
}
