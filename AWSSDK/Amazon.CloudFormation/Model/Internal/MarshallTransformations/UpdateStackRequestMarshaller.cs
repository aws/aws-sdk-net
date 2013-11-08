/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Stack Request Marshaller
    /// </summary>       
    public class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest>
    {
        public IRequest Marshall(UpdateStackRequest updateStackRequest)
        {
            IRequest request = new DefaultRequest(updateStackRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "UpdateStack");
            request.Parameters.Add("Version", "2010-05-15");
            if (updateStackRequest != null && updateStackRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(updateStackRequest.StackName));
            }
            if (updateStackRequest != null && updateStackRequest.IsSetTemplateBody())
            {
                request.Parameters.Add("TemplateBody", StringUtils.FromString(updateStackRequest.TemplateBody));
            }
            if (updateStackRequest != null && updateStackRequest.IsSetTemplateURL())
            {
                request.Parameters.Add("TemplateURL", StringUtils.FromString(updateStackRequest.TemplateURL));
            }
            if (updateStackRequest != null && updateStackRequest.IsSetStackPolicyDuringUpdateBody())
            {
                request.Parameters.Add("StackPolicyDuringUpdateBody", StringUtils.FromString(updateStackRequest.StackPolicyDuringUpdateBody));
            }
            if (updateStackRequest != null && updateStackRequest.IsSetStackPolicyDuringUpdateURL())
            {
                request.Parameters.Add("StackPolicyDuringUpdateURL", StringUtils.FromString(updateStackRequest.StackPolicyDuringUpdateURL));
            }

            if (updateStackRequest != null)
            {
                List<Parameter> parametersList = updateStackRequest.Parameters;
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
            if (updateStackRequest != null)
            {
                List<string> capabilitiesList = updateStackRequest.Capabilities;

                int capabilitiesListIndex = 1;
                foreach (string capabilitiesListValue in capabilitiesList)
                { 
                    request.Parameters.Add("Capabilities.member." + capabilitiesListIndex, StringUtils.FromString(capabilitiesListValue));
                    capabilitiesListIndex++;
                }
            }
            if (updateStackRequest != null && updateStackRequest.IsSetStackPolicyBody())
            {
                request.Parameters.Add("StackPolicyBody", StringUtils.FromString(updateStackRequest.StackPolicyBody));
            }
            if (updateStackRequest != null && updateStackRequest.IsSetStackPolicyURL())
            {
                request.Parameters.Add("StackPolicyURL", StringUtils.FromString(updateStackRequest.StackPolicyURL));
            }

            return request;
        }
    }
}
