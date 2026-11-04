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

using Amazon.CloudFormation.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGeneratedTemplate Request Marshaller
    /// </summary>
    public partial class CreateGeneratedTemplateRequestMarshaller : IMarshaller<IRequest, CreateGeneratedTemplateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGeneratedTemplateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateGeneratedTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateGeneratedTemplate");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetGeneratedTemplateName())
            {
                request.Parameters.Add("GeneratedTemplateName", StringUtils.FromString(publicRequest.GeneratedTemplateName));
            }
            if (publicRequest.IsSetResources())
            {
                if (publicRequest.Resources.Count == 0)
                {
                    request.Parameters.Add("Resources", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Resources)
                    {
                        if (item0.IsSetLogicalResourceId())
                        {
                            request.Parameters.Add("Resources" + ".member" + "." + index0 + ".LogicalResourceId", StringUtils.FromString(item0.LogicalResourceId));
                        }
                        if (item0.IsSetResourceIdentifier())
                        {
                            int index1 = 1;
                            foreach (var kvp1 in item0.ResourceIdentifier)
                            {
                                request.Parameters.Add("Resources" + ".member" + "." + index0 + ".ResourceIdentifier" + ".entry" + "." + index1 + ".key", StringUtils.FromString(kvp1.Key));
                                request.Parameters.Add("Resources" + ".member" + "." + index0 + ".ResourceIdentifier" + ".entry" + "." + index1 + ".value", StringUtils.FromString(kvp1.Value));
                                index1++;
                            }
                        }
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("Resources" + ".member" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
            }
            if (publicRequest.IsSetTemplateConfiguration())
            {
                if (publicRequest.TemplateConfiguration.IsSetDeletionPolicy())
                {
                    request.Parameters.Add("TemplateConfiguration" + ".DeletionPolicy", StringUtils.FromString(publicRequest.TemplateConfiguration.DeletionPolicy));
                }
                if (publicRequest.TemplateConfiguration.IsSetUpdateReplacePolicy())
                {
                    request.Parameters.Add("TemplateConfiguration" + ".UpdateReplacePolicy", StringUtils.FromString(publicRequest.TemplateConfiguration.UpdateReplacePolicy));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateGeneratedTemplateRequestMarshaller _instance = new();

        internal static CreateGeneratedTemplateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateGeneratedTemplateRequestMarshaller Instance => _instance;
    }
}
