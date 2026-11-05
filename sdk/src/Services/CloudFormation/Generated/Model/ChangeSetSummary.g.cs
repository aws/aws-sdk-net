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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <c>ChangeSetSummary</c> structure describes a change set, its status, and the
    /// stack with which it's associated.
    /// </summary>
    public partial class ChangeSetSummary
    {
        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The ID of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetId property is set.
        /// </summary>
        internal bool IsSetChangeSetId() => this.ChangeSetId != null;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name of the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetName property is set.
        /// </summary>
        internal bool IsSetChangeSetName() => this.ChangeSetName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The start time when the change set was created, in UTC.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive information about the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// If the change set execution status is <c>AVAILABLE</c>, you can execute the change
        /// set. If you can't execute the change set, the status indicates why. For example, a
        /// change set might be in an <c>UNAVAILABLE</c> state because CloudFormation is still
        /// creating it or in an <c>OBSOLETE</c> state because the stack was already updated.
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property ImportExistingResources. 
        /// <para>
        /// Indicates if the change set imports resources that already exist.
        /// </para>
        /// </summary>
        public bool? ImportExistingResources { get; set; }

        /// <summary>
        /// Checks to see if the ImportExistingResources property is set.
        /// </summary>
        internal bool IsSetImportExistingResources() => this.ImportExistingResources.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeNestedStacks. 
        /// <para>
        /// Specifies the current setting of <c>IncludeNestedStacks</c> for the change set.
        /// </para>
        /// </summary>
        public bool? IncludeNestedStacks { get; set; }

        /// <summary>
        /// Checks to see if the IncludeNestedStacks property is set.
        /// </summary>
        internal bool IsSetIncludeNestedStacks() => this.IncludeNestedStacks.HasValue;

        /// <summary>
        /// Gets and sets the property ParentChangeSetId. 
        /// <para>
        /// The parent change set ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ParentChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ParentChangeSetId property is set.
        /// </summary>
        internal bool IsSetParentChangeSetId() => this.ParentChangeSetId != null;

        /// <summary>
        /// Gets and sets the property RootChangeSetId. 
        /// <para>
        /// The root change set ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string RootChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the RootChangeSetId property is set.
        /// </summary>
        internal bool IsSetRootChangeSetId() => this.RootChangeSetId != null;

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack with which the change set is associated.
        /// </para>
        /// </summary>
        public string StackId { get; set; }

        /// <summary>
        /// Checks to see if the StackId property is set.
        /// </summary>
        internal bool IsSetStackId() => this.StackId != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack with which the change set is associated.
        /// </para>
        /// </summary>
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the change set, such as <c>CREATE_PENDING</c>, <c>CREATE_COMPLETE</c>,
        /// or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ChangeSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A description of the change set's status. For example, if your change set is in the
        /// <c>FAILED</c> state, CloudFormation shows the error message.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
