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
    /// Estimate Template Cost Request Marshaller
    /// </summary>       
    public class EstimateTemplateCostRequestMarshaller : IMarshaller<IRequest, EstimateTemplateCostRequest>
    {
        public IRequest Marshall(EstimateTemplateCostRequest estimateTemplateCostRequest)
        {
            IRequest request = new DefaultRequest(estimateTemplateCostRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "EstimateTemplateCost");
            request.Parameters.Add("Version", "2010-05-15");
            if (estimateTemplateCostRequest != null && estimateTemplateCostRequest.IsSetTemplateBody())
            {
                request.Parameters.Add("TemplateBody", StringUtils.FromString(estimateTemplateCostRequest.TemplateBody));
            }
            if (estimateTemplateCostRequest != null && estimateTemplateCostRequest.IsSetTemplateURL())
            {
                request.Parameters.Add("TemplateURL", StringUtils.FromString(estimateTemplateCostRequest.TemplateURL));
            }

            if (estimateTemplateCostRequest != null)
            {
                List<Parameter> parametersList = estimateTemplateCostRequest.Parameters;
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

            return request;
        }
    }
}
