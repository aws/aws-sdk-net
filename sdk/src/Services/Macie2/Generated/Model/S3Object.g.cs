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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the S3 object that a finding applies to.
    /// </summary>
    public partial class S3Object
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket that contains the object.
        /// </para>
        /// </summary>
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag (ETag) that identifies the affected version of the object. If the object
        /// was overwritten or changed after Amazon Macie produced the finding, this value might
        /// be different from the current ETag for the object.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property Extension. 
        /// <para>
        /// The file name extension of the object. If the object doesn't have a file name extension,
        /// this value is "".
        /// </para>
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Checks to see if the Extension property is set.
        /// </summary>
        internal bool IsSetExtension() => this.Extension != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The full name (<i>key</i>) of the object, including the object's prefix if applicable.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the object was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The full path to the affected object, including the name of the affected bucket and
        /// the object's name (key).
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property PublicAccess. 
        /// <para>
        /// Specifies whether the object is publicly accessible due to the combination of permissions
        /// settings that apply to the object.
        /// </para>
        /// </summary>
        public bool? PublicAccess { get; set; }

        /// <summary>
        /// Checks to see if the PublicAccess property is set.
        /// </summary>
        internal bool IsSetPublicAccess() => this.PublicAccess.HasValue;

        /// <summary>
        /// Gets and sets the property ServerSideEncryption. 
        /// <para>
        /// The type of server-side encryption that was used to encrypt the object.
        /// </para>
        /// </summary>
        public ServerSideEncryption ServerSideEncryption { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryption property is set.
        /// </summary>
        internal bool IsSetServerSideEncryption() => this.ServerSideEncryption != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The total storage size, in bytes, of the object.
        /// </para>
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class of the object.
        /// </para>
        /// </summary>
        public StorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are associated with the object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The identifier for the affected version of the object.
        /// </para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
