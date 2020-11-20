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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAppInstanceRetentionSettings Request Marshaller
    /// </summary>       
    public class PutAppInstanceRetentionSettingsRequestMarshaller : IMarshaller<IRequest, PutAppInstanceRetentionSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAppInstanceRetentionSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAppInstanceRetentionSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAppInstanceArn())
                throw new AmazonChimeException("Request object does not have required field AppInstanceArn set");
            request.AddPathResource("{appInstanceArn}", StringUtils.FromString(publicRequest.AppInstanceArn));
            request.ResourcePath = "/app-instances/{appInstanceArn}/retention-settings";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppInstanceRetentionSettings())
                {
                    context.Writer.WritePropertyName("AppInstanceRetentionSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = AppInstanceRetentionSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AppInstanceRetentionSettings, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"identity-";

            return request;
        }
        private static PutAppInstanceRetentionSettingsRequestMarshaller _instance = new PutAppInstanceRetentionSettingsRequestMarshaller();        

        internal static PutAppInstanceRetentionSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAppInstanceRetentionSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}