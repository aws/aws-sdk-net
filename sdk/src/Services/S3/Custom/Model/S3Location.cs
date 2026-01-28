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

using System.Xml;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes an S3 location that will receive the results of the restore request.
    /// </summary>
    public partial class S3Location
    {

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            if (string.IsNullOrEmpty(_bucketName)) throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "S3Location.BucketName");
            if (string.IsNullOrEmpty(_prefix)) throw new System.ArgumentException("Prefix is a required property and must be set before making this call.", "S3Location.Prefix");

            xmlWriter.WriteStartElement(memberName);
            {
                xmlWriter.WriteElementString("BucketName", S3Transforms.ToXmlStringValue(BucketName));
                xmlWriter.WriteElementString("Prefix", S3Transforms.ToXmlStringValue(Prefix));

                if (IsSetEncryption())
                    Encryption.Marshall("Encryption", xmlWriter);
                if (IsSetCannedACL())
                    xmlWriter.WriteElementString("CannedACL", S3Transforms.ToXmlStringValue(CannedACL.Value));
                if (IsSetAccessControlList())
                    AccessControlList.Marshall("AccessControlList", xmlWriter);
                if (IsSetTagging())
                    Tagging.Marshall("Tagging", xmlWriter);
                if (IsSetUserMetadata())
                    UserMetadata.Marshall("UserMetadata", xmlWriter);
                if (IsSetStorageClass())
                    xmlWriter.WriteElementString("StorageClass", S3Transforms.ToXmlStringValue(StorageClass.Value));
            }
            xmlWriter.WriteEndElement();
        }
    }
}
