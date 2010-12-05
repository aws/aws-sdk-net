/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Transform
{
    /// <summary>
    /// Modify D B Parameter Group Request Marshaller
    /// </summary>       
    public class ModifyDBParameterGroupRequestMarshaller : IMarshaller<IRequest<ModifyDBParameterGroupRequest>, ModifyDBParameterGroupRequest> 
    {

        public IRequest<ModifyDBParameterGroupRequest> Marshall(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest) 
        {
            IRequest<ModifyDBParameterGroupRequest> request = new DefaultRequest<ModifyDBParameterGroupRequest>(modifyDBParameterGroupRequest, "AmazonRDS");
            request.Parameters.Add("Action", "ModifyDBParameterGroup");
            request.Parameters.Add("Version", "2010-07-28");
            if (modifyDBParameterGroupRequest != null && modifyDBParameterGroupRequest.IsSetDBParameterGroupName()) 
            {
                request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(modifyDBParameterGroupRequest.DBParameterGroupName));
            }

            if (modifyDBParameterGroupRequest != null) 
            {
                List<Parameter> parametersList = modifyDBParameterGroupRequest.Parameters;
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
                    if (parametersListValue != null && parametersListValue.IsSetApplyType()) 
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".ApplyType", StringUtils.FromString(parametersListValue.ApplyType));
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
                    if (parametersListValue != null && parametersListValue.IsSetApplyMethod()) 
                    {
                        request.Parameters.Add("Parameters.member." + parametersListIndex + ".ApplyMethod", StringUtils.FromString(parametersListValue.ApplyMethod));
                    }

                    parametersListIndex++;
                }
            }


            return request;
        }
    }
}
