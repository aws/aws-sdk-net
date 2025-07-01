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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
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
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCloudExadataInfrastructure Request Marshaller
    /// </summary>       
    public class CreateCloudExadataInfrastructureRequestMarshaller : IMarshaller<IRequest, CreateCloudExadataInfrastructureRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCloudExadataInfrastructureRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCloudExadataInfrastructureRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateCloudExadataInfrastructure";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
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
            if(publicRequest.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("availabilityZone");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZone);
            }

            if(publicRequest.IsSetAvailabilityZoneId())
            {
                context.Writer.WritePropertyName("availabilityZoneId");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZoneId);
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
            if(publicRequest.IsSetComputeCount())
            {
                context.Writer.WritePropertyName("computeCount");
                context.Writer.WriteNumberValue(publicRequest.ComputeCount.Value);
            }

            if(publicRequest.IsSetCustomerContactsToSendToOCI())
            {
                context.Writer.WritePropertyName("customerContactsToSendToOCI");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomerContactsToSendToOCIListValue in publicRequest.CustomerContactsToSendToOCI)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomerContactMarshaller.Instance;
                    marshaller.Marshall(publicRequestCustomerContactsToSendToOCIListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDatabaseServerType())
            {
                context.Writer.WritePropertyName("databaseServerType");
                context.Writer.WriteStringValue(publicRequest.DatabaseServerType);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetMaintenanceWindow())
            {
                context.Writer.WritePropertyName("maintenanceWindow");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowMarshaller.Instance;
                marshaller.Marshall(publicRequest.MaintenanceWindow, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetShape())
            {
                context.Writer.WritePropertyName("shape");
                context.Writer.WriteStringValue(publicRequest.Shape);
            }

            if(publicRequest.IsSetStorageCount())
            {
                context.Writer.WritePropertyName("storageCount");
                context.Writer.WriteNumberValue(publicRequest.StorageCount.Value);
            }

            if(publicRequest.IsSetStorageServerType())
            {
                context.Writer.WritePropertyName("storageServerType");
                context.Writer.WriteStringValue(publicRequest.StorageServerType);
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
        private static CreateCloudExadataInfrastructureRequestMarshaller _instance = new CreateCloudExadataInfrastructureRequestMarshaller();        

        internal static CreateCloudExadataInfrastructureRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCloudExadataInfrastructureRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}