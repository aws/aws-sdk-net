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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDistributionTenant Request Marshaller
    /// </summary>
    public partial class UpdateDistributionTenantRequestMarshaller : IMarshaller<IRequest, UpdateDistributionTenantRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDistributionTenantRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDistributionTenantRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";

            if (publicRequest.IsSetIfMatch())
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }

            if (!publicRequest.IsSetId())
            {
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            }
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));

            request.ResourcePath = "/2020-05-31/distribution-tenant/{Id}";

#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            var bufferTextWriter = new XMLEncodedBufferTextWriter(((PooledContentStream)request.ContentStream).BufferWriter);
            using (var xmlWriter = XmlWriter.Create(bufferTextWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#else
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#endif
                var context = new XmlMarshallerContext(request, xmlWriter);
                context.Writer.WriteStartElement("UpdateDistributionTenantRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                if (publicRequest.IsSetConnectionGroupId())
                {
                    context.Writer.WriteElementString("ConnectionGroupId", StringUtils.FromString(publicRequest.ConnectionGroupId));
                }
                if (publicRequest.IsSetCustomizations())
                {
                    context.Writer.WriteStartElement("Customizations");
                    CustomizationsMarshaller.Instance.Marshall(publicRequest.Customizations, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetDistributionId())
                {
                    context.Writer.WriteElementString("DistributionId", StringUtils.FromString(publicRequest.DistributionId));
                }
                if (publicRequest.IsSetDomains())
                {
                    var publicRequestDomains = publicRequest.Domains;
                    context.Writer.WriteStartElement("Domains");
                    foreach (var publicRequestDomainsValue in publicRequestDomains)
                    {
                        if (publicRequestDomainsValue != null)
                        {
                            context.Writer.WriteStartElement("member");
                            DomainItemMarshaller.Instance.Marshall(publicRequestDomainsValue, context);
                            context.Writer.WriteEndElement();
                        }
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetEnabled())
                {
                    context.Writer.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.Enabled.Value));
                }
                if (publicRequest.IsSetManagedCertificateRequest())
                {
                    context.Writer.WriteStartElement("ManagedCertificateRequest");
                    ManagedCertificateRequestMarshaller.Instance.Marshall(publicRequest.ManagedCertificateRequest, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetParameters())
                {
                    var publicRequestParameters = publicRequest.Parameters;
                    context.Writer.WriteStartElement("Parameters");
                    foreach (var publicRequestParametersValue in publicRequestParameters)
                    {
                        if (publicRequestParametersValue != null)
                        {
                            context.Writer.WriteStartElement("member");
                            ParameterMarshaller.Instance.Marshall(publicRequestParametersValue, context);
                            context.Writer.WriteEndElement();
                        }
                    }
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            try
            {
#if NETFRAMEWORK
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
#endif
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly UpdateDistributionTenantRequestMarshaller _instance = new();

        internal static UpdateDistributionTenantRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDistributionTenantRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateDistributionTenantRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UpdateDistributionTenantRequest publicRequest);
    }
}
