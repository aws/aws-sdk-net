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
    /// CreateStackRefactor Request Marshaller
    /// </summary>
    public partial class CreateStackRefactorRequestMarshaller : IMarshaller<IRequest, CreateStackRefactorRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStackRefactorRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateStackRefactorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateStackRefactor");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetEnableStackCreation())
            {
                request.Parameters.Add("EnableStackCreation", StringUtils.FromBool(publicRequest.EnableStackCreation.Value));
            }
            if (publicRequest.IsSetResourceMappings())
            {
                if (publicRequest.ResourceMappings.Count == 0)
                {
                    request.Parameters.Add("ResourceMappings", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ResourceMappings)
                    {
                        if (item0.IsSetDestination())
                        {
                            if (item0.Destination.IsSetLogicalResourceId())
                            {
                                request.Parameters.Add("ResourceMappings" + ".member" + "." + index0 + ".Destination" + ".LogicalResourceId", StringUtils.FromString(item0.Destination.LogicalResourceId));
                            }
                            if (item0.Destination.IsSetStackName())
                            {
                                request.Parameters.Add("ResourceMappings" + ".member" + "." + index0 + ".Destination" + ".StackName", StringUtils.FromString(item0.Destination.StackName));
                            }
                        }
                        if (item0.IsSetSource())
                        {
                            if (item0.Source.IsSetLogicalResourceId())
                            {
                                request.Parameters.Add("ResourceMappings" + ".member" + "." + index0 + ".Source" + ".LogicalResourceId", StringUtils.FromString(item0.Source.LogicalResourceId));
                            }
                            if (item0.Source.IsSetStackName())
                            {
                                request.Parameters.Add("ResourceMappings" + ".member" + "." + index0 + ".Source" + ".StackName", StringUtils.FromString(item0.Source.StackName));
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetStackDefinitions())
            {
                if (publicRequest.StackDefinitions.Count == 0)
                {
                    request.Parameters.Add("StackDefinitions", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.StackDefinitions)
                    {
                        if (item0.IsSetStackName())
                        {
                            request.Parameters.Add("StackDefinitions" + ".member" + "." + index0 + ".StackName", StringUtils.FromString(item0.StackName));
                        }
                        if (item0.IsSetTemplateBody())
                        {
                            request.Parameters.Add("StackDefinitions" + ".member" + "." + index0 + ".TemplateBody", StringUtils.FromString(item0.TemplateBody));
                        }
                        if (item0.IsSetTemplateURL())
                        {
                            request.Parameters.Add("StackDefinitions" + ".member" + "." + index0 + ".TemplateURL", StringUtils.FromString(item0.TemplateURL));
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

        private static readonly CreateStackRefactorRequestMarshaller _instance = new();

        internal static CreateStackRefactorRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateStackRefactorRequestMarshaller Instance => _instance;
    }
}
