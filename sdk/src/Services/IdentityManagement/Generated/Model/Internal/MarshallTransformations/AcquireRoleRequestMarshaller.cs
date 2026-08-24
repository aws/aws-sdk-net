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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AcquireRole Request Marshaller
    /// </summary>       
    public class AcquireRoleRequestMarshaller : IMarshaller<IRequest, AcquireRoleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AcquireRoleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AcquireRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "AcquireRole");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetReplacementValues())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.ReplacementValues.Keys)
                    {
                        ReplacementValueEntry value;
                        bool hasValue = publicRequest.ReplacementValues.TryGetValue(key, out value);
                        request.Parameters.Add("ReplacementValues" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            if(value.IsSetValues())
                            {
                                if (value.Values.Count == 0)
                                    request.Parameters.Add("ReplacementValues" + "." + "entry" + "." + mapIndex + "." + "value" + "." + "Values", "");
                                else
                                {
                                     int valuelistValueIndex = 1;
                                     foreach(var valuelistValue in value.Values)
                                     {
                                         request.Parameters.Add("ReplacementValues" + "." + "entry" + "." + mapIndex + "." + "value" + "." + "Values" + "." + "member" + "." + valuelistValueIndex, StringUtils.FromString(valuelistValue));
                                         valuelistValueIndex++;
                                     }
                                }
                            }
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetTemplateArn())
                {
                    request.Parameters.Add("TemplateArn", StringUtils.FromString(publicRequest.TemplateArn));
                }
                if(publicRequest.IsSetTemplateMinorVersion())
                {
                    request.Parameters.Add("TemplateMinorVersion", StringUtils.FromInt(publicRequest.TemplateMinorVersion));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif
            return request;
        }
                    private static AcquireRoleRequestMarshaller _instance = new AcquireRoleRequestMarshaller();        

        internal static AcquireRoleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AcquireRoleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}