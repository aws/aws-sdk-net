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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCustomerGateway Request Marshaller
    /// </summary>
    public partial class CreateCustomerGatewayRequestMarshaller : IMarshaller<IRequest, CreateCustomerGatewayRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomerGatewayRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCustomerGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateCustomerGateway");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetBgpAsn())
            {
                request.Parameters.Add("BgpAsn", StringUtils.FromInt(publicRequest.BgpAsn.Value));
            }
            if (publicRequest.IsSetBgpAsnExtended())
            {
                request.Parameters.Add("BgpAsnExtended", StringUtils.FromLong(publicRequest.BgpAsnExtended.Value));
            }
            if (publicRequest.IsSetCertificateArn())
            {
                request.Parameters.Add("CertificateArn", StringUtils.FromString(publicRequest.CertificateArn));
            }
            if (publicRequest.IsSetDeviceName())
            {
                request.Parameters.Add("DeviceName", StringUtils.FromString(publicRequest.DeviceName));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetIpAddress())
            {
                request.Parameters.Add("IpAddress", StringUtils.FromString(publicRequest.IpAddress));
            }
            if (publicRequest.IsSetPublicIp())
            {
                request.Parameters.Add("PublicIp", StringUtils.FromString(publicRequest.PublicIp));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetType())
            {
                request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateCustomerGatewayRequestMarshaller _instance = new();

        internal static CreateCustomerGatewayRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCustomerGatewayRequestMarshaller Instance => _instance;
    }
}
