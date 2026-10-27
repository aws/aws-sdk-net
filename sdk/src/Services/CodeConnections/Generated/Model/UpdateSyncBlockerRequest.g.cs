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

namespace Amazon.CodeConnections.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSyncBlocker operation. Allows you to update
    /// the status of a sync blocker, resolving the blocker and allowing syncing to continue.
    /// </summary>
    public partial class UpdateSyncBlockerRequest : AmazonCodeConnectionsRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sync blocker to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResolvedReason. 
        /// <para>
        /// The reason for resolving the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 250)]
        public string ResolvedReason { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedReason property is set.
        /// </summary>
        internal bool IsSetResolvedReason() => this.ResolvedReason != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource for the sync blocker to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The sync type of the sync blocker to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncConfigurationType SyncType { get; set; }

        /// <summary>
        /// Checks to see if the SyncType property is set.
        /// </summary>
        internal bool IsSetSyncType() => this.SyncType != null;
    }
}
