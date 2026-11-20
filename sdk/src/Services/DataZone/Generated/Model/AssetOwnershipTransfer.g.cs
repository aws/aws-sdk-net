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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of an asset ownership transfer.
    /// </summary>
    public partial class AssetOwnershipTransfer
    {
        /// <summary>
        /// Gets and sets the property SourceProjectId. 
        /// <para>
        /// The ID of the project that owned the asset when the transfer started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceProjectId { get; set; }

        /// <summary>
        /// Checks to see if the SourceProjectId property is set.
        /// </summary>
        internal bool IsSetSourceProjectId() => this.SourceProjectId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp of when the transfer started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ownership transfer. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> — The transfer is in progress. Requests that change the asset
        /// or its listing fail until the transfer completes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> — The transfer completed. The target project owns the asset, its
        /// listing, and the subscriptions to the asset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> — The transfer didn't complete, and the service rolled back its changes.
        /// The source project owns the asset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetOwnershipTransferStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetProjectId. 
        /// <para>
        /// The ID of the project that the asset is transferred to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetProjectId { get; set; }

        /// <summary>
        /// Checks to see if the TargetProjectId property is set.
        /// </summary>
        internal bool IsSetTargetProjectId() => this.TargetProjectId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the status of the transfer was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
