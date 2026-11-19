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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// </summary>
    public partial class S3ObjectMetadata
    {
        /// <summary>
        /// Gets and sets the property CacheControl. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CacheControl { get; set; }

        /// <summary>
        /// Checks to see if the CacheControl property is set.
        /// </summary>
        internal bool IsSetCacheControl() => this.CacheControl != null;

        /// <summary>
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// Checks to see if the ContentDisposition property is set.
        /// </summary>
        internal bool IsSetContentDisposition() => this.ContentDisposition != null;

        /// <summary>
        /// Gets and sets the property ContentEncoding. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// Checks to see if the ContentEncoding property is set.
        /// </summary>
        internal bool IsSetContentEncoding() => this.ContentEncoding != null;

        /// <summary>
        /// Gets and sets the property ContentLanguage. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContentLanguage { get; set; }

        /// <summary>
        /// Checks to see if the ContentLanguage property is set.
        /// </summary>
        internal bool IsSetContentLanguage() => this.ContentLanguage != null;

        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        ///  <i>This member has been deprecated.</i> 
        /// </para>
        ///  
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ContentLength { get; set; }

        /// <summary>
        /// Checks to see if the ContentLength property is set.
        /// </summary>
        internal bool IsSetContentLength() => this.ContentLength.HasValue;

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        ///  <i>This member has been deprecated.</i> 
        /// </para>
        ///  
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContentMD5 { get; set; }

        /// <summary>
        /// Checks to see if the ContentMD5 property is set.
        /// </summary>
        internal bool IsSetContentMD5() => this.ContentMD5 != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property HttpExpiresDate. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public DateTime? HttpExpiresDate { get; set; }

        /// <summary>
        /// Checks to see if the HttpExpiresDate property is set.
        /// </summary>
        internal bool IsSetHttpExpiresDate() => this.HttpExpiresDate.HasValue;

        /// <summary>
        /// Gets and sets the property RequesterCharged. 
        /// <para>
        ///  <i>This member has been deprecated.</i> 
        /// </para>
        ///  
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public bool? RequesterCharged { get; set; }

        /// <summary>
        /// Checks to see if the RequesterCharged property is set.
        /// </summary>
        internal bool IsSetRequesterCharged() => this.RequesterCharged.HasValue;

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
        public S3SSEAlgorithm SSEAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SSEAlgorithm property is set.
        /// </summary>
        internal bool IsSetSSEAlgorithm() => this.SSEAlgorithm != null;

        /// <summary>
        /// Gets and sets the property UserMetadata. 
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public Dictionary<string, string> UserMetadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the UserMetadata property is set.
        /// </summary>
        internal bool IsSetUserMetadata() => this.UserMetadata != null && (this.UserMetadata.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
