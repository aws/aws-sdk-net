/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The Stack data type.</para>
    /// </summary>
    public class Stack
    {
        
        private string stackId;
        private string stackName;
        private string description;
        private List<Parameter> parameters = new List<Parameter>();
        private DateTime? creationTime;
        private DateTime? lastUpdatedTime;
        private StackStatus stackStatus;
        private string stackStatusReason;
        private bool? disableRollback;
        private List<string> notificationARNs = new List<string>();
        private int? timeoutInMinutes;
        private List<string> capabilities = new List<string>();
        private List<Output> outputs = new List<Output>();
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// Unique identifier of the stack.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The name associated with the stack.
        ///  
        /// </summary>
        public string StackName
        {
            get { return this.stackName; }
            set { this.stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// User defined description associated with the stack.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// A list of <c>Parameter</c> structures.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

        /// <summary>
        /// Time at which the stack was created.
        ///  
        /// </summary>
        public DateTime CreationTime
        {
            get { return this.creationTime ?? default(DateTime); }
            set { this.creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this.creationTime.HasValue;
        }

        /// <summary>
        /// The time the stack was last updated. This field will only be returned if the stack has been updated at least once.
        ///  
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this.lastUpdatedTime ?? default(DateTime); }
            set { this.lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this.lastUpdatedTime.HasValue;
        }

        /// <summary>
        /// Current status of the stack.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATE_IN_PROGRESS, CREATE_FAILED, CREATE_COMPLETE, ROLLBACK_IN_PROGRESS, ROLLBACK_FAILED, ROLLBACK_COMPLETE, DELETE_IN_PROGRESS, DELETE_FAILED, DELETE_COMPLETE, UPDATE_IN_PROGRESS, UPDATE_COMPLETE_CLEANUP_IN_PROGRESS, UPDATE_COMPLETE, UPDATE_ROLLBACK_IN_PROGRESS, UPDATE_ROLLBACK_FAILED, UPDATE_ROLLBACK_COMPLETE_CLEANUP_IN_PROGRESS, UPDATE_ROLLBACK_COMPLETE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StackStatus StackStatus
        {
            get { return this.stackStatus; }
            set { this.stackStatus = value; }
        }

        // Check to see if StackStatus property is set
        internal bool IsSetStackStatus()
        {
            return this.stackStatus != null;
        }

        /// <summary>
        /// Success/failure message associated with the stack status.
        ///  
        /// </summary>
        public string StackStatusReason
        {
            get { return this.stackStatusReason; }
            set { this.stackStatusReason = value; }
        }

        // Check to see if StackStatusReason property is set
        internal bool IsSetStackStatusReason()
        {
            return this.stackStatusReason != null;
        }

        /// <summary>
        /// Boolean to enable or disable rollback on stack creation failures: <ul> <li><c>true</c>: disable rollback</li> <li><c>false</c>: enable
        /// rollback</li> </ul>
        ///  
        /// </summary>
        public bool DisableRollback
        {
            get { return this.disableRollback ?? default(bool); }
            set { this.disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this.disableRollback.HasValue;
        }

        /// <summary>
        /// SNS topic ARNs to which stack related events are published.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> NotificationARNs
        {
            get { return this.notificationARNs; }
            set { this.notificationARNs = value; }
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this.notificationARNs.Count > 0;
        }

        /// <summary>
        /// The amount of time within which stack creation should complete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int TimeoutInMinutes
        {
            get { return this.timeoutInMinutes ?? default(int); }
            set { this.timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this.timeoutInMinutes.HasValue;
        }

        /// <summary>
        /// The capabilities allowed in the stack.
        ///  
        /// </summary>
        public List<string> Capabilities
        {
            get { return this.capabilities; }
            set { this.capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this.capabilities.Count > 0;
        }

        /// <summary>
        /// A list of output structures.
        ///  
        /// </summary>
        public List<Output> Outputs
        {
            get { return this.outputs; }
            set { this.outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this.outputs.Count > 0;
        }

        /// <summary>
        /// A list of <c>Tag</c>s that specify cost allocation information for the stack.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
