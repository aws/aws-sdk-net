﻿/*
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
    /// Describes the server-side encryption that will be applied to the restore results.
    /// </summary>
    public class S3Encryption
    {
        /// <summary>
        /// The server-side encryption algorithm used when storing job results in Amazon S3 (e.g., AES256, aws:kms).
        /// </summary>
        public ServerSideEncryptionMethod EncryptionType { get; set; }

        internal bool IsSetEncryptionType()
        {
            return this.EncryptionType != null;

        }

        /// <summary>
        /// Specifies the AWS KMS key ID to use for object encryption. All GET and PUT requests for an object protected by
        /// AWS KMS will fail if not made via SSL or using SigV4. Documentation on configuring any of the officially supported AWS SDKs and CLI can be found at
        /// http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingAWSSDK.html#specify-signature-version
        /// </summary>
        public string KMSKeyId { get; set; }

        internal bool IsSetKMSKeyId()
        {
            return this.KMSKeyId != null;
        }

        /// <summary>
        /// If the encryption type is aws:kms, this optional value can be used to specify the encryption context for the restore results.
        /// </summary>
        public string KMSContext { get; set; }

        internal bool IsSetKMSContext()
        {
            return this.KMSContext != null;
        }

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            if (!IsSetEncryptionType()) throw new System.ArgumentException("EncryptionType is a required property and must be set before making this call.", "S3Encryption.EncryptionType");

            xmlWriter.WriteStartElement(memberName);
            {
                xmlWriter.WriteElementString("EncryptionType", S3Transforms.ToXmlStringValue(EncryptionType.Value));

                if (IsSetKMSKeyId())
                    xmlWriter.WriteElementString("KMSKeyId", S3Transforms.ToXmlStringValue(KMSKeyId));
                if (IsSetKMSContext())
                    xmlWriter.WriteElementString("KMSContext", S3Transforms.ToXmlStringValue(KMSContext));
            }
            xmlWriter.WriteEndElement();
        }
    }
}
