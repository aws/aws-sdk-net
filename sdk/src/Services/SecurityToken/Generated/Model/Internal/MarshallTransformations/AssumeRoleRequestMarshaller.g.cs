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

using Amazon.SecurityToken.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssumeRole Request Marshaller
    /// </summary>
    public partial class AssumeRoleRequestMarshaller : IMarshaller<IRequest, AssumeRoleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssumeRoleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssumeRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityToken");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AssumeRole");
            request.Parameters.Add("Version", "2011-06-15");

            if (publicRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds.Value));
            }
            if (publicRequest.IsSetExternalId())
            {
                request.Parameters.Add("ExternalId", StringUtils.FromString(publicRequest.ExternalId));
            }
            if (publicRequest.IsSetMinimumSessionTokenSize())
            {
                request.Parameters.Add("MinimumSessionTokenSize", StringUtils.FromInt(publicRequest.MinimumSessionTokenSize.Value));
            }
            if (publicRequest.IsSetPolicy())
            {
                request.Parameters.Add("Policy", StringUtils.FromString(publicRequest.Policy));
            }
            if (publicRequest.IsSetPolicyArns())
            {
                if (publicRequest.PolicyArns.Count == 0)
                {
                    request.Parameters.Add("PolicyArns", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PolicyArns)
                    {
                        if (item0.IsSetArn())
                        {
                            request.Parameters.Add("PolicyArns" + ".member" + "." + index0 + ".arn", StringUtils.FromString(item0.Arn));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetProvidedContexts())
            {
                if (publicRequest.ProvidedContexts.Count == 0)
                {
                    request.Parameters.Add("ProvidedContexts", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ProvidedContexts)
                    {
                        if (item0.IsSetContextAssertion())
                        {
                            request.Parameters.Add("ProvidedContexts" + ".member" + "." + index0 + ".ContextAssertion", StringUtils.FromString(item0.ContextAssertion));
                        }
                        if (item0.IsSetProviderArn())
                        {
                            request.Parameters.Add("ProvidedContexts" + ".member" + "." + index0 + ".ProviderArn", StringUtils.FromString(item0.ProviderArn));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetRoleArn())
            {
                request.Parameters.Add("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
            }
            if (publicRequest.IsSetRoleSessionName())
            {
                request.Parameters.Add("RoleSessionName", StringUtils.FromString(publicRequest.RoleSessionName));
            }
            if (publicRequest.IsSetSerialNumber())
            {
                request.Parameters.Add("SerialNumber", StringUtils.FromString(publicRequest.SerialNumber));
            }
            if (publicRequest.IsSetSourceIdentity())
            {
                request.Parameters.Add("SourceIdentity", StringUtils.FromString(publicRequest.SourceIdentity));
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
            if (publicRequest.IsSetTokenCode())
            {
                request.Parameters.Add("TokenCode", StringUtils.FromString(publicRequest.TokenCode));
            }
            if (publicRequest.IsSetTransitiveTagKeys())
            {
                if (publicRequest.TransitiveTagKeys.Count == 0)
                {
                    request.Parameters.Add("TransitiveTagKeys", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TransitiveTagKeys)
                    {
                        request.Parameters.Add("TransitiveTagKeys" + ".member" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly AssumeRoleRequestMarshaller _instance = new();

        internal static AssumeRoleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssumeRoleRequestMarshaller Instance => _instance;
    }
}
