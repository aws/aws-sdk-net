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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecretsManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecretsManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSecretValue Request Marshaller
    /// </summary>       
    public class PutSecretValueRequestMarshaller : IMarshaller<IRequest, PutSecretValueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSecretValueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSecretValueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecretsManager");
            string target = "secretsmanager.PutSecretValue";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetRotationToken())
                {
                    context.Writer.WritePropertyName("RotationToken");
                    context.Writer.Write(publicRequest.RotationToken);
                }

                if(publicRequest.IsSetSecretBinary())
                {
                    context.Writer.WritePropertyName("SecretBinary");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.SecretBinary));
                }

                if(publicRequest.IsSetSecretId())
                {
                    context.Writer.WritePropertyName("SecretId");
                    context.Writer.Write(publicRequest.SecretId);
                }

                if(publicRequest.IsSetSecretString())
                {
                    context.Writer.WritePropertyName("SecretString");
                    context.Writer.Write(publicRequest.SecretString);
                }

                if(publicRequest.IsSetVersionStages())
                {
                    context.Writer.WritePropertyName("VersionStages");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVersionStagesListValue in publicRequest.VersionStages)
                    {
                            context.Writer.Write(publicRequestVersionStagesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutSecretValueRequestMarshaller _instance = new PutSecretValueRequestMarshaller();        

        internal static PutSecretValueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSecretValueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}