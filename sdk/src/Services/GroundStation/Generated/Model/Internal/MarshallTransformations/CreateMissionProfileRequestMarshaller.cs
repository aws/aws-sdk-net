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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMissionProfile Request Marshaller
    /// </summary>       
    public class CreateMissionProfileRequestMarshaller : IMarshaller<IRequest, CreateMissionProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMissionProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMissionProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GroundStation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-05-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/missionprofile";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContactPostPassDurationSeconds())
                {
                    context.Writer.WritePropertyName("contactPostPassDurationSeconds");
                    context.Writer.Write(publicRequest.ContactPostPassDurationSeconds);
                }

                if(publicRequest.IsSetContactPrePassDurationSeconds())
                {
                    context.Writer.WritePropertyName("contactPrePassDurationSeconds");
                    context.Writer.Write(publicRequest.ContactPrePassDurationSeconds);
                }

                if(publicRequest.IsSetDataflowEdges())
                {
                    context.Writer.WritePropertyName("dataflowEdges");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDataflowEdgesListValue in publicRequest.DataflowEdges)
                    {
                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestDataflowEdgesListValueListValue in publicRequestDataflowEdgesListValue)
                        {
                                context.Writer.Write(publicRequestDataflowEdgesListValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMinimumViableContactDurationSeconds())
                {
                    context.Writer.WritePropertyName("minimumViableContactDurationSeconds");
                    context.Writer.Write(publicRequest.MinimumViableContactDurationSeconds);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetStreamsKmsKey())
                {
                    context.Writer.WritePropertyName("streamsKmsKey");
                    context.Writer.WriteObjectStart();

                    var marshaller = KmsKeyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StreamsKmsKey, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStreamsKmsRole())
                {
                    context.Writer.WritePropertyName("streamsKmsRole");
                    context.Writer.Write(publicRequest.StreamsKmsRole);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTrackingConfigArn())
                {
                    context.Writer.WritePropertyName("trackingConfigArn");
                    context.Writer.Write(publicRequest.TrackingConfigArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMissionProfileRequestMarshaller _instance = new CreateMissionProfileRequestMarshaller();        

        internal static CreateMissionProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMissionProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}