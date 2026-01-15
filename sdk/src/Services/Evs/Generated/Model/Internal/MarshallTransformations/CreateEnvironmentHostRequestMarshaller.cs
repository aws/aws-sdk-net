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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Evs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Evs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEnvironmentHost Request Marshaller
    /// </summary>       
    public class CreateEnvironmentHostRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentHostRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentHostRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEnvironmentHostRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Evs");
            string target = "AmazonElasticVMwareService.CreateEnvironmentHost";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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
                if(publicRequest.IsSetEnvironmentId())
                {
                    context.Writer.WritePropertyName("environmentId");
                    context.Writer.Write(publicRequest.EnvironmentId);
                }

                if(publicRequest.IsSetEsxVersion())
                {
                    context.Writer.WritePropertyName("esxVersion");
                    context.Writer.Write(publicRequest.EsxVersion);
                }

                if(publicRequest.IsSetHost())
                {
                    context.Writer.WritePropertyName("host");
                    context.Writer.WriteObjectStart();

                    var marshaller = HostInfoForCreateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Host, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEnvironmentHostRequestMarshaller _instance = new CreateEnvironmentHostRequestMarshaller();        

        internal static CreateEnvironmentHostRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEnvironmentHostRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}