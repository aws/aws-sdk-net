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
    /// Information about a resource sync attempt.
    /// </summary>
    public partial class ResourceSyncAttempt
    {
        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The events related to a resource sync attempt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ResourceSyncEvent> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceSyncEvent>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InitialRevision. 
        /// <para>
        /// The current state of the resource as defined in the resource's <c>config-file</c>
        /// in the linked repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Revision InitialRevision { get; set; }

        /// <summary>
        /// Checks to see if the InitialRevision property is set.
        /// </summary>
        internal bool IsSetInitialRevision() => this.InitialRevision != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The start time for a resource sync attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for a resource sync attempt. The follow are valid statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SYNC-INITIATED - A resource sync attempt has been created and will begin soon.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SYNCING - Syncing has started and work is being done to reconcile state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SYNCED - Syncing has completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SYNC_FAILED - A resource sync attempt has failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceSyncStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The name of the Amazon Web Services resource that is attempted to be synchronized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TargetRevision. 
        /// <para>
        /// The desired state of the resource as defined in the resource's <c>config-file</c>
        /// in the linked repository. Git sync attempts to update the resource to this state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Revision TargetRevision { get; set; }

        /// <summary>
        /// Checks to see if the TargetRevision property is set.
        /// </summary>
        internal bool IsSetTargetRevision() => this.TargetRevision != null;
    }
}
