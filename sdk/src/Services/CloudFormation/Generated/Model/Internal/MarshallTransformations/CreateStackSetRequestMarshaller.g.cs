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
    /// CreateStackSet Request Marshaller
    /// </summary>
    public partial class CreateStackSetRequestMarshaller : IMarshaller<IRequest, CreateStackSetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStackSetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateStackSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateStackSet");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetAdministrationRoleARN())
            {
                request.Parameters.Add("AdministrationRoleARN", StringUtils.FromString(publicRequest.AdministrationRoleARN));
            }
            if (publicRequest.IsSetAutoDeployment())
            {
                if (publicRequest.AutoDeployment.IsSetDependsOn())
                {
                    if (publicRequest.AutoDeployment.DependsOn.Count == 0)
                    {
                        request.Parameters.Add("AutoDeployment" + ".DependsOn", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.AutoDeployment.DependsOn)
                        {
                            request.Parameters.Add("AutoDeployment" + ".DependsOn" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.AutoDeployment.IsSetEnabled())
                {
                    request.Parameters.Add("AutoDeployment" + ".Enabled", StringUtils.FromBool(publicRequest.AutoDeployment.Enabled.Value));
                }
                if (publicRequest.AutoDeployment.IsSetRetainStacksOnAccountRemoval())
                {
                    request.Parameters.Add("AutoDeployment" + ".RetainStacksOnAccountRemoval", StringUtils.FromBool(publicRequest.AutoDeployment.RetainStacksOnAccountRemoval.Value));
                }
            }
            if (publicRequest.IsSetCallAs())
            {
                request.Parameters.Add("CallAs", StringUtils.FromString(publicRequest.CallAs));
            }
            if (publicRequest.IsSetCapabilities())
            {
                if (publicRequest.Capabilities.Count == 0)
                {
                    request.Parameters.Add("Capabilities", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Capabilities)
                    {
                        request.Parameters.Add("Capabilities" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetClientRequestToken())
            {
                request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
            }
            else
            {
                request.Parameters.Add("ClientRequestToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetExecutionRoleName())
            {
                request.Parameters.Add("ExecutionRoleName", StringUtils.FromString(publicRequest.ExecutionRoleName));
            }
            if (publicRequest.IsSetManagedExecution())
            {
                if (publicRequest.ManagedExecution.IsSetActive())
                {
                    request.Parameters.Add("ManagedExecution" + ".Active", StringUtils.FromBool(publicRequest.ManagedExecution.Active.Value));
                }
            }
            if (publicRequest.IsSetParameters())
            {
                if (publicRequest.Parameters.Count == 0)
                {
                    request.Parameters.Add("Parameters", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Parameters)
                    {
                        if (item0.IsSetParameterKey())
                        {
                            request.Parameters.Add("Parameters" + ".member" + "." + index0 + ".ParameterKey", StringUtils.FromString(item0.ParameterKey));
                        }
                        if (item0.IsSetParameterValue())
                        {
                            request.Parameters.Add("Parameters" + ".member" + "." + index0 + ".ParameterValue", StringUtils.FromString(item0.ParameterValue));
                        }
                        if (item0.IsSetResolvedValue())
                        {
                            request.Parameters.Add("Parameters" + ".member" + "." + index0 + ".ResolvedValue", StringUtils.FromString(item0.ResolvedValue));
                        }
                        if (item0.IsSetUsePreviousValue())
                        {
                            request.Parameters.Add("Parameters" + ".member" + "." + index0 + ".UsePreviousValue", StringUtils.FromBool(item0.UsePreviousValue.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPermissionModel())
            {
                request.Parameters.Add("PermissionModel", StringUtils.FromString(publicRequest.PermissionModel));
            }
            if (publicRequest.IsSetStackId())
            {
                request.Parameters.Add("StackId", StringUtils.FromString(publicRequest.StackId));
            }
            if (publicRequest.IsSetStackSetName())
            {
                request.Parameters.Add("StackSetName", StringUtils.FromString(publicRequest.StackSetName));
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
            if (publicRequest.IsSetTemplateBody())
            {
                request.Parameters.Add("TemplateBody", StringUtils.FromString(publicRequest.TemplateBody));
            }
            if (publicRequest.IsSetTemplateURL())
            {
                request.Parameters.Add("TemplateURL", StringUtils.FromString(publicRequest.TemplateURL));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateStackSetRequestMarshaller _instance = new();

        internal static CreateStackSetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateStackSetRequestMarshaller Instance => _instance;
    }
}
