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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2012-09-25/jobs";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInput())
                {
                    context.Writer.WritePropertyName("Input");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Input, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputs())
                {
                    context.Writer.WritePropertyName("Inputs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputsListValue in publicRequest.Inputs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = JobInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOutput())
                {
                    context.Writer.WritePropertyName("Output");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreateJobOutputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Output, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputKeyPrefix())
                {
                    context.Writer.WritePropertyName("OutputKeyPrefix");
                    context.Writer.Write(publicRequest.OutputKeyPrefix);
                }

                if(publicRequest.IsSetOutputs())
                {
                    context.Writer.WritePropertyName("Outputs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CreateJobOutputMarshaller.Instance;
                        marshaller.Marshall(publicRequestOutputsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPipelineId())
                {
                    context.Writer.WritePropertyName("PipelineId");
                    context.Writer.Write(publicRequest.PipelineId);
                }

                if(publicRequest.IsSetPlaylists())
                {
                    context.Writer.WritePropertyName("Playlists");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPlaylistsListValue in publicRequest.Playlists)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CreateJobPlaylistMarshaller.Instance;
                        marshaller.Marshall(publicRequestPlaylistsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserMetadata())
                {
                    context.Writer.WritePropertyName("UserMetadata");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestUserMetadataKvp in publicRequest.UserMetadata)
                    {
                        context.Writer.WritePropertyName(publicRequestUserMetadataKvp.Key);
                        var publicRequestUserMetadataValue = publicRequestUserMetadataKvp.Value;

                            context.Writer.Write(publicRequestUserMetadataValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}