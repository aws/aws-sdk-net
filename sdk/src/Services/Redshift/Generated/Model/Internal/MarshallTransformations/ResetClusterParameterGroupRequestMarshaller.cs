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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResetClusterParameterGroup Request Marshaller
    /// </summary>       
    public class ResetClusterParameterGroupRequestMarshaller : IMarshaller<IRequest, ResetClusterParameterGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ResetClusterParameterGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ResetClusterParameterGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "ResetClusterParameterGroup");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetParameterGroupName())
                {
                    request.Parameters.Add("ParameterGroupName", StringUtils.FromString(publicRequest.ParameterGroupName));
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
                            if(publicRequestlistValue.IsSetAllowedValues())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "AllowedValues", StringUtils.FromString(publicRequestlistValue.AllowedValues));
                            }
                            if(publicRequestlistValue.IsSetApplyType())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "ApplyType", StringUtils.FromString(publicRequestlistValue.ApplyType));
                            }
                            if(publicRequestlistValue.IsSetDataType())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "DataType", StringUtils.FromString(publicRequestlistValue.DataType));
                            }
                            if(publicRequestlistValue.IsSetDescription())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                            }
                            if(publicRequestlistValue.IsSetIsModifiable())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "IsModifiable", StringUtils.FromBool(publicRequestlistValue.IsModifiable));
                            }
                            if(publicRequestlistValue.IsSetMinimumEngineVersion())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "MinimumEngineVersion", StringUtils.FromString(publicRequestlistValue.MinimumEngineVersion));
                            }
                            if(publicRequestlistValue.IsSetParameterName())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "ParameterName", StringUtils.FromString(publicRequestlistValue.ParameterName));
                            }
                            if(publicRequestlistValue.IsSetParameterValue())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "ParameterValue", StringUtils.FromString(publicRequestlistValue.ParameterValue));
                            }
                            if(publicRequestlistValue.IsSetSource())
                            {
                                request.Parameters.Add("Parameters" + "." + "Parameter" + "." + publicRequestlistValueIndex + "." + "Source", StringUtils.FromString(publicRequestlistValue.Source));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetResetAllParameters())
                {
                    request.Parameters.Add("ResetAllParameters", StringUtils.FromBool(publicRequest.ResetAllParameters));
                }
            }
            return request;
        }
                    private static ResetClusterParameterGroupRequestMarshaller _instance = new ResetClusterParameterGroupRequestMarshaller();        

        internal static ResetClusterParameterGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResetClusterParameterGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}