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
    /// UpdateStack Request Marshaller
    /// </summary>       
    public class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStackRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "UpdateStack");
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
                if(publicRequest.IsSetClientRequestToken())
                {
                    request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
                }
                if(publicRequest.IsSetDisableRollback())
                {
                    request.Parameters.Add("DisableRollback", StringUtils.FromBool(publicRequest.DisableRollback));
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
                if(publicRequest.IsSetRetainExceptOnCreate())
                {
                    request.Parameters.Add("RetainExceptOnCreate", StringUtils.FromBool(publicRequest.RetainExceptOnCreate));
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
                if(publicRequest.IsSetStackPolicyBody())
                {
                    request.Parameters.Add("StackPolicyBody", StringUtils.FromString(publicRequest.StackPolicyBody));
                }
                if(publicRequest.IsSetStackPolicyDuringUpdateBody())
                {
                    request.Parameters.Add("StackPolicyDuringUpdateBody", StringUtils.FromString(publicRequest.StackPolicyDuringUpdateBody));
                }
                if(publicRequest.IsSetStackPolicyDuringUpdateURL())
                {
                    request.Parameters.Add("StackPolicyDuringUpdateURL", StringUtils.FromString(publicRequest.StackPolicyDuringUpdateURL));
                }
                if(publicRequest.IsSetStackPolicyURL())
                {
                    request.Parameters.Add("StackPolicyURL", StringUtils.FromString(publicRequest.StackPolicyURL));
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
                    private static UpdateStackRequestMarshaller _instance = new UpdateStackRequestMarshaller();        

        internal static UpdateStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}