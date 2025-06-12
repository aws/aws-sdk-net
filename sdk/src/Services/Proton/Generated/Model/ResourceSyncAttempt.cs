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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Detail data for a resource sync attempt activated by a push to a repository.
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
        /// An array of events with detail data.
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
        /// Detail data for the initial repository commit, path and push.
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
        /// The time when the sync attempt started.
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
        /// The status of the sync attempt.
        /// </para>
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
        /// The resource that is synced to.
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
        /// Detail data for the target revision.
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