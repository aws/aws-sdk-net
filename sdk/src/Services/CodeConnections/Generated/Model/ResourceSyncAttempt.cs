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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
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
        private List<ResourceSyncEvent> _events = AWSConfigs.InitializeCollections ? new List<ResourceSyncEvent>() : null;
        private Revision _initialRevision;
        private DateTime? _startedAt;
        private ResourceSyncStatus _status;
        private string _target;
        private Revision _targetRevision;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The events related to a resource sync attempt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceSyncEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InitialRevision. 
        /// <para>
        /// The current state of the resource as defined in the resource's <c>config-file</c>
        /// in the linked repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Revision InitialRevision
        {
            get { return this._initialRevision; }
            set { this._initialRevision = value; }
        }

        // Check to see if InitialRevision property is set
        internal bool IsSetInitialRevision()
        {
            return this._initialRevision != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The start time for a resource sync attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

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
        [AWSProperty(Required=true)]
        public ResourceSyncStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The name of the Amazon Web Services resource that is attempted to be synchronized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRevision. 
        /// <para>
        /// The desired state of the resource as defined in the resource's <c>config-file</c>
        /// in the linked repository. Git sync attempts to update the resource to this state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Revision TargetRevision
        {
            get { return this._targetRevision; }
            set { this._targetRevision = value; }
        }

        // Check to see if TargetRevision property is set
        internal bool IsSetTargetRevision()
        {
            return this._targetRevision != null;
        }

    }
}