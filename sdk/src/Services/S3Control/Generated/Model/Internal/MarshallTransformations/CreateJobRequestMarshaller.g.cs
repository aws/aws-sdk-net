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

using Amazon.S3Control.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>
    public partial class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAccountId())
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }

            request.ResourcePath = "/v20180820/jobs";

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
                context.Writer.WriteStartElement("CreateJobRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                if (publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WriteElementString("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
                }
                else
                {
                    context.Writer.WriteElementString("ClientRequestToken", Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetConfirmationRequired())
                {
                    context.Writer.WriteElementString("ConfirmationRequired", StringUtils.FromBool(publicRequest.ConfirmationRequired.Value));
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteElementString("Description", StringUtils.FromString(publicRequest.Description));
                }
                if (publicRequest.IsSetManifest())
                {
                    context.Writer.WriteStartElement("Manifest");
                    JobManifestMarshaller.Instance.Marshall(publicRequest.Manifest, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetManifestGenerator())
                {
                    context.Writer.WriteStartElement("ManifestGenerator");
                    JobManifestGeneratorMarshaller.Instance.Marshall(publicRequest.ManifestGenerator, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetOperation())
                {
                    context.Writer.WriteStartElement("Operation");
                    JobOperationMarshaller.Instance.Marshall(publicRequest.Operation, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetPriority())
                {
                    context.Writer.WriteElementString("Priority", StringUtils.FromInt(publicRequest.Priority.Value));
                }
                if (publicRequest.IsSetReport())
                {
                    context.Writer.WriteStartElement("Report");
                    JobReportMarshaller.Instance.Marshall(publicRequest.Report, context);
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetRoleArn())
                {
                    context.Writer.WriteElementString("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
                }
                if (publicRequest.IsSetTags())
                {
                    var publicRequestTags = publicRequest.Tags;
                    context.Writer.WriteStartElement("Tags");
                    foreach (var publicRequestTagsValue in publicRequestTags)
                    {
                        if (publicRequestTagsValue != null)
                        {
                            context.Writer.WriteStartElement("member");
                            S3TagMarshaller.Instance.Marshall(publicRequestTagsValue, context);
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly CreateJobRequestMarshaller _instance = new();

        internal static CreateJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateJobRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateJobRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, CreateJobRequest publicRequest);
    }
}
