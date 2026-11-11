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
    /// CreateEnvironment Request Marshaller
    /// </summary>
    public partial class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateEnvironment");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
            }
            if (publicRequest.IsSetCNAMEPrefix())
            {
                request.Parameters.Add("CNAMEPrefix", StringUtils.FromString(publicRequest.CNAMEPrefix));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
            }
            if (publicRequest.IsSetGroupName())
            {
                request.Parameters.Add("GroupName", StringUtils.FromString(publicRequest.GroupName));
            }
            if (publicRequest.IsSetOperationsRole())
            {
                request.Parameters.Add("OperationsRole", StringUtils.FromString(publicRequest.OperationsRole));
            }
            if (publicRequest.IsSetOptionSettings())
            {
                if (publicRequest.OptionSettings.Count == 0)
                {
                    request.Parameters.Add("OptionSettings", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.OptionSettings)
                    {
                        if (item0.IsSetNamespace())
                        {
                            request.Parameters.Add("OptionSettings" + ".member" + "." + index0 + ".Namespace", StringUtils.FromString(item0.Namespace));
                        }
                        if (item0.IsSetOptionName())
                        {
                            request.Parameters.Add("OptionSettings" + ".member" + "." + index0 + ".OptionName", StringUtils.FromString(item0.OptionName));
                        }
                        if (item0.IsSetResourceName())
                        {
                            request.Parameters.Add("OptionSettings" + ".member" + "." + index0 + ".ResourceName", StringUtils.FromString(item0.ResourceName));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("OptionSettings" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOptionsToRemove())
            {
                if (publicRequest.OptionsToRemove.Count == 0)
                {
                    request.Parameters.Add("OptionsToRemove", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.OptionsToRemove)
                    {
                        if (item0.IsSetNamespace())
                        {
                            request.Parameters.Add("OptionsToRemove" + ".member" + "." + index0 + ".Namespace", StringUtils.FromString(item0.Namespace));
                        }
                        if (item0.IsSetOptionName())
                        {
                            request.Parameters.Add("OptionsToRemove" + ".member" + "." + index0 + ".OptionName", StringUtils.FromString(item0.OptionName));
                        }
                        if (item0.IsSetResourceName())
                        {
                            request.Parameters.Add("OptionsToRemove" + ".member" + "." + index0 + ".ResourceName", StringUtils.FromString(item0.ResourceName));
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
            if (publicRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(publicRequest.TemplateName));
            }
            if (publicRequest.IsSetTier())
            {
                if (publicRequest.Tier.IsSetName())
                {
                    request.Parameters.Add("Tier" + ".Name", StringUtils.FromString(publicRequest.Tier.Name));
                }
                if (publicRequest.Tier.IsSetType())
                {
                    request.Parameters.Add("Tier" + ".Type", StringUtils.FromString(publicRequest.Tier.Type));
                }
                if (publicRequest.Tier.IsSetVersion())
                {
                    request.Parameters.Add("Tier" + ".Version", StringUtils.FromString(publicRequest.Tier.Version));
                }
            }
            if (publicRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(publicRequest.VersionLabel));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateEnvironmentRequestMarshaller _instance = new();

        internal static CreateEnvironmentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateEnvironmentRequestMarshaller Instance => _instance;
    }
}
