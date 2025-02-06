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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
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
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateThemeForStack Request Marshaller
    /// </summary>       
    public class CreateThemeForStackRequestMarshaller : IMarshaller<IRequest, CreateThemeForStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateThemeForStackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateThemeForStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateThemeForStack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
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
            if(publicRequest.IsSetFaviconS3Location())
            {
                context.Writer.WritePropertyName("FaviconS3Location");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.FaviconS3Location, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFooterLinks())
            {
                context.Writer.WritePropertyName("FooterLinks");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFooterLinksListValue in publicRequest.FooterLinks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ThemeFooterLinkMarshaller.Instance;
                    marshaller.Marshall(publicRequestFooterLinksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOrganizationLogoS3Location())
            {
                context.Writer.WritePropertyName("OrganizationLogoS3Location");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OrganizationLogoS3Location, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStackName())
            {
                context.Writer.WritePropertyName("StackName");
                context.Writer.WriteStringValue(publicRequest.StackName);
            }

            if(publicRequest.IsSetThemeStyling())
            {
                context.Writer.WritePropertyName("ThemeStyling");
                context.Writer.WriteStringValue(publicRequest.ThemeStyling);
            }

            if(publicRequest.IsSetTitleText())
            {
                context.Writer.WritePropertyName("TitleText");
                context.Writer.WriteStringValue(publicRequest.TitleText);
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
        private static CreateThemeForStackRequestMarshaller _instance = new CreateThemeForStackRequestMarshaller();        

        internal static CreateThemeForStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateThemeForStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}