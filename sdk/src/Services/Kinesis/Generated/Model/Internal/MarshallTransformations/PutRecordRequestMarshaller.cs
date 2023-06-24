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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRecord Request Marshaller
    /// </summary>       
    public class PutRecordRequestMarshaller : IMarshaller<IRequest, PutRecordRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRecordRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRecordRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kinesis");
            string target = "Kinesis_20131202.PutRecord";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-12-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetData())
                {
                    context.Writer.WritePropertyName("Data");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.Data));
                }

                if(publicRequest.IsSetExplicitHashKey())
                {
                    context.Writer.WritePropertyName("ExplicitHashKey");
                    context.Writer.Write(publicRequest.ExplicitHashKey);
                }

                if(publicRequest.IsSetPartitionKey())
                {
                    context.Writer.WritePropertyName("PartitionKey");
                    context.Writer.Write(publicRequest.PartitionKey);
                }

                if(publicRequest.IsSetSequenceNumberForOrdering())
                {
                    context.Writer.WritePropertyName("SequenceNumberForOrdering");
                    context.Writer.Write(publicRequest.SequenceNumberForOrdering);
                }

                if(publicRequest.IsSetStreamARN())
                {
                    context.Writer.WritePropertyName("StreamARN");
                    context.Writer.Write(publicRequest.StreamARN);
                }

                if(publicRequest.IsSetStreamName())
                {
                    context.Writer.WritePropertyName("StreamName");
                    context.Writer.Write(publicRequest.StreamName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutRecordRequestMarshaller _instance = new PutRecordRequestMarshaller();        

        internal static PutRecordRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRecordRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}