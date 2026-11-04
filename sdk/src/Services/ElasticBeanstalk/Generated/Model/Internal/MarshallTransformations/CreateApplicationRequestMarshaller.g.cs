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
    /// CreateApplication Request Marshaller
    /// </summary>
    public partial class CreateApplicationRequestMarshaller : IMarshaller<IRequest, CreateApplicationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateApplication");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetResourceLifecycleConfig())
            {
                if (publicRequest.ResourceLifecycleConfig.IsSetServiceRole())
                {
                    request.Parameters.Add("ResourceLifecycleConfig" + ".ServiceRole", StringUtils.FromString(publicRequest.ResourceLifecycleConfig.ServiceRole));
                }
                if (publicRequest.ResourceLifecycleConfig.IsSetVersionLifecycleConfig())
                {
                    if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.IsSetMaxAgeRule())
                    {
                        if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.IsSetDeleteSourceFromS3())
                        {
                            request.Parameters.Add("ResourceLifecycleConfig" + ".VersionLifecycleConfig" + ".MaxAgeRule" + ".DeleteSourceFromS3", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.DeleteSourceFromS3.Value));
                        }
                        if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.IsSetEnabled())
                        {
                            request.Parameters.Add("ResourceLifecycleConfig" + ".VersionLifecycleConfig" + ".MaxAgeRule" + ".Enabled", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.Enabled.Value));
                        }
                        if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.IsSetMaxAgeInDays())
                        {
                            request.Parameters.Add("ResourceLifecycleConfig" + ".VersionLifecycleConfig" + ".MaxAgeRule" + ".MaxAgeInDays", StringUtils.FromInt(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.MaxAgeInDays.Value));
                        }
                    }
                    if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.IsSetMaxCountRule())
                    {
                        if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.IsSetDeleteSourceFromS3())
                        {
                            request.Parameters.Add("ResourceLifecycleConfig" + ".VersionLifecycleConfig" + ".MaxCountRule" + ".DeleteSourceFromS3", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.DeleteSourceFromS3.Value));
                        }
                        if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.IsSetEnabled())
                        {
                            request.Parameters.Add("ResourceLifecycleConfig" + ".VersionLifecycleConfig" + ".MaxCountRule" + ".Enabled", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.Enabled.Value));
                        }
                        if (publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.IsSetMaxCount())
                        {
                            request.Parameters.Add("ResourceLifecycleConfig" + ".VersionLifecycleConfig" + ".MaxCountRule" + ".MaxCount", StringUtils.FromInt(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.MaxCount.Value));
                        }
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

        private static readonly CreateApplicationRequestMarshaller _instance = new();

        internal static CreateApplicationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateApplicationRequestMarshaller Instance => _instance;
    }
}
