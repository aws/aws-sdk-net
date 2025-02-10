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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
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
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutOrganizationConformancePack Request Marshaller
    /// </summary>       
    public class PutOrganizationConformancePackRequestMarshaller : IMarshaller<IRequest, PutOrganizationConformancePackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutOrganizationConformancePackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutOrganizationConformancePackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConfigService");
            string target = "StarlingDoveService.PutOrganizationConformancePack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-12";
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
            if(publicRequest.IsSetConformancePackInputParameters())
            {
                context.Writer.WritePropertyName("ConformancePackInputParameters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestConformancePackInputParametersListValue in publicRequest.ConformancePackInputParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConformancePackInputParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestConformancePackInputParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeliveryS3Bucket())
            {
                context.Writer.WritePropertyName("DeliveryS3Bucket");
                context.Writer.WriteStringValue(publicRequest.DeliveryS3Bucket);
            }

            if(publicRequest.IsSetDeliveryS3KeyPrefix())
            {
                context.Writer.WritePropertyName("DeliveryS3KeyPrefix");
                context.Writer.WriteStringValue(publicRequest.DeliveryS3KeyPrefix);
            }

            if(publicRequest.IsSetExcludedAccounts())
            {
                context.Writer.WritePropertyName("ExcludedAccounts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestExcludedAccountsListValue in publicRequest.ExcludedAccounts)
                {
                        context.Writer.WriteStringValue(publicRequestExcludedAccountsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOrganizationConformancePackName())
            {
                context.Writer.WritePropertyName("OrganizationConformancePackName");
                context.Writer.WriteStringValue(publicRequest.OrganizationConformancePackName);
            }

            if(publicRequest.IsSetTemplateBody())
            {
                context.Writer.WritePropertyName("TemplateBody");
                context.Writer.WriteStringValue(publicRequest.TemplateBody);
            }

            if(publicRequest.IsSetTemplateS3Uri())
            {
                context.Writer.WritePropertyName("TemplateS3Uri");
                context.Writer.WriteStringValue(publicRequest.TemplateS3Uri);
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
        private static PutOrganizationConformancePackRequestMarshaller _instance = new PutOrganizationConformancePackRequestMarshaller();        

        internal static PutOrganizationConformancePackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutOrganizationConformancePackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}