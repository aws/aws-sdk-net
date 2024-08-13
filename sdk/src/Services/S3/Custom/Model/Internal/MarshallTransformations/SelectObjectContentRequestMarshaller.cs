// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Marshaller for the SelectObjectContent operation
    /// </summary>
    public class SelectObjectContentRequestMarshaller : IMarshaller<IRequest, AmazonWebServiceRequest>,
        IMarshaller<IRequest, SelectObjectContentRequest>
    {
        private static SelectObjectContentRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static SelectObjectContentRequestMarshaller Instance =>
            _instance ?? (_instance = new SelectObjectContentRequestMarshaller());

        /// <summary>
        /// Marshall the public request to the internal IRequest structure.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return Marshall((SelectObjectContentRequest) input);
        }

        /// <summary>
        /// Marshall the public request to the internal IRequest structure.
        /// </summary>
        /// <param name="selectObjectContentRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SelectObjectContentRequest selectObjectContentRequest)
        {
            // Required Parameters
            // Bucket
            if (string.IsNullOrEmpty(selectObjectContentRequest.BucketName))
                throw ConstructExceptionArgumentRequired(nameof(selectObjectContentRequest.BucketName));
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
                ResourcePath = "/{Key+}",
                UseQueryString = true,
            };
            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(selectObjectContentRequest.Key));

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

            if (selectObjectContentRequest.IsSetExpectedBucketOwner())
            {
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, 
                    S3Transforms.ToStringValue(selectObjectContentRequest.ExpectedBucketOwner));
            }

            // Subresources
            request.AddSubResource("select");
            request.AddSubResource("select-type", "2");

            // Parameters
            using (var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture))
            {
                var xmlWriterSettings = new XmlWriterSettings()
                {
                    Encoding = Encoding.UTF8,
                    OmitXmlDeclaration = true,
                    NewLineHandling = NewLineHandling.Entitize
                };
                using (var xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings))
                {
                    xmlWriter.WriteStartElement("SelectObjectContentRequest", S3Constants.S3RequestXmlNamespace);
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
                    xmlWriter.WriteEndElement();
                    if (selectObjectContentRequest.IsSetScanRange())
                    {
                        selectObjectContentRequest.ScanRange.Marshall("ScanRange", xmlWriter);
                    }
                    xmlWriter.WriteEndElement();
                }

                try
                {
                    var content = stringWriter.ToString();
                    request.Content = Encoding.UTF8.GetBytes(content);
                    request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                    ChecksumUtils.SetChecksumData(request);
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