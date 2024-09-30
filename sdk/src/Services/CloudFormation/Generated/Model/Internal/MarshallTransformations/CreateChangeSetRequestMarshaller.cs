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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateChangeSet Request Marshaller
    /// </summary>       
    public class CreateChangeSetRequestMarshaller : IMarshaller<IRequest, CreateChangeSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateChangeSetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateChangeSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "CreateChangeSet");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCapabilities())
                {
                    if (publicRequest.Capabilities.Count == 0)
                        request.Parameters.Add("Capabilities", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Capabilities)
                         {
                             request.Parameters.Add("Capabilities" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetChangeSetName())
                {
                    request.Parameters.Add("ChangeSetName", StringUtils.FromString(publicRequest.ChangeSetName));
                }
                if(publicRequest.IsSetChangeSetType())
                {
                    request.Parameters.Add("ChangeSetType", StringUtils.FromString(publicRequest.ChangeSetType));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetImportExistingResources())
                {
                    request.Parameters.Add("ImportExistingResources", StringUtils.FromBool(publicRequest.ImportExistingResources));
                }
                if(publicRequest.IsSetIncludeNestedStacks())
                {
                    request.Parameters.Add("IncludeNestedStacks", StringUtils.FromBool(publicRequest.IncludeNestedStacks));
                }
                if(publicRequest.IsSetNotificationARNs())
                {
                    if (publicRequest.NotificationARNs.Count == 0)
                        request.Parameters.Add("NotificationARNs", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NotificationARNs)
                         {
                             request.Parameters.Add("NotificationARNs" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetOnStackFailure())
                {
                    request.Parameters.Add("OnStackFailure", StringUtils.FromString(publicRequest.OnStackFailure));
                }
                if(publicRequest.IsSetParameters())
                {
                    if (publicRequest.Parameters.Count == 0)
                        request.Parameters.Add("Parameters", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Parameters)
                         {
                            if(publicRequestlistValue.IsSetParameterKey())
                            {
                                request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterKey", StringUtils.FromString(publicRequestlistValue.ParameterKey));
                            }
                            if(publicRequestlistValue.IsSetParameterValue())
                            {
                                request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterValue", StringUtils.FromString(publicRequestlistValue.ParameterValue));
                            }
                            if(publicRequestlistValue.IsSetResolvedValue())
                            {
                                request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResolvedValue", StringUtils.FromString(publicRequestlistValue.ResolvedValue));
                            }
                            if(publicRequestlistValue.IsSetUsePreviousValue())
                            {
                                request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "UsePreviousValue", StringUtils.FromBool(publicRequestlistValue.UsePreviousValue));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetResourcesToImport())
                {
                    if (publicRequest.ResourcesToImport.Count == 0)
                        request.Parameters.Add("ResourcesToImport", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ResourcesToImport)
                         {
                            if(publicRequestlistValue.IsSetLogicalResourceId())
                            {
                                request.Parameters.Add("ResourcesToImport" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LogicalResourceId", StringUtils.FromString(publicRequestlistValue.LogicalResourceId));
                            }
                            if(publicRequestlistValue.IsSetResourceIdentifier())
                            {
                                int mapIndex = 1;
                                foreach(var key in publicRequestlistValue.ResourceIdentifier.Keys)
                                {
                                    String value;
                                    bool hasValue = publicRequestlistValue.ResourceIdentifier.TryGetValue(key, out value);
                                    request.Parameters.Add("ResourcesToImport" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceIdentifier" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        request.Parameters.Add("ResourcesToImport" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceIdentifier" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                    }
                                    mapIndex++;
                                }
                            }
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("ResourcesToImport" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetResourceTypes())
                {
                    if (publicRequest.ResourceTypes.Count == 0)
                        request.Parameters.Add("ResourceTypes", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ResourceTypes)
                         {
                             request.Parameters.Add("ResourceTypes" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRoleARN())
                {
                    request.Parameters.Add("RoleARN", StringUtils.FromString(publicRequest.RoleARN));
                }
                if(publicRequest.IsSetRollbackConfiguration())
                {
                    if(publicRequest.RollbackConfiguration.IsSetMonitoringTimeInMinutes())
                    {
                        request.Parameters.Add("RollbackConfiguration" + "." + "MonitoringTimeInMinutes", StringUtils.FromInt(publicRequest.RollbackConfiguration.MonitoringTimeInMinutes));
                    }
                    if(publicRequest.RollbackConfiguration.IsSetRollbackTriggers())
                    {
                        if (publicRequest.RollbackConfiguration.RollbackTriggers.Count == 0)
                            request.Parameters.Add("RollbackConfiguration" + "." + "RollbackTriggers", "");
                        else
                        {
                             int publicRequestRollbackConfigurationlistValueIndex = 1;
                             foreach(var publicRequestRollbackConfigurationlistValue in publicRequest.RollbackConfiguration.RollbackTriggers)
                             {
                                if(publicRequestRollbackConfigurationlistValue.IsSetArn())
                                {
                                    request.Parameters.Add("RollbackConfiguration" + "." + "RollbackTriggers" + "." + "member" + "." + publicRequestRollbackConfigurationlistValueIndex + "." + "Arn", StringUtils.FromString(publicRequestRollbackConfigurationlistValue.Arn));
                                }
                                if(publicRequestRollbackConfigurationlistValue.IsSetType())
                                {
                                    request.Parameters.Add("RollbackConfiguration" + "." + "RollbackTriggers" + "." + "member" + "." + publicRequestRollbackConfigurationlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestRollbackConfigurationlistValue.Type));
                                }
                                 publicRequestRollbackConfigurationlistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetStackName())
                {
                    request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTemplateBody())
                {
                    request.Parameters.Add("TemplateBody", StringUtils.FromString(publicRequest.TemplateBody));
                }
                if(publicRequest.IsSetTemplateURL())
                {
                    request.Parameters.Add("TemplateURL", StringUtils.FromString(publicRequest.TemplateURL));
                }
                if(publicRequest.IsSetUsePreviousTemplate())
                {
                    request.Parameters.Add("UsePreviousTemplate", StringUtils.FromBool(publicRequest.UsePreviousTemplate));
                }
            }
            return request;
        }
                    private static CreateChangeSetRequestMarshaller _instance = new CreateChangeSetRequestMarshaller();        

        internal static CreateChangeSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateChangeSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}