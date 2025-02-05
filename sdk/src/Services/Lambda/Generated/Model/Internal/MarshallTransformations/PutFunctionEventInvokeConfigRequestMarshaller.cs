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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
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
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutFunctionEventInvokeConfig Request Marshaller
    /// </summary>       
    public class PutFunctionEventInvokeConfigRequestMarshaller : IMarshaller<IRequest, PutFunctionEventInvokeConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutFunctionEventInvokeConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutFunctionEventInvokeConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFunctionName())
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));
            
            if (publicRequest.IsSetQualifier())
                request.Parameters.Add("Qualifier", StringUtils.FromString(publicRequest.Qualifier));
            request.ResourcePath = "/2019-09-25/functions/{FunctionName}/event-invoke-config";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDestinationConfig())
            {
                context.Writer.WritePropertyName("DestinationConfig");
                context.Writer.WriteStartObject();

                var marshaller = DestinationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaximumEventAgeInSeconds())
            {
                context.Writer.WritePropertyName("MaximumEventAgeInSeconds");
                context.Writer.WriteNumberValue(publicRequest.MaximumEventAgeInSeconds.Value);
            }

            if(publicRequest.IsSetMaximumRetryAttempts())
            {
                context.Writer.WritePropertyName("MaximumRetryAttempts");
                context.Writer.WriteNumberValue(publicRequest.MaximumRetryAttempts.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static PutFunctionEventInvokeConfigRequestMarshaller _instance = new PutFunctionEventInvokeConfigRequestMarshaller();        

        internal static PutFunctionEventInvokeConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutFunctionEventInvokeConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}