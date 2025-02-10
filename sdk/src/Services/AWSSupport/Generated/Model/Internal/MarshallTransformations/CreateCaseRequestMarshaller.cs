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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
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
namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCase Request Marshaller
    /// </summary>       
    public class CreateCaseRequestMarshaller : IMarshaller<IRequest, CreateCaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSSupport");
            string target = "AWSSupport_20130415.CreateCase";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-15";
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
            if(publicRequest.IsSetAttachmentSetId())
            {
                context.Writer.WritePropertyName("attachmentSetId");
                context.Writer.WriteStringValue(publicRequest.AttachmentSetId);
            }

            if(publicRequest.IsSetCategoryCode())
            {
                context.Writer.WritePropertyName("categoryCode");
                context.Writer.WriteStringValue(publicRequest.CategoryCode);
            }

            if(publicRequest.IsSetCcEmailAddresses())
            {
                context.Writer.WritePropertyName("ccEmailAddresses");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCcEmailAddressesListValue in publicRequest.CcEmailAddresses)
                {
                        context.Writer.WriteStringValue(publicRequestCcEmailAddressesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCommunicationBody())
            {
                context.Writer.WritePropertyName("communicationBody");
                context.Writer.WriteStringValue(publicRequest.CommunicationBody);
            }

            if(publicRequest.IsSetIssueType())
            {
                context.Writer.WritePropertyName("issueType");
                context.Writer.WriteStringValue(publicRequest.IssueType);
            }

            if(publicRequest.IsSetLanguage())
            {
                context.Writer.WritePropertyName("language");
                context.Writer.WriteStringValue(publicRequest.Language);
            }

            if(publicRequest.IsSetServiceCode())
            {
                context.Writer.WritePropertyName("serviceCode");
                context.Writer.WriteStringValue(publicRequest.ServiceCode);
            }

            if(publicRequest.IsSetSeverityCode())
            {
                context.Writer.WritePropertyName("severityCode");
                context.Writer.WriteStringValue(publicRequest.SeverityCode);
            }

            if(publicRequest.IsSetSubject())
            {
                context.Writer.WritePropertyName("subject");
                context.Writer.WriteStringValue(publicRequest.Subject);
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
        private static CreateCaseRequestMarshaller _instance = new CreateCaseRequestMarshaller();        

        internal static CreateCaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}