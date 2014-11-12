/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the CopyPart operation.
    /// <para>Uploads a part by copying data from an existing object as data source.</para>
    /// </summary>
    public partial class CopyPartRequest : AmazonWebServiceRequest
    {
        private string srcBucket;
        private string srcKey;
        private string srcVersionId;
        private string dstBucket;
        private string dstKey;
        private string uploadId;
        private List<string> etagsToMatch;
        private List<string> etagsToNotMatch;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;
        private int? partNumber;
        private long? firstByte;
        private long? lastByte;

        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string serverSideEncryptionKeyManagementServiceKeyId;

        private ServerSideEncryptionCustomerMethod copySourceServerSideCustomerEncryption;
        private string copySourceServerSideEncryptionCustomerProvidedKey;
        private string copySourceServerSideEncryptionCustomerProvidedKeyMD5;

        /// <summary>
        /// The name of the bucket containing the object to copy.
        /// </summary>
        public string SourceBucket
        {
            get { return this.srcBucket; }
            set { this.srcBucket = value; }
        }


        /// <summary>
        /// Checks if SourceBucket property is set.
        /// </summary>
        /// <returns>true if SourceBucket property is set.</returns>
        internal bool IsSetSourceBucket()
        {
            return !System.String.IsNullOrEmpty(this.srcBucket);
        }


        /// <summary>
        /// The key of the object to copy.
        /// </summary>
        public string SourceKey
        {
            get { return this.srcKey; }
            set { this.srcKey = value; }
        }


        /// <summary>
        /// Checks if SourceKey property is set.
        /// </summary>
        /// <returns>true if SourceKey property is set.</returns>
        internal bool IsSetSourceKey()
        {
            return !System.String.IsNullOrEmpty(this.srcKey);
        }


        /// <summary>
        /// Specifies a particular version of the source object to copy. By default the latest version is copied.
        /// </summary>
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }


        /// <summary>
        /// Checks if SourceVersionId property is set.
        /// </summary>
        /// <returns>true if SourceVersionId property is set.</returns>
        internal bool IsSetSourceVersionId()
        {
            return !System.String.IsNullOrEmpty(this.srcVersionId);
        }


        /// <summary>
        /// The name of the bucket to contain the copy of the source object.
        /// </summary>
        public string DestinationBucket
        {
            get { return this.dstBucket; }
            set { this.dstBucket = value; }
        }


        /// <summary>
        /// Checks if DestinationBucket property is set.
        /// </summary>
        /// <returns>true if DestinationBucket property is set.</returns>
        internal bool IsSetDestinationBucket()
        {
            return !System.String.IsNullOrEmpty(this.dstBucket);
        }

        /// <summary>
        /// The key to be given to the copy of the source object.
        /// </summary>
        public string DestinationKey
        {
            get { return this.dstKey; }
            set { this.dstKey = value; }
        }

        /// <summary>
        /// Checks if DestinationKey property is set.
        /// </summary>
        /// <returns>true if DestinationKey property is set.</returns>
        internal bool IsSetDestinationKey()
        {
            return !System.String.IsNullOrEmpty(this.dstKey);
        }

        /// <summary>
        /// The ID identifying multipart upload for which we are copying a part.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }


        /// <summary>
        /// Checks if UploadId property is set.
        /// </summary>
        /// <returns>true if UploadId property is set.</returns>
        internal bool IsSetUploadId()
        {
            return !System.String.IsNullOrEmpty(this.uploadId);
        }

        /// <summary>
        /// Collection of ETags to be matched as a pre-condition for copying the source object
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) matches one of
        /// the specified tags; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        public List<string> ETagToMatch
        {
            get
            {
                if (this.etagsToMatch == null)
                {
                    this.etagsToMatch = new List<String>();
                }
                return this.etagsToMatch;
            }
            set { this.etagsToMatch = value; }
        }


        /// <summary>
        /// Checks if ETagsToMatch property is set.
        /// </summary>
        /// <returns>true if ETagToMatch property is set.</returns>
        internal bool IsSetETagToMatch()
        {
            return ((etagsToMatch != null) && (etagsToMatch.Count > 0));
        }

        /// <summary>
        /// Collection of ETags that must not be matched as a pre-condition for copying the source object
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) does not match any of the specified
        /// tags; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </remarks>
        public List<string> ETagsToNotMatch
        {
            get
            {
                if (this.etagsToNotMatch == null)
                {
                    this.etagsToNotMatch = new List<String>();
                }
                return this.etagsToNotMatch;
            }
            set { this.etagsToNotMatch = value; }
        }


        /// <summary>
        /// Checks if ETagToNotMatch property is set.
        /// </summary>
        /// <returns>true if ETagToNotMatch property is set.</returns>
        internal bool IsSetETagToNotMatch()
        {
            return ((etagsToNotMatch != null) && (etagsToNotMatch.Count > 0));
        }

        /// <summary>
        /// Copies the object if it has been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }


        /// <summary>
        /// Checks if ModifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if ModifiedSinceDate property is set.</returns>
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// Copies the object if it has not been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
        }

        /// <summary>
        /// Checks if UnmodifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if UnmodifiedSinceDate property is set.</returns>
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }

        /// <summary>
        /// The number of the part to be copied.
        /// </summary>
        /// <remarks>
        /// Valid part numbers are from 1 to 10,000 inclusive and will uniquely identify the part 
        /// and determine the relative ordering within the destination object.  If a part already
        /// exists with the PartNumber it will be overwritten.
        /// </remarks>
        public int PartNumber
        {
            get { return this.partNumber.GetValueOrDefault(); }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// Checks if PartNumber property is set.
        /// </summary>
        /// <returns>true if PartNumber property is set.</returns>
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        /// <summary>
        /// The location of the first byte in the range if only a portion of the 
        /// source object is to be copied as the part. 
        /// </summary>
        /// <remarks>
        /// The LastByte property must also be set or this value will be ignored.
        /// </remarks>
        public long FirstByte
        {
            get { return this.firstByte.GetValueOrDefault(); }
            set { this.firstByte = value; }
        }

        /// <summary>
        /// Checks if FirstByte property is set.
        /// </summary>
        /// <returns>true if FirstByte property is set.</returns>
        internal bool IsSetFirstByte()
        {
            return this.firstByte.HasValue;
        }

        /// <summary>
        /// The location of the last byte in the range if only a portion of the 
        /// source object is to be copied as the part.  
        /// </summary>
        /// <remarks>
        /// The FirstByte property must also be set or this value will be ignored.
        /// </remarks>
        public long LastByte
        {
            get { return this.lastByte.GetValueOrDefault(); }
            set { this.lastByte = value; }
        }

        /// <summary>
        /// Checks if LastByte property is set.
        /// </summary>
        /// <returns>true if LastByte property is set.</returns>
        internal bool IsSetLastByte()
        {
            return this.lastByte.HasValue;
        }

        /// <summary>
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionMethod property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionMethod property is set.</returns>
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null && this.serverSideEncryption != ServerSideEncryptionMethod.None;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideCustomerEncryption != null && this.serverSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to encrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>
        /// <para>
        /// When you retrieve an object, you must provide the same encryption key as part of your request. Amazon S3 first verifies 
        /// the encryption key you provided matches, and then decrypts the object before returning the object data to you.
        /// </para>
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this.serverSideEncryptionCustomerProvidedKey; }
            set { this.serverSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// The id of the AWS Key Management Service key that Amazon S3 should use to encrypt and decrypt the object.
        /// If a key id is not specified, the default key will be used for encryption and decryption.
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod CopySourceServerSideEncryptionCustomerMethod
        {
            get { return this.copySourceServerSideCustomerEncryption; }
            set { this.copySourceServerSideCustomerEncryption = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerMethod property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerMethod()
        {
            return this.copySourceServerSideCustomerEncryption != null && this.copySourceServerSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The customer provided encryption key for the source object of the copy.
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        /// </summary>
        public string CopySourceServerSideEncryptionCustomerProvidedKey
        {
            get { return this.copySourceServerSideEncryptionCustomerProvidedKey; }
            set { this.copySourceServerSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// Checks if CopySourceServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if CopySourceServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.copySourceServerSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the CopySourceServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        public string CopySourceServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.copySourceServerSideEncryptionCustomerProvidedKeyMD5; }
            set { this.copySourceServerSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if CopySourceServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if CopySourceServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.copySourceServerSideEncryptionCustomerProvidedKeyMD5);
        }
    }
}
    
