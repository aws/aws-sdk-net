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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _creationTime;
        private string _description;
        private bool? _disableRollback;
        private AwsCloudFormationStackDriftInformationDetails _driftInformation;
        private bool? _enableTerminationProtection;
        private string _lastUpdatedTime;
        private List<string> _notificationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AwsCloudFormationStackOutputsDetails> _outputs = AWSConfigs.InitializeCollections ? new List<AwsCloudFormationStackOutputsDetails>() : null;
        private string _roleArn;
        private string _stackId;
        private string _stackName;
        private string _stackStatus;
        private string _stackStatusReason;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities allowed in the stack. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && (this._capabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the stack was created. 
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
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
        /// Boolean to enable or disable rollback on stack creation failures. 
        /// </para>
        /// </summary>
        public bool? DisableRollback
        {
            get { return this._disableRollback; }
            set { this._disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this._disableRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DriftInformation. 
        /// <para>
        /// Information about whether a stack's actual configuration differs, or has drifted,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. 
        /// </para>
        /// </summary>
        public AwsCloudFormationStackDriftInformationDetails DriftInformation
        {
            get { return this._driftInformation; }
            set { this._driftInformation = value; }
        }

        // Check to see if DriftInformation property is set
        internal bool IsSetDriftInformation()
        {
            return this._driftInformation != null;
        }

        /// <summary>
        /// Gets and sets the property EnableTerminationProtection. 
        /// <para>
        /// Whether termination protection is enabled for the stack. 
        /// </para>
        /// </summary>
        public bool? EnableTerminationProtection
        {
            get { return this._enableTerminationProtection; }
            set { this._enableTerminationProtection = value; }
        }

        // Check to see if EnableTerminationProtection property is set
        internal bool IsSetEnableTerminationProtection()
        {
            return this._enableTerminationProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the nested stack was last updated. This field will only be returned if the
        /// stack has been updated at least once.
        /// </para>
        /// </summary>
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Amazon SNS topic to which stack-related events
        /// are published. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationArns
        {
            get { return this._notificationArns; }
            set { this._notificationArns = value; }
        }

        // Check to see if NotificationArns property is set
        internal bool IsSetNotificationArns()
        {
            return this._notificationArns != null && (this._notificationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// A list of output structures. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCloudFormationStackOutputsDetails> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that's associated with the stack. 
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
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
        public string StackStatus
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
        /// Success or failure message associated with the stack status. 
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
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The length of time, in minutes, that CloudFormation waits for the nested stack to
        /// reach the <c>CREATE_COMPLETE</c> state. 
        /// </para>
        /// </summary>
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}