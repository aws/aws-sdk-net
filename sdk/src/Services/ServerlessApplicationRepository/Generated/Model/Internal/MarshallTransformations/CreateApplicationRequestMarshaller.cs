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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerlessApplicationRepository.Model;
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
namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplication Request Marshaller
    /// </summary>       
    public class CreateApplicationRequestMarshaller : IMarshaller<IRequest, CreateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServerlessApplicationRepository");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/applications";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthor())
            {
                context.Writer.WritePropertyName("author");
                context.Writer.WriteStringValue(publicRequest.Author);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetHomePageUrl())
            {
                context.Writer.WritePropertyName("homePageUrl");
                context.Writer.WriteStringValue(publicRequest.HomePageUrl);
            }

            if(publicRequest.IsSetLabels())
            {
                context.Writer.WritePropertyName("labels");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLabelsListValue in publicRequest.Labels)
                {
                        context.Writer.WriteStringValue(publicRequestLabelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLicenseBody())
            {
                context.Writer.WritePropertyName("licenseBody");
                context.Writer.WriteStringValue(publicRequest.LicenseBody);
            }

            if(publicRequest.IsSetLicenseUrl())
            {
                context.Writer.WritePropertyName("licenseUrl");
                context.Writer.WriteStringValue(publicRequest.LicenseUrl);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetReadmeBody())
            {
                context.Writer.WritePropertyName("readmeBody");
                context.Writer.WriteStringValue(publicRequest.ReadmeBody);
            }

            if(publicRequest.IsSetReadmeUrl())
            {
                context.Writer.WritePropertyName("readmeUrl");
                context.Writer.WriteStringValue(publicRequest.ReadmeUrl);
            }

            if(publicRequest.IsSetSemanticVersion())
            {
                context.Writer.WritePropertyName("semanticVersion");
                context.Writer.WriteStringValue(publicRequest.SemanticVersion);
            }

            if(publicRequest.IsSetSourceCodeArchiveUrl())
            {
                context.Writer.WritePropertyName("sourceCodeArchiveUrl");
                context.Writer.WriteStringValue(publicRequest.SourceCodeArchiveUrl);
            }

            if(publicRequest.IsSetSourceCodeUrl())
            {
                context.Writer.WritePropertyName("sourceCodeUrl");
                context.Writer.WriteStringValue(publicRequest.SourceCodeUrl);
            }

            if(publicRequest.IsSetSpdxLicenseId())
            {
                context.Writer.WritePropertyName("spdxLicenseId");
                context.Writer.WriteStringValue(publicRequest.SpdxLicenseId);
            }

            if(publicRequest.IsSetTemplateBody())
            {
                context.Writer.WritePropertyName("templateBody");
                context.Writer.WriteStringValue(publicRequest.TemplateBody);
            }

            if(publicRequest.IsSetTemplateUrl())
            {
                context.Writer.WritePropertyName("templateUrl");
                context.Writer.WriteStringValue(publicRequest.TemplateUrl);
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
        private static CreateApplicationRequestMarshaller _instance = new CreateApplicationRequestMarshaller();        

        internal static CreateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}