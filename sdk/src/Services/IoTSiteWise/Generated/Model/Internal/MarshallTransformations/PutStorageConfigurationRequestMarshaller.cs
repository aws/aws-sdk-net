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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutStorageConfiguration Request Marshaller
    /// </summary>       
    public class PutStorageConfigurationRequestMarshaller : IMarshaller<IRequest, PutStorageConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutStorageConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutStorageConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/configuration/account/storage";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDisallowIngestNullNaN())
            {
                context.Writer.WritePropertyName("disallowIngestNullNaN");
                context.Writer.WriteBooleanValue(publicRequest.DisallowIngestNullNaN.Value);
            }

            if(publicRequest.IsSetDisassociatedDataStorage())
            {
                context.Writer.WritePropertyName("disassociatedDataStorage");
                context.Writer.WriteStringValue(publicRequest.DisassociatedDataStorage);
            }

            if(publicRequest.IsSetMultiLayerStorage())
            {
                context.Writer.WritePropertyName("multiLayerStorage");
                context.Writer.WriteStartObject();

                var marshaller = MultiLayerStorageMarshaller.Instance;
                marshaller.Marshall(publicRequest.MultiLayerStorage, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRetentionPeriod())
            {
                context.Writer.WritePropertyName("retentionPeriod");
                context.Writer.WriteStartObject();

                var marshaller = RetentionPeriodMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetentionPeriod, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStorageType())
            {
                context.Writer.WritePropertyName("storageType");
                context.Writer.WriteStringValue(publicRequest.StorageType);
            }

            if(publicRequest.IsSetWarmTier())
            {
                context.Writer.WritePropertyName("warmTier");
                context.Writer.WriteStringValue(publicRequest.WarmTier);
            }

            if(publicRequest.IsSetWarmTierRetentionPeriod())
            {
                context.Writer.WritePropertyName("warmTierRetentionPeriod");
                context.Writer.WriteStartObject();

                var marshaller = WarmTierRetentionPeriodMarshaller.Instance;
                marshaller.Marshall(publicRequest.WarmTierRetentionPeriod, context);

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
            

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static PutStorageConfigurationRequestMarshaller _instance = new PutStorageConfigurationRequestMarshaller();        

        internal static PutStorageConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutStorageConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}