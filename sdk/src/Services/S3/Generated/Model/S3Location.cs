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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes an Amazon S3 location that will receive the results of the restore request.
    /// </summary>
    public partial class S3Location
    {
        private S3AccessControlList _accessControlList;
        private string _bucketName;
        private S3CannedACL _cannedACL;
        private S3Encryption _encryption;
        private string _prefix;
        private S3StorageClass _storageClass;
        private Tagging _tagging;
        private MetadataCollection _userMetadata;

        /// <summary>
        /// Gets and sets the property AccessControlList. 
        /// <para>
        /// A list of grants that control access to the staged results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public S3AccessControlList AccessControlList
        {
            get { return this._accessControlList; }
            set { this._accessControlList = value; }
        }

        // Check to see if AccessControlList property is set
        internal bool IsSetAccessControlList()
        {
            return this._accessControlList != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket where the restore results will be placed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property CannedACL. 
        /// <para>
        /// The canned ACL to apply to the restore results.
        /// </para>
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this._cannedACL; }
            set { this._cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return this._cannedACL != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public S3Encryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix that is prepended to the restore results for this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The class of storage used to store the restore results.
        /// </para>
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property Tagging. 
        /// <para>
        /// The tag-set that is applied to the restore results.
        /// </para>
        /// </summary>
        public Tagging Tagging
        {
            get { return this._tagging; }
            set { this._tagging = value; }
        }

        // Check to see if Tagging property is set
        internal bool IsSetTagging()
        {
            return this._tagging != null;
        }

        /// <summary>
        /// Gets and sets the property UserMetadata. 
        /// <para>
        /// A list of metadata to store with the restore results in S3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public MetadataCollection UserMetadata
        {
            get { return this._userMetadata; }
            set { this._userMetadata = value; }
        }

        // Check to see if UserMetadata property is set
        internal bool IsSetUserMetadata()
        {
            return this._userMetadata != null;
        }

    }
}