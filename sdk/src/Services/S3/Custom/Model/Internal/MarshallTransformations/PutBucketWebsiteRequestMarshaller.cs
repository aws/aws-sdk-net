
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public partial  class PutBucketWebsiteRequestMarshaller : IMarshaller<IRequest, PutBucketWebsiteRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        void ErrorDocumentCustomMarshall(PutBucketWebsiteRequest publicRequest, XmlWriter xmlWriter)
        {
            if (publicRequest.WebsiteConfiguration.IsSetErrorDocument())
            {
                xmlWriter.WriteStartElement("ErrorDocument");
                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequest.WebsiteConfiguration.ErrorDocument));
                xmlWriter.WriteEndElement();
            }
        }

        void IndexDocumentSuffixCustomMarshall(PutBucketWebsiteRequest publicRequest, XmlWriter xmlWriter)
        {
            if (publicRequest.WebsiteConfiguration.IsSetIndexDocumentSuffix())
            {
                xmlWriter.WriteStartElement("IndexDocument");
                xmlWriter.WriteElementString("Suffix", StringUtils.FromString(publicRequest.WebsiteConfiguration.IndexDocumentSuffix));
                xmlWriter.WriteEndElement();
            }
        })
    }
}
