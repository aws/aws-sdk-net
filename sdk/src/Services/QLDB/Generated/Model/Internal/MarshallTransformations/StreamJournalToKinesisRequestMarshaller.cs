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
using ThirdParty.Json.LitJson;

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
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExclusiveEndTime())
                {
                    context.Writer.WritePropertyName("ExclusiveEndTime");
                    context.Writer.Write(publicRequest.ExclusiveEndTime);
                }

                if(publicRequest.IsSetInclusiveStartTime())
                {
                    context.Writer.WritePropertyName("InclusiveStartTime");
                    context.Writer.Write(publicRequest.InclusiveStartTime);
                }

                if(publicRequest.IsSetKinesisConfiguration())
                {
                    context.Writer.WritePropertyName("KinesisConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = KinesisConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KinesisConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStreamName())
                {
                    context.Writer.WritePropertyName("StreamName");
                    context.Writer.Write(publicRequest.StreamName);
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

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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