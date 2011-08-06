/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFormation.Model.Transform
{
    /// <summary>
    /// Create Stack Request Marshaller
    /// </summary>       
    public class CreateStackRequestMarshaller : IMarshaller<IRequest<CreateStackRequest>, CreateStackRequest> 
    {

        public IRequest<CreateStackRequest> Marshall(CreateStackRequest createStackRequest) 
        {
            IRequest<CreateStackRequest> request = new DefaultRequest<CreateStackRequest>(createStackRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "CreateStack");
            request.Parameters.Add("Version", "2010-05-15");
            if (createStackRequest != null && createStackRequest.IsSetStackName()) 
            {
                request.Parameters.Add("StackName", StringUtils.FromString(createStackRequest.StackName));
            }
            if (createStackRequest != null && createStackRequest.IsSetTemplateBody()) 
            {
                request.Parameters.Add("TemplateBody", StringUtils.FromString(createStackRequest.TemplateBody));
            }
            if (createStackRequest != null && createStackRequest.IsSetTemplateURL()) 
            {
                request.Parameters.Add("TemplateURL", StringUtils.FromString(createStackRequest.TemplateURL));
            }

            if (createStackRequest != null) 
            {
                List<Parameter> parametersList = createStackRequest.Parameters;
                int parametersListIndex = 1;
                foreach (Parameter parametersListValue in parametersList) 
                { 
                    if (parametersListValue != null && parametersListValue.IsSetParameterKey()) 
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".ParameterKey", StringUtils.FromString(parametersListValue.ParameterKey));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetParameterValue()) 
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".ParameterValue", StringUtils.FromString(parametersListValue.ParameterValue));
                    }

                    parametersListIndex++;
                }
            }
            if (createStackRequest != null && createStackRequest.IsSetDisableRollback()) 
            {
                request.Parameters.Add("DisableRollback", StringUtils.FromBool(createStackRequest.DisableRollback));
            }
            if (createStackRequest != null && createStackRequest.IsSetTimeoutInMinutes()) 
            {
                request.Parameters.Add("TimeoutInMinutes", StringUtils.FromInt(createStackRequest.TimeoutInMinutes));
            }
            if (createStackRequest != null) 
            {
                List<string> notificationARNsList = createStackRequest.NotificationARNs;

                int notificationARNsListIndex = 1;
                foreach (string notificationARNsListValue in notificationARNsList) 
                { 
                    request.Parameters.Add("NotificationARNs.member." + notificationARNsListIndex, StringUtils.FromString(notificationARNsListValue));
                    notificationARNsListIndex++;
                }
            }


            return request;
        }
    }
}
