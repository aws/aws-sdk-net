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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a custom tape pool.
    /// </summary>
    public partial class PoolInfo
    {
        /// <summary>
        /// Gets and sets the property PoolARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom tape pool. Use the <a>ListTapePools</a>
        /// operation to return a list of custom tape pools for your account and Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string PoolARN { get; set; }

        /// <summary>
        /// Checks to see if the PoolARN property is set.
        /// </summary>
        internal bool IsSetPoolARN() => this.PoolARN != null;

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the custom tape pool. <c>PoolName</c> can use all ASCII characters, except
        /// '/' and '\'.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PoolName { get; set; }

        /// <summary>
        /// Checks to see if the PoolName property is set.
        /// </summary>
        internal bool IsSetPoolName() => this.PoolName != null;

        /// <summary>
        /// Gets and sets the property PoolStatus. 
        /// <para>
        /// Status of the custom tape pool. Pool can be <c>ACTIVE</c> or <c>DELETED</c>.
        /// </para>
        /// </summary>
        public PoolStatus PoolStatus { get; set; }

        /// <summary>
        /// Checks to see if the PoolStatus property is set.
        /// </summary>
        internal bool IsSetPoolStatus() => this.PoolStatus != null;

        /// <summary>
        /// Gets and sets the property RetentionLockTimeInDays. 
        /// <para>
        /// Tape retention lock time is set in days. Tape retention lock can be enabled for up
        /// to 100 years (36,500 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36500)]
        public int? RetentionLockTimeInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionLockTimeInDays property is set.
        /// </summary>
        internal bool IsSetRetentionLockTimeInDays() => this.RetentionLockTimeInDays.HasValue;

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
        public RetentionLockType RetentionLockType { get; set; }

        /// <summary>
        /// Checks to see if the RetentionLockType property is set.
        /// </summary>
        internal bool IsSetRetentionLockType() => this.RetentionLockType != null;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class that is associated with the custom pool. When you use your backup
        /// application to eject the tape, the tape is archived directly into the storage class
        /// (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the pool.
        /// </para>
        /// </summary>
        public TapeStorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}
