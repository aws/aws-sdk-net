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
    /// DescribeImageReferences Request Marshaller
    /// </summary>
    public partial class DescribeImageReferencesRequestMarshaller : IMarshaller<IRequest, DescribeImageReferencesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeImageReferencesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeImageReferencesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeImageReferences");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetImageIds())
            {
                if (publicRequest.ImageIds.Count == 0)
                {
                    request.Parameters.Add("ImageId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ImageIds)
                    {
                        request.Parameters.Add("ImageId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIncludeAllResourceTypes())
            {
                request.Parameters.Add("IncludeAllResourceTypes", StringUtils.FromBool(publicRequest.IncludeAllResourceTypes.Value));
            }
            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetResourceTypes())
            {
                if (publicRequest.ResourceTypes.Count == 0)
                {
                    request.Parameters.Add("ResourceType", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ResourceTypes)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("ResourceType" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetResourceTypeOptions())
                        {
                            if (item0.ResourceTypeOptions.Count == 0)
                            {
                                request.Parameters.Add("ResourceType" + "." + index0 + ".ResourceTypeOption", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ResourceTypeOptions)
                                {
                                    if (item1.IsSetOptionName())
                                    {
                                        request.Parameters.Add("ResourceType" + "." + index0 + ".ResourceTypeOption" + "." + index1 + ".OptionName", StringUtils.FromString(item1.OptionName));
                                    }
                                    if (item1.IsSetOptionValues())
                                    {
                                        if (item1.OptionValues.Count == 0)
                                        {
                                            request.Parameters.Add("ResourceType" + "." + index0 + ".ResourceTypeOption" + "." + index1 + ".OptionValue", "");
                                        }
                                        else
                                        {
                                            int index2 = 1;
                                            foreach (var item2 in item1.OptionValues)
                                            {
                                                request.Parameters.Add("ResourceType" + "." + index0 + ".ResourceTypeOption" + "." + index1 + ".OptionValue" + "." + index2, StringUtils.FromString(item2));
                                                index2++;
                                            }
                                        }
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

        private static readonly DescribeImageReferencesRequestMarshaller _instance = new();

        internal static DescribeImageReferencesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeImageReferencesRequestMarshaller Instance => _instance;
    }
}
