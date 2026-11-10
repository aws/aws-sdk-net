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
    /// CreateIpamPool Request Marshaller
    /// </summary>
    public partial class CreateIpamPoolRequestMarshaller : IMarshaller<IRequest, CreateIpamPoolRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIpamPoolRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateIpamPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateIpamPool");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAddressFamily())
            {
                request.Parameters.Add("AddressFamily", StringUtils.FromString(publicRequest.AddressFamily));
            }
            if (publicRequest.IsSetAllocationDefaultNetmaskLength())
            {
                request.Parameters.Add("AllocationDefaultNetmaskLength", StringUtils.FromInt(publicRequest.AllocationDefaultNetmaskLength.Value));
            }
            if (publicRequest.IsSetAllocationMaxNetmaskLength())
            {
                request.Parameters.Add("AllocationMaxNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMaxNetmaskLength.Value));
            }
            if (publicRequest.IsSetAllocationMinNetmaskLength())
            {
                request.Parameters.Add("AllocationMinNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMinNetmaskLength.Value));
            }
            if (publicRequest.IsSetAllocationResourceTags())
            {
                if (publicRequest.AllocationResourceTags.Count == 0)
                {
                    request.Parameters.Add("AllocationResourceTag", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AllocationResourceTags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("AllocationResourceTag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("AllocationResourceTag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAutoImport())
            {
                request.Parameters.Add("AutoImport", StringUtils.FromBool(publicRequest.AutoImport.Value));
            }
            if (publicRequest.IsSetAwsService())
            {
                request.Parameters.Add("AwsService", StringUtils.FromString(publicRequest.AwsService));
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetIpamScopeId())
            {
                request.Parameters.Add("IpamScopeId", StringUtils.FromString(publicRequest.IpamScopeId));
            }
            if (publicRequest.IsSetLocale())
            {
                request.Parameters.Add("Locale", StringUtils.FromString(publicRequest.Locale));
            }
            if (publicRequest.IsSetPublicIpSource())
            {
                request.Parameters.Add("PublicIpSource", StringUtils.FromString(publicRequest.PublicIpSource));
            }
            if (publicRequest.IsSetPubliclyAdvertisable())
            {
                request.Parameters.Add("PubliclyAdvertisable", StringUtils.FromBool(publicRequest.PubliclyAdvertisable.Value));
            }
            if (publicRequest.IsSetSourceIpamPoolId())
            {
                request.Parameters.Add("SourceIpamPoolId", StringUtils.FromString(publicRequest.SourceIpamPoolId));
            }
            if (publicRequest.IsSetSourceResource())
            {
                if (publicRequest.SourceResource.IsSetResourceId())
                {
                    request.Parameters.Add("SourceResource" + ".ResourceId", StringUtils.FromString(publicRequest.SourceResource.ResourceId));
                }
                if (publicRequest.SourceResource.IsSetResourceOwner())
                {
                    request.Parameters.Add("SourceResource" + ".ResourceOwner", StringUtils.FromString(publicRequest.SourceResource.ResourceOwner));
                }
                if (publicRequest.SourceResource.IsSetResourceRegion())
                {
                    request.Parameters.Add("SourceResource" + ".ResourceRegion", StringUtils.FromString(publicRequest.SourceResource.ResourceRegion));
                }
                if (publicRequest.SourceResource.IsSetResourceType())
                {
                    request.Parameters.Add("SourceResource" + ".ResourceType", StringUtils.FromString(publicRequest.SourceResource.ResourceType));
                }
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

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateIpamPoolRequestMarshaller _instance = new();

        internal static CreateIpamPoolRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateIpamPoolRequestMarshaller Instance => _instance;
    }
}
