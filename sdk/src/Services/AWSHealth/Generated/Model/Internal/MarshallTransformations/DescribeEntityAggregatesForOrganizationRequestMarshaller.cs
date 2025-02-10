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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSHealth.Model;
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
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEntityAggregatesForOrganization Request Marshaller
    /// </summary>       
    public class DescribeEntityAggregatesForOrganizationRequestMarshaller : IMarshaller<IRequest, DescribeEntityAggregatesForOrganizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeEntityAggregatesForOrganizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeEntityAggregatesForOrganizationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSHealth");
            string target = "AWSHealth_20160804.DescribeEntityAggregatesForOrganization";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-04";
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
            if(publicRequest.IsSetAwsAccountIds())
            {
                context.Writer.WritePropertyName("awsAccountIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAwsAccountIdsListValue in publicRequest.AwsAccountIds)
                {
                        context.Writer.WriteStringValue(publicRequestAwsAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEventArns())
            {
                context.Writer.WritePropertyName("eventArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEventArnsListValue in publicRequest.EventArns)
                {
                        context.Writer.WriteStringValue(publicRequestEventArnsListValue);
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
        private static DescribeEntityAggregatesForOrganizationRequestMarshaller _instance = new DescribeEntityAggregatesForOrganizationRequestMarshaller();        

        internal static DescribeEntityAggregatesForOrganizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeEntityAggregatesForOrganizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}