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
	public partial class PutBucketIntelligentTieringConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketIntelligentTieringConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
	{
        void IntelligentTieringFilterCustomMarshall(PutBucketIntelligentTieringConfigurationRequest publicRequest, XmlWriter xmlWriter)
		{
            if (publicRequest.IntelligentTieringConfiguration.IsSetIntelligentTieringFilter())
            {
                xmlWriter.WriteStartElement("Filter");
                var filterPredicate = publicRequest.IntelligentTieringConfiguration.IntelligentTieringFilter.IntelligentTieringFilterPredicate;
                filterPredicate.Accept(new IntelligentTieringPredicateVisitor(xmlWriter));

                xmlWriter.WriteEndElement();
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketIntelligentTieringConfigurationRequest publicRequest)
        {
			ChecksumUtils.SetChecksumData(defaultRequest);
        }

        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutBucketIntelligentTieringConfigurationRequest publicRequest)
        {
			var intelligentTieringConfiguration = publicRequest.IntelligentTieringConfiguration;
            if (intelligentTieringConfiguration == null)
                throw new System.ArgumentException("IntelligentTieringConfiguration is a required property and must be set before making this call.", "PutBucketIntelligentTieringConfigurationRequest.IntelligentTieringConfiguration");

            if (string.IsNullOrEmpty(intelligentTieringConfiguration.IntelligentTieringId))
                throw new System.ArgumentException("IntelligentTieringId is a required property and must be set before making this call.", "IntelligentTieringConfiguration.IntelligentTieringId");

            if (string.IsNullOrEmpty(publicRequest.IntelligentTieringConfiguration.IntelligentTieringId))
                throw new System.ArgumentException("IntelligentTieringId is a required property and must be set before making this call.", "PutBucketIntelligentTieringConfigurationRequest.IntelligentTieringId");

            if (!intelligentTieringConfiguration.IsSetStatus())
                throw new System.ArgumentException("Status is a required property and must be set before making this call.", "IntelligentTieringConfiguration.Status");

            if (!intelligentTieringConfiguration.IsSetTierings())
                throw new System.ArgumentException("Tierings is a required property and must be set before making this call.", "IntelligentTieringConfiguration.TieringList");
        }
    }
}
