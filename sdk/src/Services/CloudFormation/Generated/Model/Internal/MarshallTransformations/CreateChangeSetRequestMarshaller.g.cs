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
    /// CreateChangeSet Request Marshaller
    /// </summary>
    public partial class CreateChangeSetRequestMarshaller : IMarshaller<IRequest, CreateChangeSetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateChangeSetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateChangeSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateChangeSet");
            request.Parameters.Add("Version", "2010-05-15");

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
            if (publicRequest.IsSetChangeSetName())
            {
                request.Parameters.Add("ChangeSetName", StringUtils.FromString(publicRequest.ChangeSetName));
            }
            if (publicRequest.IsSetChangeSetType())
            {
                request.Parameters.Add("ChangeSetType", StringUtils.FromString(publicRequest.ChangeSetType));
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetDeploymentConfig())
            {
                if (publicRequest.DeploymentConfig.IsSetDisableRollback())
                {
                    request.Parameters.Add("DeploymentConfig" + ".DisableRollback", StringUtils.FromBool(publicRequest.DeploymentConfig.DisableRollback.Value));
                }
                if (publicRequest.DeploymentConfig.IsSetMode())
                {
                    request.Parameters.Add("DeploymentConfig" + ".Mode", StringUtils.FromString(publicRequest.DeploymentConfig.Mode));
                }
            }
            if (publicRequest.IsSetDeploymentMode())
            {
                request.Parameters.Add("DeploymentMode", StringUtils.FromString(publicRequest.DeploymentMode));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDisableValidation())
            {
                request.Parameters.Add("DisableValidation", StringUtils.FromBool(publicRequest.DisableValidation.Value));
            }
            if (publicRequest.IsSetImportExistingResources())
            {
                request.Parameters.Add("ImportExistingResources", StringUtils.FromBool(publicRequest.ImportExistingResources.Value));
            }
            if (publicRequest.IsSetIncludeNestedStacks())
            {
                request.Parameters.Add("IncludeNestedStacks", StringUtils.FromBool(publicRequest.IncludeNestedStacks.Value));
            }
            if (publicRequest.IsSetNotificationARNs())
            {
                if (publicRequest.NotificationARNs.Count == 0)
                {
                    request.Parameters.Add("NotificationARNs", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.NotificationARNs)
                    {
                        request.Parameters.Add("NotificationARNs" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOnStackFailure())
            {
                request.Parameters.Add("OnStackFailure", StringUtils.FromString(publicRequest.OnStackFailure));
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
            if (publicRequest.IsSetResourceTypes())
            {
                if (publicRequest.ResourceTypes.Count == 0)
                {
                    request.Parameters.Add("ResourceTypes", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ResourceTypes)
                    {
                        request.Parameters.Add("ResourceTypes" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetResourcesToImport())
            {
                if (publicRequest.ResourcesToImport.Count == 0)
                {
                    request.Parameters.Add("ResourcesToImport", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ResourcesToImport)
                    {
                        if (item0.IsSetLogicalResourceId())
                        {
                            request.Parameters.Add("ResourcesToImport" + ".member" + "." + index0 + ".LogicalResourceId", StringUtils.FromString(item0.LogicalResourceId));
                        }
                        if (item0.IsSetResourceIdentifier())
                        {
                            int index1 = 1;
                            foreach (var kvp1 in item0.ResourceIdentifier)
                            {
                                request.Parameters.Add("ResourcesToImport" + ".member" + "." + index0 + ".ResourceIdentifier" + ".entry" + "." + index1 + ".key", StringUtils.FromString(kvp1.Key));
                                request.Parameters.Add("ResourcesToImport" + ".member" + "." + index0 + ".ResourceIdentifier" + ".entry" + "." + index1 + ".value", StringUtils.FromString(kvp1.Value));
                                index1++;
                            }
                        }
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("ResourcesToImport" + ".member" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetRoleARN())
            {
                request.Parameters.Add("RoleARN", StringUtils.FromString(publicRequest.RoleARN));
            }
            if (publicRequest.IsSetRollbackConfiguration())
            {
                if (publicRequest.RollbackConfiguration.IsSetMonitoringTimeInMinutes())
                {
                    request.Parameters.Add("RollbackConfiguration" + ".MonitoringTimeInMinutes", StringUtils.FromInt(publicRequest.RollbackConfiguration.MonitoringTimeInMinutes.Value));
                }
                if (publicRequest.RollbackConfiguration.IsSetRollbackTriggers())
                {
                    if (publicRequest.RollbackConfiguration.RollbackTriggers.Count == 0)
                    {
                        request.Parameters.Add("RollbackConfiguration" + ".RollbackTriggers", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.RollbackConfiguration.RollbackTriggers)
                        {
                            if (item1.IsSetArn())
                            {
                                request.Parameters.Add("RollbackConfiguration" + ".RollbackTriggers" + ".member" + "." + index1 + ".Arn", StringUtils.FromString(item1.Arn));
                            }
                            if (item1.IsSetType())
                            {
                                request.Parameters.Add("RollbackConfiguration" + ".RollbackTriggers" + ".member" + "." + index1 + ".Type", StringUtils.FromString(item1.Type));
                            }
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
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
            if (publicRequest.IsSetUsePreviousTemplate())
            {
                request.Parameters.Add("UsePreviousTemplate", StringUtils.FromBool(publicRequest.UsePreviousTemplate.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateChangeSetRequestMarshaller _instance = new();

        internal static CreateChangeSetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateChangeSetRequestMarshaller Instance => _instance;
    }
}
