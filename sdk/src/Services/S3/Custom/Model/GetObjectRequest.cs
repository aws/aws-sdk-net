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
    /// Container for the parameters to the GetObject operation.
    /// <para>Retrieves objects from Amazon S3.</para>
    /// </summary>
    public partial class GetObjectRequest : AmazonWebServiceRequest
    {
        private string bucketName;

        DateTime? modifiedSinceDate;
        DateTime? unmodifiedSinceDate;
        string etagToMatch;
        string etagToNotMatch;

        private string key;
        private ByteRange byteRange;
        private DateTime? responseExpires;
        private string versionId;
        private ResponseHeaderOverrides responseHeaders;

        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;

        /// <summary>
        /// The name of the bucket containing the object.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// ETag to be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        public string EtagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        // Check to see if EtagToMatch property is set
        internal bool IsSetEtagToMatch()
        {
            return this.etagToMatch != null;
        }

        /// <summary>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate ?? default(DateTime); }
            set { this.modifiedSinceDate = value; }
        }

        // Check to see if ModifiedSinceDate property is set
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// ETag that should not be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        public string EtagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        // Check to see if EtagToNotMatch property is set
        internal bool IsSetEtagToNotMatch()
        {
            return this.etagToNotMatch != null;
        }

        /// <summary>
        /// Returns the object only if it has not been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate ?? default(DateTime); }
            set { this.unmodifiedSinceDate = value; }
        }

        // Check to see if UnmodifiedSinceDate property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }


        /// <summary>
        /// Gets and sets the Key property. This is the user defined key that identifies the object in the bucket.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Downloads the specified range bytes of an object.
        /// </summary>
        public ByteRange ByteRange
        {
            get { return this.byteRange; }
            set { this.byteRange = value; }
        }

        // Check to see if ByteRange property is set
        internal bool IsSetByteRange()
        {
            return this.byteRange != null;
        }

        /// <summary>
        /// A set of response headers that should be returned with the object.
        /// </summary>
        public ResponseHeaderOverrides ResponseHeaderOverrides
        {
            get
            {
                if (this.responseHeaders == null)
                {
                    this.responseHeaders = new ResponseHeaderOverrides();
                }
                return this.responseHeaders;
            }
            set
            {
                this.responseHeaders = value;
            }
        }

        /// <summary>
        /// Sets the Expires header of the response.
        ///  
        /// </summary>
        public DateTime ResponseExpires
        {
            get { return this.responseExpires ?? default(DateTime); }
            set { this.responseExpires = value; }
        }

        // Check to see if ResponseExpires property is set
        internal bool IsSetResponseExpires()
        {
            return this.responseExpires.HasValue;
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        ///  
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
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
        /// The base64-encoded encryption key for Amazon S3 to use to decrypt the object
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
    }
}
    
