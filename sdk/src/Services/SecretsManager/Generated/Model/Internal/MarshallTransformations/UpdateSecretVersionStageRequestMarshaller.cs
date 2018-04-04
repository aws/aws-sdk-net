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

namespace Amazon.SecretsManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSecretVersionStage Request Marshaller
    /// </summary>       
    public class UpdateSecretVersionStageRequestMarshaller : IMarshaller<IRequest, UpdateSecretVersionStageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSecretVersionStageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSecretVersionStageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecretsManager");
            string target = "secretsmanager.UpdateSecretVersionStage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMoveToVersionId())
                {
                    context.Writer.WritePropertyName("MoveToVersionId");
                    context.Writer.Write(publicRequest.MoveToVersionId);
                }

                if(publicRequest.IsSetRemoveFromVersionId())
                {
                    context.Writer.WritePropertyName("RemoveFromVersionId");
                    context.Writer.Write(publicRequest.RemoveFromVersionId);
                }

                if(publicRequest.IsSetSecretId())
                {
                    context.Writer.WritePropertyName("SecretId");
                    context.Writer.Write(publicRequest.SecretId);
                }

                if(publicRequest.IsSetVersionStage())
                {
                    context.Writer.WritePropertyName("VersionStage");
                    context.Writer.Write(publicRequest.VersionStage);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSecretVersionStageRequestMarshaller _instance = new UpdateSecretVersionStageRequestMarshaller();        

        internal static UpdateSecretVersionStageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSecretVersionStageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}