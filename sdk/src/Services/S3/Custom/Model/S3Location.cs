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
    public class S3Location
    {
        /// <summary>
        /// The name of the bucket where the restore results will be placed.
        /// </summary>
        public string BucketName { get; set; }

        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// The prefix that is prepended to the restore results for this request.
        /// </summary>
        public string Prefix { get; set; }

        internal bool IsSetPrefix()
        {
            return this.Prefix != null;
        }

        /// <summary>
        /// The server-side encryption that will be applied to the restore results.
        /// </summary>
        public S3Encryption Encryption { get; set; }

        internal bool IsSetEncryption()
        {
            return this.Encryption != null;
        }

        /// <summary>
        /// The canned ACL to apply to the restore results.
        /// </summary>
        public S3CannedACL CannedACL { get; set; }

        internal bool IsSetCannedACL()
        {
            return this.CannedACL != null;
        }

        /// <summary>
        /// A list of grants that control access to the staged results.
        /// </summary>
        public S3AccessControlList AccessControlList { get; set; }

        internal bool IsSetAccessControlList()
        {
            return this.AccessControlList != null;
        }

        /// <summary>
        /// The tag-set that is applied to the restore results.
        /// </summary>
        public Tagging Tagging { get; set; }

        internal bool IsSetTagging()
        {
            return this.Tagging != null;
        }

        /// <summary>
        /// A map of metadata to store with the restore results in S3.
        /// </summary>
        public MetadataCollection UserMetadata { get; set; }

        internal bool IsSetUserMetadata()
        {
            return this.UserMetadata != null;
        }

        /// <summary>
        /// The class of storage used to store the restore results.
        /// </summary>
        public S3StorageClass StorageClass { get; set; }

        internal bool IsSetStorageClass()
        {
            return this.StorageClass != null;
        }

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            if (string.IsNullOrEmpty(BucketName)) throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "S3Location.BucketName");
            if (string.IsNullOrEmpty(Prefix)) throw new System.ArgumentException("Prefix is a required property and must be set before making this call.", "S3Location.Prefix");

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
