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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApiCache Request Marshaller
    /// </summary>       
    public class UpdateApiCacheRequestMarshaller : IMarshaller<IRequest, UpdateApiCacheRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApiCacheRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApiCacheRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
                throw new AmazonAppSyncException("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            request.ResourcePath = "/v1/apis/{apiId}/ApiCaches/update";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApiCachingBehavior())
                {
                    context.Writer.WritePropertyName("apiCachingBehavior");
                    context.Writer.Write(publicRequest.ApiCachingBehavior);
                }

                if(publicRequest.IsSetTtl())
                {
                    context.Writer.WritePropertyName("ttl");
                    context.Writer.Write(publicRequest.Ttl);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateApiCacheRequestMarshaller _instance = new UpdateApiCacheRequestMarshaller();        

        internal static UpdateApiCacheRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApiCacheRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}