/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStack Request Marshaller
    /// </summary>       
    public class CreateStackRequestMarshaller : IMarshaller<IRequest, CreateStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStackRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "CreateStack");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCapabilities())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Capabilities)
                    {
                        request.Parameters.Add("Capabilities" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
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
                if(publicRequest.IsSetEnableTerminationProtection())
                {
                    request.Parameters.Add("EnableTerminationProtection", StringUtils.FromBool(publicRequest.EnableTerminationProtection));
                }
                if(publicRequest.IsSetNotificationARNs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.NotificationARNs)
                    {
                        request.Parameters.Add("NotificationARNs" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetOnFailure())
                {
                    request.Parameters.Add("OnFailure", StringUtils.FromString(publicRequest.OnFailure));
                }
                if(publicRequest.IsSetParameters())
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
                if(publicRequest.IsSetResourceTypes())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ResourceTypes)
                    {
                        request.Parameters.Add("ResourceTypes" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
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
                if(publicRequest.IsSetStackName())
                {
                    request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
                }
                if(publicRequest.IsSetStackPolicyBody())
                {
                    request.Parameters.Add("StackPolicyBody", StringUtils.FromString(publicRequest.StackPolicyBody));
                }
                if(publicRequest.IsSetStackPolicyURL())
                {
                    request.Parameters.Add("StackPolicyURL", StringUtils.FromString(publicRequest.StackPolicyURL));
                }
                if(publicRequest.IsSetTags())
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
                if(publicRequest.IsSetTemplateBody())
                {
                    request.Parameters.Add("TemplateBody", StringUtils.FromString(publicRequest.TemplateBody));
                }
                if(publicRequest.IsSetTemplateURL())
                {
                    request.Parameters.Add("TemplateURL", StringUtils.FromString(publicRequest.TemplateURL));
                }
                if(publicRequest.IsSetTimeoutInMinutes())
                {
                    request.Parameters.Add("TimeoutInMinutes", StringUtils.FromInt(publicRequest.TimeoutInMinutes));
                }
            }
            return request;
        }
                    private static CreateStackRequestMarshaller _instance = new CreateStackRequestMarshaller();        

        internal static CreateStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}