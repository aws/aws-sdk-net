/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// UpdateGraphqlApi Request Marshaller
    /// </summary>       
    public class UpdateGraphqlApiRequestMarshaller : IMarshaller<IRequest, UpdateGraphqlApiRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGraphqlApiRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGraphqlApiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/v1/apis/{apiId}";
            if (!publicRequest.IsSetApiId())
                throw new AmazonAppSyncException("Request object does not have required field ApiId set");
            uriResourcePath = uriResourcePath.Replace("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthenticationType())
                {
                    context.Writer.WritePropertyName("authenticationType");
                    context.Writer.Write(publicRequest.AuthenticationType);
                }

                if(publicRequest.IsSetLogConfig())
                {
                    context.Writer.WritePropertyName("logConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOpenIDConnectConfig())
                {
                    context.Writer.WritePropertyName("openIDConnectConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OpenIDConnectConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OpenIDConnectConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUserPoolConfig())
                {
                    context.Writer.WritePropertyName("userPoolConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserPoolConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserPoolConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateGraphqlApiRequestMarshaller _instance = new UpdateGraphqlApiRequestMarshaller();        

        internal static UpdateGraphqlApiRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGraphqlApiRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}