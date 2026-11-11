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
    /// Container for the parameters to the AssignTapePool operation. Assigns a tape to a
    /// tape pool for archiving. The tape assigned to a pool is archived in the S3 storage
    /// class that is associated with the pool. When you use your backup application to eject
    /// the tape, the tape is archived directly into the S3 storage class (S3 Glacier or S3
    /// Glacier Deep Archive) that corresponds to the pool.
    /// </summary>
    public partial class AssignTapePoolRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property BypassGovernanceRetention. 
        /// <para>
        /// Set permissions to bypass governance retention. If the lock type of the archived tape
        /// is <c>Governance</c>, the tape's archived age is not older than <c>RetentionLockInDays</c>,
        /// and the user does not already have <c>BypassGovernanceRetention</c>, setting this
        /// to TRUE enables the user to bypass the retention lock. This parameter is set to true
        /// by default for calls from the console.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>TRUE</c> | <c>FALSE</c> 
        /// </para>
        /// </summary>
        public bool? BypassGovernanceRetention { get; set; }

        /// <summary>
        /// Checks to see if the BypassGovernanceRetention property is set.
        /// </summary>
        internal bool IsSetBypassGovernanceRetention() => this.BypassGovernanceRetention.HasValue;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the pool that you want to add your tape to for archiving. The tape in this
        /// pool is archived in the S3 storage class that is associated with the pool. When you
        /// use your backup application to eject the tape, the tape is archived directly into
        /// the storage class (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the
        /// pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the virtual tape that you want to add to
        /// the tape pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 500)]
        public string TapeARN { get; set; }

        /// <summary>
        /// Checks to see if the TapeARN property is set.
        /// </summary>
        internal bool IsSetTapeARN() => this.TapeARN != null;
    }
}
