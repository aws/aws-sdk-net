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
    /// The <c>StackSummary</c> Data Type
    /// </summary>
    public partial class StackSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the stack was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The time the stack was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletionTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionTime property is set.
        /// </summary>
        internal bool IsSetDeletionTime() => this.DeletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property DriftInformation. 
        /// <para>
        /// Summarizes information about whether a stack's actual configuration differs, or has
        /// <i>drifted</i>, from its expected configuration, as defined in the stack template
        /// and any values specified as template parameters. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// </para>
        /// </summary>
        public StackDriftInformationSummary DriftInformation { get; set; }

        /// <summary>
        /// Checks to see if the DriftInformation property is set.
        /// </summary>
        internal bool IsSetDriftInformation() => this.DriftInformation != null;

        /// <summary>
        /// Gets and sets the property LastOperations. 
        /// <para>
        /// Information about the most recent operations performed on this stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OperationEntry> LastOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<OperationEntry>() : null;

        /// <summary>
        /// Checks to see if the LastOperations property is set.
        /// </summary>
        internal bool IsSetLastOperations() => this.LastOperations != null && (this.LastOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the stack was last updated. This field will only be returned if the stack
        /// has been updated at least once.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// For nested stacks, the stack ID of the direct parent of this stack. For the first
        /// level of nested stacks, the root stack is also the parent stack.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">Nested
        /// stacks</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId != null;

        /// <summary>
        /// Gets and sets the property RootId. 
        /// <para>
        /// For nested stacks, the stack ID of the top-level stack to which the nested stack ultimately
        /// belongs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">Nested
        /// stacks</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public string RootId { get; set; }

        /// <summary>
        /// Checks to see if the RootId property is set.
        /// </summary>
        internal bool IsSetRootId() => this.RootId != null;

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// Unique stack identifier.
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
        /// The name associated with the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property StackStatus. 
        /// <para>
        /// The current status of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StackStatus StackStatus { get; set; }

        /// <summary>
        /// Checks to see if the StackStatus property is set.
        /// </summary>
        internal bool IsSetStackStatus() => this.StackStatus != null;

        /// <summary>
        /// Gets and sets the property StackStatusReason. 
        /// <para>
        /// Success/Failure message associated with the stack status.
        /// </para>
        /// </summary>
        public string StackStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StackStatusReason property is set.
        /// </summary>
        internal bool IsSetStackStatusReason() => this.StackStatusReason != null;

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// The template description of the template used to create the stack.
        /// </para>
        /// </summary>
        public string TemplateDescription { get; set; }

        /// <summary>
        /// Checks to see if the TemplateDescription property is set.
        /// </summary>
        internal bool IsSetTemplateDescription() => this.TemplateDescription != null;
    }
}
