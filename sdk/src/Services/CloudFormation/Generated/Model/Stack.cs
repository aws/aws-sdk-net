/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The Stack data type.
    /// </summary>
    public partial class Stack
    {
        private List<string> _capabilities = new List<string>();
        private DateTime? _creationTime;
        private string _description;
        private bool? _disableRollback;
        private DateTime? _lastUpdatedTime;
        private List<string> _notificationARNs = new List<string>();
        private List<Output> _outputs = new List<Output>();
        private List<Parameter> _parameters = new List<Parameter>();
        private string _stackId;
        private string _stackName;
        private StackStatus _stackStatus;
        private string _stackStatusReason;
        private List<Tag> _tags = new List<Tag>();
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities allowed in the stack.
        /// </para>
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the stack was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-defined description associated with the stack.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisableRollback. 
        /// <para>
        /// Boolean to enable or disable rollback on stack creation failures:
        /// </para>
        ///  
        /// <para>
        ///  <ul> <li><code>true</code>: disable rollback</li> <li><code>false</code>: enable
        /// rollback</li> </ul> 
        /// </para>
        /// </summary>
        public bool DisableRollback
        {
            get { return this._disableRollback.GetValueOrDefault(); }
            set { this._disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this._disableRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the stack was last updated. This field will only be returned if the stack
        /// has been updated at least once.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationARNs. 
        /// <para>
        /// SNS topic ARNs to which stack related events are published.
        /// </para>
        /// </summary>
        public List<string> NotificationARNs
        {
            get { return this._notificationARNs; }
            set { this._notificationARNs = value; }
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this._notificationARNs != null && this._notificationARNs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// A list of output structures.
        /// </para>
        /// </summary>
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of <code>Parameter</code> structures.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// Unique identifier of the stack.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with the stack.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property StackStatus. 
        /// <para>
        /// Current status of the stack.
        /// </para>
        /// </summary>
        public StackStatus StackStatus
        {
            get { return this._stackStatus; }
            set { this._stackStatus = value; }
        }

        // Check to see if StackStatus property is set
        internal bool IsSetStackStatus()
        {
            return this._stackStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StackStatusReason. 
        /// <para>
        /// Success/failure message associated with the stack status.
        /// </para>
        /// </summary>
        public string StackStatusReason
        {
            get { return this._stackStatusReason; }
            set { this._stackStatusReason = value; }
        }

        // Check to see if StackStatusReason property is set
        internal bool IsSetStackStatusReason()
        {
            return this._stackStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <code>Tag</code>s that specify information about the stack.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The amount of time within which stack creation should complete.
        /// </para>
        /// </summary>
        public int TimeoutInMinutes
        {
            get { return this._timeoutInMinutes.GetValueOrDefault(); }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}