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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;
using Amazon.Util;
using System.IO;
using System.Text;
using System.Xml;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
	/// <summary>
	/// Put Bucket IntelligentTieringConfigurationRequest Marshaller
	/// </summary>   
	public class PutBucketIntelligentTieringConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketIntelligentTieringConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
	{
        /// <summary>
        /// Marshall the public request to the internal IRequest structure.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutBucketIntelligentTieringConfigurationRequest)input);
		}

        /// <summary>
        /// Marshall the public request to the internal IRequest structure.
        /// </summary>
        /// <param name="PutBucketIntelligentTieringConfigurationRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketIntelligentTieringConfigurationRequest PutBucketIntelligentTieringConfigurationRequest)
		{
			IRequest request = new DefaultRequest(PutBucketIntelligentTieringConfigurationRequest, "AmazonS3");
			var intelligentTieringConfiguration = PutBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration;
			request.HttpMethod = "PUT";

			if (string.IsNullOrEmpty(PutBucketIntelligentTieringConfigurationRequest.BucketName))
				throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketIntelligentTieringConfigurationRequest.BucketName");

			if (intelligentTieringConfiguration == null)
				throw new System.ArgumentException("IntelligentTieringConfiguration is a required property and must be set before making this call.", "PutBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration");

			if (string.IsNullOrEmpty(intelligentTieringConfiguration.IntelligentTieringId))
				throw new System.ArgumentException("IntelligentTieringId is a required property and must be set before making this call.", "IntelligentTieringConfiguration.IntelligentTieringId");

			if (string.IsNullOrEmpty(PutBucketIntelligentTieringConfigurationRequest.IntelligentTieringId))
				throw new System.ArgumentException("IntelligentTieringId is a required property and must be set before making this call.", "PutBucketIntelligentTieringConfigurationRequest.IntelligentTieringId");

			if (!intelligentTieringConfiguration.IsSetStatus())
				throw new System.ArgumentException("Status is a required property and must be set before making this call.", "IntelligentTieringConfiguration.Status");

			if (!intelligentTieringConfiguration.IsSetTieringList())
				throw new System.ArgumentException("TieringList is a required property and must be set before making this call.", "IntelligentTieringConfiguration.TieringList");

            if (PutBucketIntelligentTieringConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(PutBucketIntelligentTieringConfigurationRequest.ExpectedBucketOwner));

            request.ResourcePath = "/";

            request.AddSubResource("intelligent-tiering");

			request.AddSubResource("id", PutBucketIntelligentTieringConfigurationRequest.IntelligentTieringId);

			var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
			using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize}))
			{

				if (intelligentTieringConfiguration != null)
				{
					xmlWriter.WriteStartElement("IntelligentTieringConfiguration", S3Constants.S3RequestXmlNamespace);
					if (intelligentTieringConfiguration != null)
					{
						if (intelligentTieringConfiguration.IsSetIntelligentTieringId())
						{
							xmlWriter.WriteElementString("Id", S3Transforms.ToXmlStringValue(intelligentTieringConfiguration.IntelligentTieringId));
						}

						if (intelligentTieringConfiguration.IsSetIntelligentTieringFilter())
						{
							xmlWriter.WriteStartElement("Filter");
							var filterPredicate = intelligentTieringConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate;
							filterPredicate.Accept(new IntelligentTieringPredicateVisitor(xmlWriter));

							xmlWriter.WriteEndElement();
						}

						if (intelligentTieringConfiguration.IsSetStatus())
						{
							xmlWriter.WriteElementString("Status", S3Transforms.ToXmlStringValue(intelligentTieringConfiguration.Status));
						}

						if (intelligentTieringConfiguration.IsSetTieringList())
						{
							foreach (var tiering in intelligentTieringConfiguration.Tierings)
							{
								if (tiering != null)
								{
									xmlWriter.WriteStartElement("Tiering");
									xmlWriter.WriteElementString("Days", S3Transforms.ToXmlStringValue(tiering.Days.Value));
									xmlWriter.WriteElementString("AccessTier", S3Transforms.ToXmlStringValue(tiering.AccessTier));
									xmlWriter.WriteEndElement();
								}
							}
						}
					}
					xmlWriter.WriteEndElement();
				}
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

			return request;

		}

		private static PutBucketIntelligentTieringConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutBucketIntelligentTieringConfigurationRequestMarshaller Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new PutBucketIntelligentTieringConfigurationRequestMarshaller();
				}
				return _instance;
			}
		}
	}
}
