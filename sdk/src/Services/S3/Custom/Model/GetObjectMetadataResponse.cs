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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  HeadObject response and response metadata.
    /// </summary>
    public partial class GetObjectMetadataResponse : AmazonWebServiceResponse
    {
        private string deleteMarker;
        private DateTime? restoreExpiration;
        private bool? restoreInProgress;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();

        /// <summary>
        /// The date and time at which the object is no longer cacheable.
        /// </summary>
        public string ExpiresString { get; set; }

        /// <summary>
        /// The collection of headers for the request.
        /// </summary>
        public HeadersCollection Headers
        {
            get
            {
                if (this.headersCollection == null)
                    this.headersCollection = new HeadersCollection();
                return this.headersCollection;
            }
        }

        /// <summary>
        /// The collection of meta data for the request.
        /// </summary>
        public MetadataCollection Metadata
        {
            get
            {
                if (this.metadataCollection == null)
                    this.metadataCollection = new MetadataCollection();
                return this.metadataCollection;
            }
        }

        /// <summary>
        /// Gets and sets the property DeleteMarker. 
        /// <para>
        /// Specifies whether the object retrieved was (true) or was not (false) a Delete Marker.
        /// If false, this response header does not appear in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string DeleteMarker
        {
            get { return this.deleteMarker; }
            set { this.deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this.deleteMarker != null;
        }

        /// <summary>
        /// Gets and sets the RestoreExpiration property.
        /// <para>
        /// RestoreExpiration will be set for objects that have been restored from Amazon Glacier.
        /// It indicates for those objects how long the restored object will exist.
        /// </para>
        /// <para>
        /// This functionality is not supported for directory buckets. 
        /// Only the S3 Express One Zone storage class is supported by directory buckets to store objects.
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiration
        {
            get { return this.restoreExpiration; }
            set { this.restoreExpiration = value; }
        }

        /// <summary>
        /// Gets and sets the RestoreInProgress
        /// <para>
        /// Will be <c>true</c> when the object is in the process of being restored from Amazon Glacier.
        /// </para>
        /// <para>
        /// This functionality is not supported for directory buckets. 
        /// Only the S3 Express One Zone storage class is supported by directory buckets to store objects.
        /// </para>
        /// </summary>
        public bool? RestoreInProgress
        {
            get { return this.restoreInProgress; }
            set { this.restoreInProgress = value; }
        }

        /// <summary>
        /// The server-side encryption algorithm used when storing this object in Amazon S3 or Amazon FSx.
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3 or Amazon FSx.
        /// </para>
        /// <note>
        /// <para>When accessing data stored in Amazon FSx file systems using S3 access points, the only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        /// </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get 
            {
                if (this.serverSideEncryption == null)
                    return ServerSideEncryptionMethod.None;

                return this.serverSideEncryption; 
            }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        ///  <note> 
        /// <para>
        /// For directory buckets, only server-side encryption with Amazon S3 managed keys (SSE-S3)
        /// (<code>AES256</code>) is supported.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod 
        { 
            get
            {
                if (this.serverSideEncryptionCustomerMethod == null)
                    return ServerSideEncryptionCustomerMethod.None;

                return this.serverSideEncryptionCustomerMethod;
            }
            set { this.serverSideEncryptionCustomerMethod = value; } 
        }


        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideEncryptionCustomerMethod != null;
        }
    }
}

