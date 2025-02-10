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
    /// CreateCampaign Request Marshaller
    /// </summary>       
    public class CreateCampaignRequestMarshaller : IMarshaller<IRequest, CreateCampaignRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCampaignRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCampaignRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTFleetWise");
            string target = "IoTAutobahnControlPlane.CreateCampaign";
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
            if(publicRequest.IsSetCollectionScheme())
            {
                context.Writer.WritePropertyName("collectionScheme");
                context.Writer.WriteStartObject();

                var marshaller = CollectionSchemeMarshaller.Instance;
                marshaller.Marshall(publicRequest.CollectionScheme, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCompression())
            {
                context.Writer.WritePropertyName("compression");
                context.Writer.WriteStringValue(publicRequest.Compression);
            }

            if(publicRequest.IsSetDataDestinationConfigs())
            {
                context.Writer.WritePropertyName("dataDestinationConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDataDestinationConfigsListValue in publicRequest.DataDestinationConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataDestinationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestDataDestinationConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

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

            if(publicRequest.IsSetDataPartitions())
            {
                context.Writer.WritePropertyName("dataPartitions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDataPartitionsListValue in publicRequest.DataPartitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataPartitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestDataPartitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDiagnosticsMode())
            {
                context.Writer.WritePropertyName("diagnosticsMode");
                context.Writer.WriteStringValue(publicRequest.DiagnosticsMode);
            }

            if(publicRequest.IsSetExpiryTime())
            {
                context.Writer.WritePropertyName("expiryTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ExpiryTime.Value)));
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPostTriggerCollectionDuration())
            {
                context.Writer.WritePropertyName("postTriggerCollectionDuration");
                context.Writer.WriteNumberValue(publicRequest.PostTriggerCollectionDuration.Value);
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(publicRequest.Priority.Value);
            }

            if(publicRequest.IsSetSignalCatalogArn())
            {
                context.Writer.WritePropertyName("signalCatalogArn");
                context.Writer.WriteStringValue(publicRequest.SignalCatalogArn);
            }

            if(publicRequest.IsSetSignalsToCollect())
            {
                context.Writer.WritePropertyName("signalsToCollect");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSignalsToCollectListValue in publicRequest.SignalsToCollect)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SignalInformationMarshaller.Instance;
                    marshaller.Marshall(publicRequestSignalsToCollectListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSignalsToFetch())
            {
                context.Writer.WritePropertyName("signalsToFetch");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSignalsToFetchListValue in publicRequest.SignalsToFetch)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SignalFetchInformationMarshaller.Instance;
                    marshaller.Marshall(publicRequestSignalsToFetchListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSpoolingMode())
            {
                context.Writer.WritePropertyName("spoolingMode");
                context.Writer.WriteStringValue(publicRequest.SpoolingMode);
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetArn())
            {
                context.Writer.WritePropertyName("targetArn");
                context.Writer.WriteStringValue(publicRequest.TargetArn);
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
        private static CreateCampaignRequestMarshaller _instance = new CreateCampaignRequestMarshaller();        

        internal static CreateCampaignRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCampaignRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}