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
    /// Describes a custom tape pool.
    /// </summary>
    public partial class PoolInfo
    {
        private string _poolARN;
        private string _poolName;
        private PoolStatus _poolStatus;
        private int? _retentionLockTimeInDays;
        private RetentionLockType _retentionLockType;
        private TapeStorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property PoolARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom tape pool. Use the <a>ListTapePools</a>
        /// operation to return a list of custom tape pools for your account and Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string PoolARN
        {
            get { return this._poolARN; }
            set { this._poolARN = value; }
        }

        // Check to see if PoolARN property is set
        internal bool IsSetPoolARN()
        {
            return this._poolARN != null;
        }

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the custom tape pool. <c>PoolName</c> can use all ASCII characters, except
        /// '/' and '\'.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property PoolStatus. 
        /// <para>
        /// Status of the custom tape pool. Pool can be <c>ACTIVE</c> or <c>DELETED</c>.
        /// </para>
        /// </summary>
        public PoolStatus PoolStatus
        {
            get { return this._poolStatus; }
            set { this._poolStatus = value; }
        }

        // Check to see if PoolStatus property is set
        internal bool IsSetPoolStatus()
        {
            return this._poolStatus != null;
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
        /// Tape retention lock type, which can be configured in two modes. When configured in
        /// governance mode, Amazon Web Services accounts with specific IAM permissions are authorized
        /// to remove the tape retention lock from archived virtual tapes. When configured in
        /// compliance mode, the tape retention lock cannot be removed by any user, including
        /// the root Amazon Web Services account.
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
        /// The storage class that is associated with the custom pool. When you use your backup
        /// application to eject the tape, the tape is archived directly into the storage class
        /// (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the pool.
        /// </para>
        /// </summary>
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

    }
}