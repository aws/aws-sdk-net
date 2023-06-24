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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePipe Request Marshaller
    /// </summary>       
    public class CreatePipeRequestMarshaller : IMarshaller<IRequest, CreatePipeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePipeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePipeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pipes");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-07";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetName())
                throw new AmazonPipesException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v1/pipes/{Name}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDesiredState())
                {
                    context.Writer.WritePropertyName("DesiredState");
                    context.Writer.Write(publicRequest.DesiredState);
                }

                if(publicRequest.IsSetEnrichment())
                {
                    context.Writer.WritePropertyName("Enrichment");
                    context.Writer.Write(publicRequest.Enrichment);
                }

                if(publicRequest.IsSetEnrichmentParameters())
                {
                    context.Writer.WritePropertyName("EnrichmentParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = PipeEnrichmentParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EnrichmentParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSource())
                {
                    context.Writer.WritePropertyName("Source");
                    context.Writer.Write(publicRequest.Source);
                }

                if(publicRequest.IsSetSourceParameters())
                {
                    context.Writer.WritePropertyName("SourceParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = PipeSourceParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("Target");
                    context.Writer.Write(publicRequest.Target);
                }

                if(publicRequest.IsSetTargetParameters())
                {
                    context.Writer.WritePropertyName("TargetParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = PipeTargetParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TargetParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreatePipeRequestMarshaller _instance = new CreatePipeRequestMarshaller();        

        internal static CreatePipeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePipeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}