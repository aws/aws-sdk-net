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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
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
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateKxDataview Request Marshaller
    /// </summary>       
    public class CreateKxDataviewRequestMarshaller : IMarshaller<IRequest, CreateKxDataviewRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateKxDataviewRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateKxDataviewRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Finspace");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-03-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDatabaseName())
                throw new AmazonFinspaceException("Request object does not have required field DatabaseName set");
            request.AddPathResource("{databaseName}", StringUtils.FromString(publicRequest.DatabaseName));
            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonFinspaceException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/kx/environments/{environmentId}/databases/{databaseName}/dataviews";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAutoUpdate())
            {
                context.Writer.WritePropertyName("autoUpdate");
                context.Writer.WriteBooleanValue(publicRequest.AutoUpdate.Value);
            }

            if(publicRequest.IsSetAvailabilityZoneId())
            {
                context.Writer.WritePropertyName("availabilityZoneId");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZoneId);
            }

            if(publicRequest.IsSetAzMode())
            {
                context.Writer.WritePropertyName("azMode");
                context.Writer.WriteStringValue(publicRequest.AzMode);
            }

            if(publicRequest.IsSetChangesetId())
            {
                context.Writer.WritePropertyName("changesetId");
                context.Writer.WriteStringValue(publicRequest.ChangesetId);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDataviewName())
            {
                context.Writer.WritePropertyName("dataviewName");
                context.Writer.WriteStringValue(publicRequest.DataviewName);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetReadWrite())
            {
                context.Writer.WritePropertyName("readWrite");
                context.Writer.WriteBooleanValue(publicRequest.ReadWrite.Value);
            }

            if(publicRequest.IsSetSegmentConfigurations())
            {
                context.Writer.WritePropertyName("segmentConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSegmentConfigurationsListValue in publicRequest.SegmentConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KxDataviewSegmentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestSegmentConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
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
        private static CreateKxDataviewRequestMarshaller _instance = new CreateKxDataviewRequestMarshaller();        

        internal static CreateKxDataviewRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateKxDataviewRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}