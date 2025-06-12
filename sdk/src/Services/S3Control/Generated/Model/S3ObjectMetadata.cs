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

/*
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class S3ObjectMetadata
    {
        private string _cacheControl;
        private string _contentDisposition;
        private string _contentEncoding;
        private string _contentLanguage;
        private long? _contentLength;
        private string _contentMD5;
        private string _contentType;
        private DateTime? _httpExpiresDate;
        private bool? _requesterCharged;
        private S3SSEAlgorithm _sseAlgorithm;
        private Dictionary<string, string> _userMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CacheControl.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        // Check to see if CacheControl property is set
        internal bool IsSetCacheControl()
        {
            return this._cacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ContentDisposition.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContentDisposition
        {
            get { return this._contentDisposition; }
            set { this._contentDisposition = value; }
        }

        // Check to see if ContentDisposition property is set
        internal bool IsSetContentDisposition()
        {
            return this._contentDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property ContentEncoding.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContentEncoding
        {
            get { return this._contentEncoding; }
            set { this._contentEncoding = value; }
        }

        // Check to see if ContentEncoding property is set
        internal bool IsSetContentEncoding()
        {
            return this._contentEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property ContentLanguage.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContentLanguage
        {
            get { return this._contentLanguage; }
            set { this._contentLanguage = value; }
        }

        // Check to see if ContentLanguage property is set
        internal bool IsSetContentLanguage()
        {
            return this._contentLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        ///  <i>This member has been deprecated.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ContentLength
        {
            get { return this._contentLength; }
            set { this._contentLength = value; }
        }

        // Check to see if ContentLength property is set
        internal bool IsSetContentLength()
        {
            return this._contentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        ///  <i>This member has been deprecated.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property HttpExpiresDate.
        /// </summary>
        public DateTime? HttpExpiresDate
        {
            get { return this._httpExpiresDate; }
            set { this._httpExpiresDate = value; }
        }

        // Check to see if HttpExpiresDate property is set
        internal bool IsSetHttpExpiresDate()
        {
            return this._httpExpiresDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterCharged. 
        /// <para>
        ///  <i>This member has been deprecated.</i> 
        /// </para>
        /// </summary>
        public bool? RequesterCharged
        {
            get { return this._requesterCharged; }
            set { this._requesterCharged = value; }
        }

        // Check to see if RequesterCharged property is set
        internal bool IsSetRequesterCharged()
        {
            return this._requesterCharged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SSEAlgorithm. 
        /// <para>
        /// The server-side encryption algorithm used when storing objects in Amazon S3.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets </b> - For directory buckets, there are only two supported options
        /// for server-side encryption: server-side encryption with Amazon S3 managed keys (SSE-S3)
        /// (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>KMS</c>). For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting
        /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>. For <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-objects-Batch-Ops">the
        /// Copy operation in Batch Operations</a>, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_S3CopyObjectOperation.html">S3CopyObjectOperation</a>.
        /// </para>
        /// </summary>
        public S3SSEAlgorithm SSEAlgorithm
        {
            get { return this._sseAlgorithm; }
            set { this._sseAlgorithm = value; }
        }

        // Check to see if SSEAlgorithm property is set
        internal bool IsSetSSEAlgorithm()
        {
            return this._sseAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property UserMetadata.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=8192)]
        public Dictionary<string, string> UserMetadata
        {
            get { return this._userMetadata; }
            set { this._userMetadata = value; }
        }

        // Check to see if UserMetadata property is set
        internal bool IsSetUserMetadata()
        {
            return this._userMetadata != null && (this._userMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}