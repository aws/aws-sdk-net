// /*******************************************************************************
//  *  Copyright 2008-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class SelectObjectContentRequestMarshaller : IMarshaller<IRequest, AmazonWebServiceRequest>,
        IMarshaller<IRequest, SelectObjectContentRequest>
    {
        private static SelectObjectContentRequestMarshaller _instance;

        public static SelectObjectContentRequestMarshaller Instance =>
            _instance ?? (_instance = new SelectObjectContentRequestMarshaller());

        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return Marshall((SelectObjectContentRequest) input);
        }

        public IRequest Marshall(SelectObjectContentRequest selectObjectContentRequest)
        {
            // Required Parameters
            // Bucket
            if (string.IsNullOrEmpty(selectObjectContentRequest.Bucket))
                throw ConstructExceptionArgumentRequired(nameof(selectObjectContentRequest.Bucket));
            // Key
            if (string.IsNullOrEmpty(selectObjectContentRequest.Key))
                throw ConstructExceptionArgumentRequired(nameof(selectObjectContentRequest.Key));
            // Expression
            if (string.IsNullOrEmpty(selectObjectContentRequest.Expression))
                throw ConstructExceptionArgumentRequired(nameof(selectObjectContentRequest.Expression));
            // ExpressionType
            if (!selectObjectContentRequest.IsSetExpressionType())
                throw ConstructExceptionArgumentRequired(nameof(selectObjectContentRequest.ExpressionType));
            // InputSerialization
            if (!selectObjectContentRequest.IsSetInputSerialization())
                throw ConstructExceptionArgumentRequired(nameof(selectObjectContentRequest.InputSerialization));
            // OutputSerialization
            if (!selectObjectContentRequest.IsSetOutputSerialization())
                throw ConstructExceptionArgumentRequired(nameof(selectObjectContentRequest.OutputSerialization));

            var request = new DefaultRequest(selectObjectContentRequest, "AmazonS3")
            {
                HttpMethod = "POST",
                ResourcePath =
                    string.Format(CultureInfo.InvariantCulture, "/{0}/{1}", S3Transforms.ToStringValue(selectObjectContentRequest.Bucket), S3Transforms.ToStringValue(selectObjectContentRequest.Key)),
                UseQueryString = true,
            };

            // Headers
            if (selectObjectContentRequest.IsSetServerSideCustomerEncryptionMethod())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader,
                    selectObjectContentRequest.ServerSideCustomerEncryptionMethod);
            }

            if (selectObjectContentRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader,
                    selectObjectContentRequest.ServerSideEncryptionCustomerProvidedKey);
                if (selectObjectContentRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                {
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header,
                        selectObjectContentRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                }
                else
                {
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header,
                        AmazonS3Util.ComputeEncodedMD5FromEncodedString(selectObjectContentRequest
                            .ServerSideEncryptionCustomerProvidedKey));
                }
            }

            // Subresources
            request.AddSubResource("select");
            request.AddSubResource("select-type", "2");

            // Parameters
            using (var stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                var xmlWriterSettings = new XmlWriterSettings()
                {
                    Encoding = Encoding.UTF8,
                    OmitXmlDeclaration = true
                };
                using (var xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings))
                {
                    xmlWriter.WriteStartElement("SelectRequest");
                    xmlWriter.WriteElementString("Expression",
                        S3Transforms.ToXmlStringValue(selectObjectContentRequest.Expression));
                    xmlWriter.WriteElementString("ExpressionType",
                        S3Transforms.ToXmlStringValue(selectObjectContentRequest.ExpressionType.Value));
                    selectObjectContentRequest.InputSerialization.Marshall("InputSerialization", xmlWriter);
                    selectObjectContentRequest.OutputSerialization.Marshall("OutputSerialization", xmlWriter);
                    xmlWriter.WriteStartElement("RequestProgress");
                    xmlWriter.WriteElementString("Enabled",
                        selectObjectContentRequest.RequestProgress.GetValueOrDefault(false).ToString()
                            .ToUpperInvariant());
                    if (selectObjectContentRequest.IsSetScanRange())
                    {
                        selectObjectContentRequest.ScanRange.Marshall("ScanRange", xmlWriter);
                    }
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                }

                try
                {
                    var content = stringWriter.ToString();
                    request.Content = Encoding.UTF8.GetBytes(content);
                    request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                    var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                    request.Headers[HeaderKeys.ContentMD5Header] = checksum;
                }
                catch (EncoderFallbackException e)
                {
                    throw new AmazonServiceException("Unable to marshall request to XML", e);
                }
            }

            return request;
        }

        private static ArgumentException ConstructExceptionArgumentRequired(string parameterName)
        {
            return new ArgumentException(
                string.Format(CultureInfo.InvariantCulture,
                    "{0}  is a required property and must be set before making this call.", parameterName),
                string.Format(CultureInfo.InvariantCulture, "{0}.{1}", nameof(SelectObjectContentRequest), parameterName));
        }
    }
}