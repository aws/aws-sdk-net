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
    /// ProvisionByoipCidr Request Marshaller
    /// </summary>
    public partial class ProvisionByoipCidrRequestMarshaller : IMarshaller<IRequest, ProvisionByoipCidrRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ProvisionByoipCidrRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ProvisionByoipCidrRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ProvisionByoipCidr");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCidr())
            {
                request.Parameters.Add("Cidr", StringUtils.FromString(publicRequest.Cidr));
            }
            if (publicRequest.IsSetCidrAuthorizationContext())
            {
                if (publicRequest.CidrAuthorizationContext.IsSetMessage())
                {
                    request.Parameters.Add("CidrAuthorizationContext" + ".Message", StringUtils.FromString(publicRequest.CidrAuthorizationContext.Message));
                }
                if (publicRequest.CidrAuthorizationContext.IsSetSignature())
                {
                    request.Parameters.Add("CidrAuthorizationContext" + ".Signature", StringUtils.FromString(publicRequest.CidrAuthorizationContext.Signature));
                }
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetMultiRegion())
            {
                request.Parameters.Add("MultiRegion", StringUtils.FromBool(publicRequest.MultiRegion.Value));
            }
            if (publicRequest.IsSetNetworkBorderGroup())
            {
                request.Parameters.Add("NetworkBorderGroup", StringUtils.FromString(publicRequest.NetworkBorderGroup));
            }
            if (publicRequest.IsSetPoolTagSpecifications())
            {
                if (publicRequest.PoolTagSpecifications.Count == 0)
                {
                    request.Parameters.Add("PoolTagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PoolTagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("PoolTagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("PoolTagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("PoolTagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("PoolTagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPubliclyAdvertisable())
            {
                request.Parameters.Add("PubliclyAdvertisable", StringUtils.FromBool(publicRequest.PubliclyAdvertisable.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ProvisionByoipCidrRequestMarshaller _instance = new();

        internal static ProvisionByoipCidrRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProvisionByoipCidrRequestMarshaller Instance => _instance;
    }
}
