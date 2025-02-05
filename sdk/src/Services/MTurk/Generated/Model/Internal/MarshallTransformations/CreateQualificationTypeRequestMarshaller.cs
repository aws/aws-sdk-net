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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MTurk.Model;
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
namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateQualificationType Request Marshaller
    /// </summary>       
    public class CreateQualificationTypeRequestMarshaller : IMarshaller<IRequest, CreateQualificationTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateQualificationTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateQualificationTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MTurk");
            string target = "MTurkRequesterServiceV20170117.CreateQualificationType";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-17";
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
            if(publicRequest.IsSetAnswerKey())
            {
                context.Writer.WritePropertyName("AnswerKey");
                context.Writer.WriteStringValue(publicRequest.AnswerKey);
            }

            if(publicRequest.IsSetAutoGranted())
            {
                context.Writer.WritePropertyName("AutoGranted");
                context.Writer.WriteBooleanValue(publicRequest.AutoGranted.Value);
            }

            if(publicRequest.IsSetAutoGrantedValue())
            {
                context.Writer.WritePropertyName("AutoGrantedValue");
                context.Writer.WriteNumberValue(publicRequest.AutoGrantedValue.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetKeywords())
            {
                context.Writer.WritePropertyName("Keywords");
                context.Writer.WriteStringValue(publicRequest.Keywords);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetQualificationTypeStatus())
            {
                context.Writer.WritePropertyName("QualificationTypeStatus");
                context.Writer.WriteStringValue(publicRequest.QualificationTypeStatus);
            }

            if(publicRequest.IsSetRetryDelayInSeconds())
            {
                context.Writer.WritePropertyName("RetryDelayInSeconds");
                context.Writer.WriteNumberValue(publicRequest.RetryDelayInSeconds.Value);
            }

            if(publicRequest.IsSetTest())
            {
                context.Writer.WritePropertyName("Test");
                context.Writer.WriteStringValue(publicRequest.Test);
            }

            if(publicRequest.IsSetTestDurationInSeconds())
            {
                context.Writer.WritePropertyName("TestDurationInSeconds");
                context.Writer.WriteNumberValue(publicRequest.TestDurationInSeconds.Value);
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
        private static CreateQualificationTypeRequestMarshaller _instance = new CreateQualificationTypeRequestMarshaller();        

        internal static CreateQualificationTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateQualificationTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}