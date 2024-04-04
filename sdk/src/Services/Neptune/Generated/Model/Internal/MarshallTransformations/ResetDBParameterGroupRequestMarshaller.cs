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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptune.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResetDBParameterGroup Request Marshaller
    /// </summary>       
    public class ResetDBParameterGroupRequestMarshaller : IMarshaller<IRequest, ResetDBParameterGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ResetDBParameterGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ResetDBParameterGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptune");
            request.Parameters.Add("Action", "ResetDBParameterGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBParameterGroupName())
                {
                    request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(publicRequest.DBParameterGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetParameters())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Parameters)
                    {
                        if(publicRequestlistValue.IsSetAllowedValues())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AllowedValues", StringUtils.FromString(publicRequestlistValue.AllowedValues));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetApplyMethod())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ApplyMethod", StringUtils.FromString(publicRequestlistValue.ApplyMethod));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetApplyType())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ApplyType", StringUtils.FromString(publicRequestlistValue.ApplyType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetDataType())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DataType", StringUtils.FromString(publicRequestlistValue.DataType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetDescription())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIsModifiable())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IsModifiable", StringUtils.FromBool(publicRequestlistValue.IsModifiable));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetMinimumEngineVersion())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MinimumEngineVersion", StringUtils.FromString(publicRequestlistValue.MinimumEngineVersion));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetParameterName())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterName", StringUtils.FromString(publicRequestlistValue.ParameterName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetParameterValue())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterValue", StringUtils.FromString(publicRequestlistValue.ParameterValue));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetSource())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Source", StringUtils.FromString(publicRequestlistValue.Source));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetResetAllParameters())
                {
                    request.Parameters.Add("ResetAllParameters", StringUtils.FromBool(publicRequest.ResetAllParameters));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ResetDBParameterGroupRequestMarshaller _instance = new ResetDBParameterGroupRequestMarshaller();        

        internal static ResetDBParameterGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResetDBParameterGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}