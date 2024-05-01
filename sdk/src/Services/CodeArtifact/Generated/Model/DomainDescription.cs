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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Information about a domain. A domain is a container for repositories. When you create
    /// a domain, it is empty until you add one or more repositories.
    /// </summary>
    public partial class DomainDescription
    {
        private string _arn;
        private long? _assetSizeBytes;
        private DateTime? _createdTime;
        private string _encryptionKey;
        private string _name;
        private string _owner;
        private int? _repositoryCount;
        private string _s3BucketArn;
        private DomainStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetSizeBytes. 
        /// <para>
        ///  The total size of all assets in the domain. 
        /// </para>
        /// </summary>
        public long? AssetSizeBytes
        {
            get { return this._assetSizeBytes; }
            set { this._assetSizeBytes = value; }
        }

        // Check to see if AssetSizeBytes property is set
        internal bool IsSetAssetSizeBytes()
        {
            return this._assetSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///  A timestamp that represents the date and time the domain was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        ///  The ARN of an Key Management Service (KMS) key associated with a domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        ///  The Amazon Web Services account ID that owns the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryCount. 
        /// <para>
        ///  The number of repositories in the domain. 
        /// </para>
        /// </summary>
        public int? RepositoryCount
        {
            get { return this._repositoryCount; }
            set { this._repositoryCount = value; }
        }

        // Check to see if RepositoryCount property is set
        internal bool IsSetRepositoryCount()
        {
            return this._repositoryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket that is used to store package
        /// assets in the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of a domain. 
        /// </para>
        /// </summary>
        public DomainStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}