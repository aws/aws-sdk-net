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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateComponent Request Marshaller
    /// </summary>       
    public class CreateComponentRequestMarshaller : IMarshaller<IRequest, CreateComponentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateComponentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateComponentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AmplifyUIBuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-11";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyUIBuilderException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            if (!publicRequest.IsSetEnvironmentName())
                throw new AmazonAmplifyUIBuilderException("Request object does not have required field EnvironmentName set");
            request.AddPathResource("{environmentName}", StringUtils.FromString(publicRequest.EnvironmentName));
            
            if (publicRequest.IsSetClientToken())
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            else            
                request.Parameters.Add("clientToken", System.Guid.NewGuid().ToString());
                
            request.ResourcePath = "/app/{appId}/environment/{environmentName}/components";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                var context = new JsonMarshallerContext(request, writer);
                context.Writer.WriteObjectStart();

                var marshaller = CreateComponentDataMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComponentToCreate, context);

                context.Writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static CreateComponentRequestMarshaller _instance = new CreateComponentRequestMarshaller();        

        internal static CreateComponentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateComponentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}