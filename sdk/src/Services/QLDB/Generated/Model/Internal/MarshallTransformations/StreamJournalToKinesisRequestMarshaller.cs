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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QLDB.Model;
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
namespace Amazon.QLDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamJournalToKinesis Request Marshaller
    /// </summary>       
    public class StreamJournalToKinesisRequestMarshaller : IMarshaller<IRequest, StreamJournalToKinesisRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StreamJournalToKinesisRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StreamJournalToKinesisRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QLDB");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-01-02";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetLedgerName())
                throw new AmazonQLDBException("Request object does not have required field LedgerName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.LedgerName));
            request.ResourcePath = "/ledgers/{name}/journal-kinesis-streams";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetExclusiveEndTime())
            {
                context.Writer.WritePropertyName("ExclusiveEndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ExclusiveEndTime.Value)));
            }

            if(publicRequest.IsSetInclusiveStartTime())
            {
                context.Writer.WritePropertyName("InclusiveStartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.InclusiveStartTime.Value)));
            }

            if(publicRequest.IsSetKinesisConfiguration())
            {
                context.Writer.WritePropertyName("KinesisConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KinesisConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KinesisConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetStreamName())
            {
                context.Writer.WritePropertyName("StreamName");
                context.Writer.WriteStringValue(publicRequest.StreamName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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
        private static StreamJournalToKinesisRequestMarshaller _instance = new StreamJournalToKinesisRequestMarshaller();        

        internal static StreamJournalToKinesisRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StreamJournalToKinesisRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}