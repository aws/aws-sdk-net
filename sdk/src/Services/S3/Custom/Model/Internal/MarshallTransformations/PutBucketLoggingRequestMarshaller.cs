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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Enable Bucket Logging Request Marshaller
    /// </summary>       
    public class PutBucketLoggingRequestMarshaller : IMarshaller<IRequest, PutBucketLoggingRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutBucketLoggingRequest)input);
		}

        public IRequest Marshall(PutBucketLoggingRequest putBucketLoggingRequest)
        {
            IRequest request = new DefaultRequest(putBucketLoggingRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putBucketLoggingRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putBucketLoggingRequest.ChecksumAlgorithm));

            if (putBucketLoggingRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putBucketLoggingRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(putBucketLoggingRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketLoggingRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("logging");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);

            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                xmlWriter.WriteStartElement("BucketLoggingStatus", S3Constants.S3RequestXmlNamespace);
                var bucketLoggingStatusBucketLoggingStatus = putBucketLoggingRequest.LoggingConfig;
                if (bucketLoggingStatusBucketLoggingStatus != null)
                {
                    if (bucketLoggingStatusBucketLoggingStatus != null)
                    {
                        var loggingEnabledLoggingEnabled = bucketLoggingStatusBucketLoggingStatus;
                        if (loggingEnabledLoggingEnabled != null && loggingEnabledLoggingEnabled.IsSetTargetBucket())
                        {
                            xmlWriter.WriteStartElement("LoggingEnabled");
                            xmlWriter.WriteElementString("TargetBucket", S3Transforms.ToXmlStringValue(loggingEnabledLoggingEnabled.TargetBucketName));

                            var loggingEnabledLoggingEnabledtargetGrantsList = loggingEnabledLoggingEnabled.Grants;
                            if (loggingEnabledLoggingEnabledtargetGrantsList != null && loggingEnabledLoggingEnabledtargetGrantsList.Count > 0)
                            {
                                xmlWriter.WriteStartElement("TargetGrants");
                                foreach (var loggingEnabledLoggingEnabledtargetGrantsListValue in loggingEnabledLoggingEnabledtargetGrantsList)
                                {
                                    xmlWriter.WriteStartElement("Grant");
                                    if (loggingEnabledLoggingEnabledtargetGrantsListValue != null)
                                    {
                                        var granteeGrantee = loggingEnabledLoggingEnabledtargetGrantsListValue.Grantee;
                                        if (granteeGrantee != null)
                                        {
                                            xmlWriter.WriteStartElement("xsi","Grantee", "http://www.w3.org/2001/XMLSchema-instance");
                                            if (granteeGrantee.IsSetType())
                                            {
                                                xmlWriter.WriteAttributeString("xsi", "type", "http://www.w3.org/2001/XMLSchema-instance", granteeGrantee.Type.ToString());
                                            }
                                            if (granteeGrantee.IsSetDisplayName())
                                            {
                                                xmlWriter.WriteElementString("DisplayName", S3Transforms.ToXmlStringValue(granteeGrantee.DisplayName));
                                            }
                                            if (granteeGrantee.IsSetEmailAddress())
                                            {
                                                xmlWriter.WriteElementString("EmailAddress", S3Transforms.ToXmlStringValue(granteeGrantee.EmailAddress));
                                            }
                                            if (granteeGrantee.IsSetCanonicalUser())
                                            {
                                                xmlWriter.WriteElementString("ID", S3Transforms.ToXmlStringValue(granteeGrantee.CanonicalUser));
                                            }
                                            if (granteeGrantee.IsSetURI())
                                            {
                                                xmlWriter.WriteElementString("URI", S3Transforms.ToXmlStringValue(granteeGrantee.URI));
                                            }
                                            xmlWriter.WriteEndElement();
                                        }

                                        if (loggingEnabledLoggingEnabledtargetGrantsListValue.IsSetPermission())
                                        {
                                            xmlWriter.WriteElementString("Permission", S3Transforms.ToXmlStringValue(loggingEnabledLoggingEnabledtargetGrantsListValue.Permission));
                                        }
                                    }

                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }

                            if (loggingEnabledLoggingEnabled.TargetObjectKeyFormat != null)
                            {
                                xmlWriter.WriteStartElement("TargetObjectKeyFormat", "http://s3.amazonaws.com/doc/2006-03-01/");

                                if (loggingEnabledLoggingEnabled.TargetObjectKeyFormat.PartitionedPrefix != null)
                                {
                                    xmlWriter.WriteStartElement("PartitionedPrefix", "http://s3.amazonaws.com/doc/2006-03-01/");
                                    if (loggingEnabledLoggingEnabled.TargetObjectKeyFormat.PartitionedPrefix.IsSetPartitionDateSource())
                                        xmlWriter.WriteElementString("PartitionDateSource", "http://s3.amazonaws.com/doc/2006-03-01/", StringUtils.FromString(loggingEnabledLoggingEnabled.TargetObjectKeyFormat.PartitionedPrefix.PartitionDateSource));

                                    xmlWriter.WriteEndElement();
                                }

                                if (loggingEnabledLoggingEnabled.TargetObjectKeyFormat.SimplePrefix != null)
                                {
                                    xmlWriter.WriteStartElement("SimplePrefix", "http://s3.amazonaws.com/doc/2006-03-01/");
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }

                            if (loggingEnabledLoggingEnabled.IsSetTargetPrefix())
                            {
                                xmlWriter.WriteElementString("TargetPrefix", S3Transforms.ToXmlStringValue(loggingEnabledLoggingEnabled.TargetPrefix));
                            }
                            else
                            {
                                xmlWriter.WriteStartElement("TargetPrefix");
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }
                }

                xmlWriter.WriteEndElement();
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(
                    request, 
                    putBucketLoggingRequest.ChecksumAlgorithm, 
                    fallbackToMD5: false, 
                    isRequestChecksumRequired: true, 
                    headerName: S3Constants.AmzHeaderSdkChecksumAlgorithm
                );
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

	    private static PutBucketLoggingRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutBucketLoggingRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new PutBucketLoggingRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

