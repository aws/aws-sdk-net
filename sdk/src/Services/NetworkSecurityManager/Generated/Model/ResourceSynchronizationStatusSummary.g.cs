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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// The synchronization status of a resource covered by a deployment.
    /// </summary>
    public partial class ResourceSynchronizationStatusSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property DeploymentArn. 
        /// <para>
        /// The ARN of the deployment that the synchronization status is associated with. This
        /// is absent for aggregate (cross-deployment) statuses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1010)]
        public string DeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentArn property is set.
        /// </summary>
        internal bool IsSetDeploymentArn() => this.DeploymentArn != null;

        /// <summary>
        /// Gets and sets the property EvaluatedAt. 
        /// <para>
        /// The time when the synchronization status was last evaluated.
        /// </para>
        /// </summary>
        public DateTime? EvaluatedAt { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatedAt property is set.
        /// </summary>
        internal bool IsSetEvaluatedAt() => this.EvaluatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property OutOfSyncReasons. 
        /// <para>
        /// The reasons the resource is out of sync, keyed by firewall type. This is null when
        /// the resource is in sync.
        /// </para>
        /// </summary>
        public OutOfSyncReasonsView OutOfSyncReasons { get; set; }

        /// <summary>
        /// Checks to see if the OutOfSyncReasons property is set.
        /// </summary>
        internal bool IsSetOutOfSyncReasons() => this.OutOfSyncReasons != null;

        /// <summary>
        /// Gets and sets the property RemediationIssues. 
        /// <para>
        /// Details about remediation issues, keyed by firewall type. This is null when there
        /// are no remediation issues.
        /// </para>
        /// </summary>
        public RemediationIssuesView RemediationIssues { get; set; }

        /// <summary>
        /// Checks to see if the RemediationIssues property is set.
        /// </summary>
        internal bool IsSetRemediationIssues() => this.RemediationIssues != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource whose synchronization status is reported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1010)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource, in AWS CloudFormation format.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SynchronizationStatus. 
        /// <para>
        /// The synchronization status of the resource, such as <c>IN_SYNC</c> or <c>OUT_OF_SYNC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SynchronizationStatus SynchronizationStatus { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizationStatus property is set.
        /// </summary>
        internal bool IsSetSynchronizationStatus() => this.SynchronizationStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
