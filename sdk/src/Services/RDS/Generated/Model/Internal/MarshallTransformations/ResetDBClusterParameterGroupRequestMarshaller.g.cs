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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResetDBClusterParameterGroup Request Marshaller
    /// </summary>
    public partial class ResetDBClusterParameterGroupRequestMarshaller : IMarshaller<IRequest, ResetDBClusterParameterGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ResetDBClusterParameterGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ResetDBClusterParameterGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ResetDBClusterParameterGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetDBClusterParameterGroupName())
            {
                request.Parameters.Add("DBClusterParameterGroupName", StringUtils.FromString(publicRequest.DBClusterParameterGroupName));
            }
            if (publicRequest.IsSetParameters())
            {
                if (publicRequest.Parameters.Count == 0)
                {
                    request.Parameters.Add("Parameters", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Parameters)
                    {
                        if (item0.IsSetAllowedValues())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".AllowedValues", StringUtils.FromString(item0.AllowedValues));
                        }
                        if (item0.IsSetApplyMethod())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".ApplyMethod", StringUtils.FromString(item0.ApplyMethod));
                        }
                        if (item0.IsSetApplyType())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".ApplyType", StringUtils.FromString(item0.ApplyType));
                        }
                        if (item0.IsSetDataType())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".DataType", StringUtils.FromString(item0.DataType));
                        }
                        if (item0.IsSetDescription())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".Description", StringUtils.FromString(item0.Description));
                        }
                        if (item0.IsSetIsModifiable())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".IsModifiable", StringUtils.FromBool(item0.IsModifiable.Value));
                        }
                        if (item0.IsSetMinimumEngineVersion())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".MinimumEngineVersion", StringUtils.FromString(item0.MinimumEngineVersion));
                        }
                        if (item0.IsSetParameterName())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".ParameterName", StringUtils.FromString(item0.ParameterName));
                        }
                        if (item0.IsSetParameterValue())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".ParameterValue", StringUtils.FromString(item0.ParameterValue));
                        }
                        if (item0.IsSetSource())
                        {
                            request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".Source", StringUtils.FromString(item0.Source));
                        }
                        if (item0.IsSetSupportedEngineModes())
                        {
                            if (item0.SupportedEngineModes.Count == 0)
                            {
                                request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".SupportedEngineModes", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.SupportedEngineModes)
                                {
                                    request.Parameters.Add("Parameters" + ".Parameter" + "." + index0 + ".SupportedEngineModes" + ".member" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetResetAllParameters())
            {
                request.Parameters.Add("ResetAllParameters", StringUtils.FromBool(publicRequest.ResetAllParameters.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ResetDBClusterParameterGroupRequestMarshaller _instance = new();

        internal static ResetDBClusterParameterGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ResetDBClusterParameterGroupRequestMarshaller Instance => _instance;
    }
}
