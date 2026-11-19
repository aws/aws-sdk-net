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
    /// PutMultiRegionAccessPointPolicy Request Marshaller
    /// </summary>
    public partial class PutMultiRegionAccessPointPolicyRequestMarshaller : IMarshaller<IRequest, PutMultiRegionAccessPointPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMultiRegionAccessPointPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutMultiRegionAccessPointPolicyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAccountId())
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }

            request.ResourcePath = "/v20180820/async-requests/mrap/put-policy";

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
                context.Writer.WriteStartElement("PutMultiRegionAccessPointPolicyRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteElementString("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else
                {
                    context.Writer.WriteElementString("ClientToken", Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetDetails())
                {
                    context.Writer.WriteStartElement("Details");
                    PutMultiRegionAccessPointPolicyInputMarshaller.Instance.Marshall(publicRequest.Details, context);
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

            ChecksumUtils.SetChecksumData(request);
            return request;
        }

        private static readonly PutMultiRegionAccessPointPolicyRequestMarshaller _instance = new();

        internal static PutMultiRegionAccessPointPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutMultiRegionAccessPointPolicyRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutMultiRegionAccessPointPolicyRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutMultiRegionAccessPointPolicyRequest publicRequest);
    }
}
