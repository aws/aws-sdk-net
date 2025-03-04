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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <c>ChangeSetSummary</c> structure describes a change set, its status, and the
    /// stack with which it's associated.
    /// </summary>
    public partial class ChangeSetSummary
    {
        private string _changeSetId;
        private string _changeSetName;
        private DateTime? _creationTime;
        private string _description;
        private ExecutionStatus _executionStatus;
        private bool? _importExistingResources;
        private bool? _includeNestedStacks;
        private string _parentChangeSetId;
        private string _rootChangeSetId;
        private string _stackId;
        private string _stackName;
        private ChangeSetStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The ID of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ChangeSetId
        {
            get { return this._changeSetId; }
            set { this._changeSetId = value; }
        }

        // Check to see if ChangeSetId property is set
        internal bool IsSetChangeSetId()
        {
            return this._changeSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ChangeSetName
        {
            get { return this._changeSetName; }
            set { this._changeSetName = value; }
        }

        // Check to see if ChangeSetName property is set
        internal bool IsSetChangeSetName()
        {
            return this._changeSetName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The start time when the change set was created, in UTC.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
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
        /// Descriptive information about the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// If the change set execution status is <c>AVAILABLE</c>, you can execute the change
        /// set. If you can't execute the change set, the status indicates why. For example, a
        /// change set might be in an <c>UNAVAILABLE</c> state because CloudFormation is still
        /// creating it or in an <c>OBSOLETE</c> state because the stack was already updated.
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ImportExistingResources. 
        /// <para>
        /// Indicates if the change set imports resources that already exist.
        /// </para>
        /// </summary>
        public bool? ImportExistingResources
        {
            get { return this._importExistingResources; }
            set { this._importExistingResources = value; }
        }

        // Check to see if ImportExistingResources property is set
        internal bool IsSetImportExistingResources()
        {
            return this._importExistingResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeNestedStacks. 
        /// <para>
        /// Specifies the current setting of <c>IncludeNestedStacks</c> for the change set.
        /// </para>
        /// </summary>
        public bool? IncludeNestedStacks
        {
            get { return this._includeNestedStacks; }
            set { this._includeNestedStacks = value; }
        }

        // Check to see if IncludeNestedStacks property is set
        internal bool IsSetIncludeNestedStacks()
        {
            return this._includeNestedStacks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentChangeSetId. 
        /// <para>
        /// The parent change set ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ParentChangeSetId
        {
            get { return this._parentChangeSetId; }
            set { this._parentChangeSetId = value; }
        }

        // Check to see if ParentChangeSetId property is set
        internal bool IsSetParentChangeSetId()
        {
            return this._parentChangeSetId != null;
        }

        /// <summary>
        /// Gets and sets the property RootChangeSetId. 
        /// <para>
        /// The root change set ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string RootChangeSetId
        {
            get { return this._rootChangeSetId; }
            set { this._rootChangeSetId = value; }
        }

        // Check to see if RootChangeSetId property is set
        internal bool IsSetRootChangeSetId()
        {
            return this._rootChangeSetId != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack with which the change set is associated.
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
        /// The name of the stack with which the change set is associated.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the change set, such as <c>CREATE_PENDING</c>, <c>CREATE_COMPLETE</c>,
        /// or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ChangeSetStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A description of the change set's status. For example, if your change set is in the
        /// <c>FAILED</c> state, CloudFormation shows the error message.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}