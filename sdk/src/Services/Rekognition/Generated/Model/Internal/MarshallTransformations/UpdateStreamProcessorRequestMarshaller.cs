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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStreamProcessor Request Marshaller
    /// </summary>       
    public class UpdateStreamProcessorRequestMarshaller : IMarshaller<IRequest, UpdateStreamProcessorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStreamProcessorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStreamProcessorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.UpdateStreamProcessor";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDataSharingPreferenceForUpdate())
            {
                context.Writer.WritePropertyName("DataSharingPreferenceForUpdate");
                context.Writer.WriteStartObject();

                var marshaller = StreamProcessorDataSharingPreferenceMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSharingPreferenceForUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetParametersToDelete())
            {
                context.Writer.WritePropertyName("ParametersToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestParametersToDeleteListValue in publicRequest.ParametersToDelete)
                {
                        context.Writer.WriteStringValue(publicRequestParametersToDeleteListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRegionsOfInterestForUpdate())
            {
                context.Writer.WritePropertyName("RegionsOfInterestForUpdate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRegionsOfInterestForUpdateListValue in publicRequest.RegionsOfInterestForUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RegionOfInterestMarshaller.Instance;
                    marshaller.Marshall(publicRequestRegionsOfInterestForUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSettingsForUpdate())
            {
                context.Writer.WritePropertyName("SettingsForUpdate");
                context.Writer.WriteStartObject();

                var marshaller = StreamProcessorSettingsForUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.SettingsForUpdate, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateStreamProcessorRequestMarshaller _instance = new UpdateStreamProcessorRequestMarshaller();        

        internal static UpdateStreamProcessorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStreamProcessorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}