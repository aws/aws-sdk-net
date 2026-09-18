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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Amazon S3 object.
    /// </summary>
    public partial class AwsS3ObjectDetails
    {
        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the object data.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The opaque identifier assigned by a web server to a specific version of a resource
        /// found at a URL.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Indicates when the object was last modified.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property SSEKMSKeyId. 
        /// <para>
        /// The identifier of the KMS symmetric customer managed key that was used for the object.
        /// </para>
        /// </summary>
        public string SSEKMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SSEKMSKeyId property is set.
        /// </summary>
        internal bool IsSetSSEKMSKeyId() => this.SSEKMSKeyId != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryption. 
        /// <para>
        /// If the object is stored using server-side encryption, the value of the server-side
        /// encryption algorithm used when storing this object in Amazon S3.
        /// </para>
        /// </summary>
        public string ServerSideEncryption { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryption property is set.
        /// </summary>
        internal bool IsSetServerSideEncryption() => this.ServerSideEncryption != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version of the object.
        /// </para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
