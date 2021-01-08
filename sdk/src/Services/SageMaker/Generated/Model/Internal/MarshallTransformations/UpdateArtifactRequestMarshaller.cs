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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateArtifact Request Marshaller
    /// </summary>       
    public class UpdateArtifactRequestMarshaller : IMarshaller<IRequest, UpdateArtifactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateArtifactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateArtifactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.UpdateArtifact";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArtifactArn())
                {
                    context.Writer.WritePropertyName("ArtifactArn");
                    context.Writer.Write(publicRequest.ArtifactArn);
                }

                if(publicRequest.IsSetArtifactName())
                {
                    context.Writer.WritePropertyName("ArtifactName");
                    context.Writer.Write(publicRequest.ArtifactName);
                }

                if(publicRequest.IsSetProperties())
                {
                    context.Writer.WritePropertyName("Properties");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPropertiesKvp in publicRequest.Properties)
                    {
                        context.Writer.WritePropertyName(publicRequestPropertiesKvp.Key);
                        var publicRequestPropertiesValue = publicRequestPropertiesKvp.Value;

                            context.Writer.Write(publicRequestPropertiesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPropertiesToRemove())
                {
                    context.Writer.WritePropertyName("PropertiesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPropertiesToRemoveListValue in publicRequest.PropertiesToRemove)
                    {
                            context.Writer.Write(publicRequestPropertiesToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateArtifactRequestMarshaller _instance = new UpdateArtifactRequestMarshaller();        

        internal static UpdateArtifactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateArtifactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}