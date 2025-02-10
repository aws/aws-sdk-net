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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
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
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStateTemplate Request Marshaller
    /// </summary>       
    public class UpdateStateTemplateRequestMarshaller : IMarshaller<IRequest, UpdateStateTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStateTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStateTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTFleetWise");
            string target = "IoTAutobahnControlPlane.UpdateStateTemplate";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-17";
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
            if(publicRequest.IsSetDataExtraDimensions())
            {
                context.Writer.WritePropertyName("dataExtraDimensions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDataExtraDimensionsListValue in publicRequest.DataExtraDimensions)
                {
                        context.Writer.WriteStringValue(publicRequestDataExtraDimensionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetIdentifier())
            {
                context.Writer.WritePropertyName("identifier");
                context.Writer.WriteStringValue(publicRequest.Identifier);
            }

            if(publicRequest.IsSetMetadataExtraDimensions())
            {
                context.Writer.WritePropertyName("metadataExtraDimensions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetadataExtraDimensionsListValue in publicRequest.MetadataExtraDimensions)
                {
                        context.Writer.WriteStringValue(publicRequestMetadataExtraDimensionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStateTemplatePropertiesToAdd())
            {
                context.Writer.WritePropertyName("stateTemplatePropertiesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStateTemplatePropertiesToAddListValue in publicRequest.StateTemplatePropertiesToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestStateTemplatePropertiesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStateTemplatePropertiesToRemove())
            {
                context.Writer.WritePropertyName("stateTemplatePropertiesToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStateTemplatePropertiesToRemoveListValue in publicRequest.StateTemplatePropertiesToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestStateTemplatePropertiesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
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
        private static UpdateStateTemplateRequestMarshaller _instance = new UpdateStateTemplateRequestMarshaller();        

        internal static UpdateStateTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStateTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}