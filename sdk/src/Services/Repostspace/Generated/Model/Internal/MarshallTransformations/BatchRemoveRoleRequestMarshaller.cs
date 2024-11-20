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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Repostspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Repostspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchRemoveRole Request Marshaller
    /// </summary>       
    public class BatchRemoveRoleRequestMarshaller : IMarshaller<IRequest, BatchRemoveRoleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchRemoveRoleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchRemoveRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Repostspace");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-05-13";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetSpaceId())
                throw new AmazonRepostspaceException("Request object does not have required field SpaceId set");
            request.AddPathResource("{spaceId}", StringUtils.FromString(publicRequest.SpaceId));
            request.ResourcePath = "/spaces/{spaceId}/roles";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessorIds())
                {
                    context.Writer.WritePropertyName("accessorIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccessorIdsListValue in publicRequest.AccessorIds)
                    {
                            context.Writer.Write(publicRequestAccessorIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("role");
                    context.Writer.Write(publicRequest.Role);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchRemoveRoleRequestMarshaller _instance = new BatchRemoveRoleRequestMarshaller();        

        internal static BatchRemoveRoleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchRemoveRoleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}