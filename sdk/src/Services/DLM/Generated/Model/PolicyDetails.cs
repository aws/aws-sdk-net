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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies the configuration of a lifecycle policy.
    /// </summary>
    public partial class PolicyDetails
    {
        private List<Action> _actions = new List<Action>();
        private EventSource _eventSource;
        private Parameters _parameters;
        private PolicyTypeValues _policyType;
        private List<string> _resourceTypes = new List<string>();
        private List<Schedule> _schedules = new List<Schedule>();
        private List<Tag> _targetTags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to be performed when the event-based policy is triggered. You can specify
        /// only one action per policy.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for event-based policies only. If you are creating a snapshot
        /// or AMI policy, omit this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Action> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The event that triggers the event-based policy. 
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for event-based policies only. If you are creating a snapshot
        /// or AMI policy, omit this parameter.
        /// </para>
        /// </summary>
        public EventSource EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A set of optional parameters for snapshot and AMI lifecycle policies. 
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for snapshot and AMI policies only. If you are creating
        /// an event-based policy, omit this parameter.
        /// </para>
        /// </summary>
        public Parameters Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The valid target resource types and actions a policy can manage. Specify <code>EBS_SNAPSHOT_MANAGEMENT</code>
        /// to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify
        /// <code>IMAGE_MANAGEMENT</code> to create a lifecycle policy that manages the lifecycle
        /// of EBS-backed AMIs. Specify <code>EVENT_BASED_POLICY </code> to create an event-based
        /// policy that performs specific actions when a defined event occurs in your AWS account.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>EBS_SNAPSHOT_MANAGEMENT</code>.
        /// </para>
        /// </summary>
        public PolicyTypeValues PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The target resource type for snapshot and AMI lifecycle policies. Use <code>VOLUME
        /// </code>to create snapshots of individual volumes or use <code>INSTANCE</code> to create
        /// multi-volume snapshots from the volumes for an instance.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for snapshot and AMI policies only. If you are creating
        /// an event-based policy, omit this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Schedules. 
        /// <para>
        /// The schedules of policy-defined actions for snapshot and AMI lifecycle policies. A
        /// policy can have up to four schedules—one mandatory schedule and up to three optional
        /// schedules.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for snapshot and AMI policies only. If you are creating
        /// an event-based policy, omit this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<Schedule> Schedules
        {
            get { return this._schedules; }
            set { this._schedules = value; }
        }

        // Check to see if Schedules property is set
        internal bool IsSetSchedules()
        {
            return this._schedules != null && this._schedules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetTags. 
        /// <para>
        /// The single tag that identifies targeted resources for this policy.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for snapshot and AMI policies only. If you are creating
        /// an event-based policy, omit this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> TargetTags
        {
            get { return this._targetTags; }
            set { this._targetTags = value; }
        }

        // Check to see if TargetTags property is set
        internal bool IsSetTargetTags()
        {
            return this._targetTags != null && this._targetTags.Count > 0; 
        }

    }
}