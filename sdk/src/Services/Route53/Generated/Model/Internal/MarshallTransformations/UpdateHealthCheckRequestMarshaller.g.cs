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

using Amazon.Route53.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateHealthCheck Request Marshaller
    /// </summary>
    public partial class UpdateHealthCheckRequestMarshaller : IMarshaller<IRequest, UpdateHealthCheckRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateHealthCheckRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateHealthCheckRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetHealthCheckId())
            {
                throw new AmazonRoute53Exception("Request object does not have required field HealthCheckId set");
            }
            request.AddPathResource("{HealthCheckId}", StringUtils.FromString(publicRequest.HealthCheckId));

            request.ResourcePath = "/2013-04-01/healthcheck/{HealthCheckId}";

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
                context.Writer.WriteStartElement("UpdateHealthCheckRequest", "https://route53.amazonaws.com/doc/2013-04-01/");
                if (publicRequest.IsSetHealthCheckVersion())
                {
                    context.Writer.WriteElementString("HealthCheckVersion", StringUtils.FromLong(publicRequest.HealthCheckVersion.Value));
                }
                if (publicRequest.IsSetIPAddress())
                {
                    context.Writer.WriteElementString("IPAddress", StringUtils.FromString(publicRequest.IPAddress));
                }
                if (publicRequest.IsSetPort())
                {
                    context.Writer.WriteElementString("Port", StringUtils.FromInt(publicRequest.Port.Value));
                }
                if (publicRequest.IsSetResourcePath())
                {
                    context.Writer.WriteElementString("ResourcePath", StringUtils.FromString(publicRequest.ResourcePath));
                }
                if (publicRequest.IsSetFullyQualifiedDomainName())
                {
                    context.Writer.WriteElementString("FullyQualifiedDomainName", StringUtils.FromString(publicRequest.FullyQualifiedDomainName));
                }
                if (publicRequest.IsSetSearchString())
                {
                    context.Writer.WriteElementString("SearchString", StringUtils.FromString(publicRequest.SearchString));
                }
                if (publicRequest.IsSetFailureThreshold())
                {
                    context.Writer.WriteElementString("FailureThreshold", StringUtils.FromInt(publicRequest.FailureThreshold.Value));
                }
                if (publicRequest.IsSetInverted())
                {
                    context.Writer.WriteElementString("Inverted", StringUtils.FromBool(publicRequest.Inverted.Value));
                }
                if (publicRequest.IsSetDisabled())
                {
                    context.Writer.WriteElementString("Disabled", StringUtils.FromBool(publicRequest.Disabled.Value));
                }
                if (publicRequest.IsSetHealthThreshold())
                {
                    context.Writer.WriteElementString("HealthThreshold", StringUtils.FromInt(publicRequest.HealthThreshold.Value));
                }
                if (publicRequest.IsSetChildHealthChecks())
                {
                    var publicRequestChildHealthChecks = publicRequest.ChildHealthChecks;
                    context.Writer.WriteStartElement("ChildHealthChecks");
                    foreach (var publicRequestChildHealthChecksValue in publicRequestChildHealthChecks)
                    {
                        context.Writer.WriteStartElement("ChildHealthCheck");
                        context.Writer.WriteValue(publicRequestChildHealthChecksValue);
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetEnableSNI())
                {
                    context.Writer.WriteElementString("EnableSNI", StringUtils.FromBool(publicRequest.EnableSNI.Value));
                }
                if (publicRequest.IsSetRegions())
                {
                    var publicRequestRegions = publicRequest.Regions;
                    context.Writer.WriteStartElement("Regions");
                    foreach (var publicRequestRegionsValue in publicRequestRegions)
                    {
                        context.Writer.WriteStartElement("Region");
                        context.Writer.WriteValue(publicRequestRegionsValue);
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetAlarmIdentifier())
                {
                    context.Writer.WriteStartElement("AlarmIdentifier");
                    AlarmIdentifierMarshaller.Instance.Marshall(publicRequest.AlarmIdentifier, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetInsufficientDataHealthStatus())
                {
                    context.Writer.WriteElementString("InsufficientDataHealthStatus", StringUtils.FromString(publicRequest.InsufficientDataHealthStatus));
                }
                if (publicRequest.IsSetResetElements())
                {
                    var publicRequestResetElements = publicRequest.ResetElements;
                    context.Writer.WriteStartElement("ResetElements");
                    foreach (var publicRequestResetElementsValue in publicRequestResetElements)
                    {
                        context.Writer.WriteStartElement("ResettableElementName");
                        context.Writer.WriteValue(publicRequestResetElementsValue);
                        context.Writer.WriteEndElement();
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-01";
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly UpdateHealthCheckRequestMarshaller _instance = new();

        internal static UpdateHealthCheckRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateHealthCheckRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateHealthCheckRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UpdateHealthCheckRequest publicRequest);
    }
}
