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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Reset Cluster Parameter Group Request Marshaller
    /// </summary>       
    public class ResetClusterParameterGroupRequestMarshaller : IMarshaller<IRequest, ResetClusterParameterGroupRequest>
    {
        public IRequest Marshall(ResetClusterParameterGroupRequest resetClusterParameterGroupRequest)
        {
            IRequest request = new DefaultRequest(resetClusterParameterGroupRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "ResetClusterParameterGroup");
            request.Parameters.Add("Version", "2012-12-01");
            if (resetClusterParameterGroupRequest != null && resetClusterParameterGroupRequest.IsSetParameterGroupName())
            {
                request.Parameters.Add("ParameterGroupName", StringUtils.FromString(resetClusterParameterGroupRequest.ParameterGroupName));
            }
            if (resetClusterParameterGroupRequest != null && resetClusterParameterGroupRequest.IsSetResetAllParameters())
            {
                request.Parameters.Add("ResetAllParameters", StringUtils.FromBool(resetClusterParameterGroupRequest.ResetAllParameters));
            }

            if (resetClusterParameterGroupRequest != null)
            {
                List<Parameter> parametersList = resetClusterParameterGroupRequest.Parameters;
                int parametersListIndex = 1;
                foreach (Parameter parametersListValue in parametersList)
                {
                    if (parametersListValue != null && parametersListValue.IsSetParameterName())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".ParameterName", StringUtils.FromString(parametersListValue.ParameterName));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetParameterValue())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".ParameterValue", StringUtils.FromString(parametersListValue.ParameterValue));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetDescription())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".Description", StringUtils.FromString(parametersListValue.Description));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetSource())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".Source", StringUtils.FromString(parametersListValue.Source));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetDataType())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".DataType", StringUtils.FromString(parametersListValue.DataType));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetAllowedValues())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".AllowedValues", StringUtils.FromString(parametersListValue.AllowedValues));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetIsModifiable())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".IsModifiable", StringUtils.FromBool(parametersListValue.IsModifiable));
                    }
                    if (parametersListValue != null && parametersListValue.IsSetMinimumEngineVersion())
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".MinimumEngineVersion", StringUtils.FromString(parametersListValue.MinimumEngineVersion));
                    }

                    parametersListIndex++;
                }
            }

            return request;
        }
    }
}
