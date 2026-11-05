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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.AppStream.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateThemeForStack Request Marshaller
    /// </summary>
    public partial class CreateThemeForStackRequestMarshaller : IMarshaller<IRequest, CreateThemeForStackRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateThemeForStackRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateThemeForStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/PhotonAdminProxyService/operation/CreateThemeForStack";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetFaviconS3Location())
                {
                    context.Writer.WriteTextString("FaviconS3Location");
                    context.Writer.WriteStartMap(null);

                    var marshaller = S3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FaviconS3Location, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetFooterLinks())
                {
                    context.Writer.WriteTextString("FooterLinks");
                    context.Writer.WriteStartArray(publicRequest.FooterLinks.Count);
                    foreach (var publicRequestFooterLinksListValue in publicRequest.FooterLinks)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ThemeFooterLinkMarshaller.Instance;
                        marshaller.Marshall(publicRequestFooterLinksListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetOrganizationLogoS3Location())
                {
                    context.Writer.WriteTextString("OrganizationLogoS3Location");
                    context.Writer.WriteStartMap(null);

                    var marshaller = S3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OrganizationLogoS3Location, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStackName())
                {
                    context.Writer.WriteTextString("StackName");
                    context.Writer.WriteTextString(publicRequest.StackName);
                }
                if (publicRequest.IsSetThemeStyling())
                {
                    context.Writer.WriteTextString("ThemeStyling");
                    context.Writer.WriteTextString(publicRequest.ThemeStyling);
                }
                if (publicRequest.IsSetTitleText())
                {
                    context.Writer.WriteTextString("TitleText");
                    context.Writer.WriteTextString(publicRequest.TitleText);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly CreateThemeForStackRequestMarshaller _instance = new();

        internal static CreateThemeForStackRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateThemeForStackRequestMarshaller Instance => _instance;
    }
}
