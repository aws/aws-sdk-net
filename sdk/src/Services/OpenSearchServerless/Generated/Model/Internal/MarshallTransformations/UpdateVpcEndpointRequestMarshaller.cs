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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpenSearchServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateVpcEndpoint Request Marshaller
    /// </summary>       
    public class UpdateVpcEndpointRequestMarshaller : IMarshaller<IRequest, UpdateVpcEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateVpcEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateVpcEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchServerless");
            string target = "OpenSearchServerless.UpdateVpcEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("addSecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddSecurityGroupIdsListValue in publicRequest.AddSecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestAddSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAddSubnetIds())
                {
                    context.Writer.WritePropertyName("addSubnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddSubnetIdsListValue in publicRequest.AddSubnetIds)
                    {
                            context.Writer.Write(publicRequestAddSubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetRemoveSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("removeSecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveSecurityGroupIdsListValue in publicRequest.RemoveSecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestRemoveSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRemoveSubnetIds())
                {
                    context.Writer.WritePropertyName("removeSubnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveSubnetIdsListValue in publicRequest.RemoveSubnetIds)
                    {
                            context.Writer.Write(publicRequestRemoveSubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateVpcEndpointRequestMarshaller _instance = new UpdateVpcEndpointRequestMarshaller();        

        internal static UpdateVpcEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateVpcEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}