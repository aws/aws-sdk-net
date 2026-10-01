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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Nests a stack as a resource in a top-level template. Nested stacks are stacks created
    /// as resources for another stack.
    /// </summary>
    public partial class AwsCloudFormationStackDetails
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities allowed in the stack. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the stack was created. 
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-defined description associated with the stack. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisableRollback. 
        /// <para>
        /// Boolean to enable or disable rollback on stack creation failures. 
        /// </para>
        /// </summary>
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// Checks to see if the DisableRollback property is set.
        /// </summary>
        internal bool IsSetDisableRollback() => this.DisableRollback.HasValue;

        /// <summary>
        /// Gets and sets the property DriftInformation. 
        /// <para>
        /// Information about whether a stack's actual configuration differs, or has drifted,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. 
        /// </para>
        /// </summary>
        public AwsCloudFormationStackDriftInformationDetails DriftInformation { get; set; }

        /// <summary>
        /// Checks to see if the DriftInformation property is set.
        /// </summary>
        internal bool IsSetDriftInformation() => this.DriftInformation != null;

        /// <summary>
        /// Gets and sets the property EnableTerminationProtection. 
        /// <para>
        /// Whether termination protection is enabled for the stack. 
        /// </para>
        /// </summary>
        public bool? EnableTerminationProtection { get; set; }

        /// <summary>
        /// Checks to see if the EnableTerminationProtection property is set.
        /// </summary>
        internal bool IsSetEnableTerminationProtection() => this.EnableTerminationProtection.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the nested stack was last updated. This field will only be returned if the
        /// stack has been updated at least once.
        /// </para>
        /// </summary>
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property NotificationArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Amazon SNS topic to which stack-related events
        /// are published. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotificationArns property is set.
        /// </summary>
        internal bool IsSetNotificationArns() => this.NotificationArns != null && (this.NotificationArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// A list of output structures. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCloudFormationStackOutputsDetails> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCloudFormationStackOutputsDetails>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that's associated with the stack. 
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// Unique identifier of the stack. 
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
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property StackStatus. 
        /// <para>
        /// Current status of the stack. 
        /// </para>
        /// </summary>
        public string StackStatus { get; set; }

        /// <summary>
        /// Checks to see if the StackStatus property is set.
        /// </summary>
        internal bool IsSetStackStatus() => this.StackStatus != null;

        /// <summary>
        /// Gets and sets the property StackStatusReason. 
        /// <para>
        /// Success or failure message associated with the stack status. 
        /// </para>
        /// </summary>
        public string StackStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StackStatusReason property is set.
        /// </summary>
        internal bool IsSetStackStatusReason() => this.StackStatusReason != null;

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The length of time, in minutes, that CloudFormation waits for the nested stack to
        /// reach the <c>CREATE_COMPLETE</c> state. 
        /// </para>
        /// </summary>
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutInMinutes() => this.TimeoutInMinutes.HasValue;
    }
}
