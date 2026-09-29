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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for AWS monitor account integration, allowing AIDevOps to monitor AWS
    /// resources.
    /// </summary>
    public partial class AWSConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// AWS Account Id corresponding to provided resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// Account Type 'monitor' for AIDevOps monitoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitorAccountType AccountType { get; set; }

        /// <summary>
        /// Checks to see if the AccountType property is set.
        /// </summary>
        internal bool IsSetAccountType() => this.AccountType != null;

        /// <summary>
        /// Gets and sets the property AgentElevatedRoleArn. 
        /// <para>
        /// Optional IAM role ARN to be assumed by AIDevOps for elevated directed actions on behalf
        /// of the customer. Used for mutating operations gated by elevatedActionsEnabled on the
        /// AgentSpace. When not provided, only non-elevated directed actions are available for
        /// this AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AgentElevatedRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentElevatedRoleArn property is set.
        /// </summary>
        internal bool IsSetAgentElevatedRoleArn() => this.AgentElevatedRoleArn != null;

        /// <summary>
        /// Gets and sets the property AgentElevatedRoleArnStatus. 
        /// <para>
        /// Validation status of the agentElevatedRoleArn. Updated asynchronously after the customer
        /// registers an elevated role. Possible values: PENDING_CONFIRMATION (validation in progress),
        /// VALID (role validated), INVALID (validation failed).
        /// </para>
        /// </summary>
        public ValidationStatus AgentElevatedRoleArnStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentElevatedRoleArnStatus property is set.
        /// </summary>
        internal bool IsSetAgentElevatedRoleArnStatus() => this.AgentElevatedRoleArnStatus != null;

        /// <summary>
        /// Gets and sets the property AssumableRoleArn. 
        /// <para>
        /// Role ARN to be assumed by AIDevOps to operate on behalf of customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AssumableRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the AssumableRoleArn property is set.
        /// </summary>
        internal bool IsSetAssumableRoleArn() => this.AssumableRoleArn != null;
    }
}
