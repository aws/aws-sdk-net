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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTapePool operation.
    /// Creates a new custom tape pool. You can use custom tape pool to enable tape retention
    /// lock on tapes that are archived in the custom pool.
    /// </summary>
    public partial class CreateTapePoolRequest : AmazonStorageGatewayRequest
    {
        private string _poolName;
        private int? _retentionLockTimeInDays;
        private RetentionLockType _retentionLockType;
        private TapeStorageClass _storageClass;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the new custom tape pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionLockTimeInDays. 
        /// <para>
        /// Tape retention lock time is set in days. Tape retention lock can be enabled for up
        /// to 100 years (36,500 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=36500)]
        public int? RetentionLockTimeInDays
        {
            get { return this._retentionLockTimeInDays; }
            set { this._retentionLockTimeInDays = value; }
        }

        // Check to see if RetentionLockTimeInDays property is set
        internal bool IsSetRetentionLockTimeInDays()
        {
            return this._retentionLockTimeInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionLockType. 
        /// <para>
        /// Tape retention lock can be configured in two modes. When configured in governance
        /// mode, Amazon Web Services accounts with specific IAM permissions are authorized to
        /// remove the tape retention lock from archived virtual tapes. When configured in compliance
        /// mode, the tape retention lock cannot be removed by any user, including the root Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        public RetentionLockType RetentionLockType
        {
            get { return this._retentionLockType; }
            set { this._retentionLockType = value; }
        }

        // Check to see if RetentionLockType property is set
        internal bool IsSetRetentionLockType()
        {
            return this._retentionLockType != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class that is associated with the new custom pool. When you use your backup
        /// application to eject the tape, the tape is archived directly into the storage class
        /// (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TapeStorageClass StorageClass
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to tape pool. Each tag is a key-value
        /// pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}