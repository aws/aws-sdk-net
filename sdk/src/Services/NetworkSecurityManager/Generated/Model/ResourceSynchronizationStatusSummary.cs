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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
        private string _accountId;
        private string _deploymentArn;
        private DateTime? _evaluatedAt;
        private OutOfSyncReasonsView _outOfSyncReasons;
        private RemediationIssuesView _remediationIssues;
        private string _resourceArn;
        private ResourceType _resourceType;
        private SynchronizationStatus _synchronizationStatus;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentArn. 
        /// <para>
        /// The ARN of the deployment that the synchronization status is associated with. This
        /// is absent for aggregate (cross-deployment) statuses.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1010)]
        public string DeploymentArn
        {
            get { return this._deploymentArn; }
            set { this._deploymentArn = value; }
        }

        // Check to see if DeploymentArn property is set
        internal bool IsSetDeploymentArn()
        {
            return this._deploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatedAt. 
        /// <para>
        /// The time when the synchronization status was last evaluated.
        /// </para>
        /// </summary>
        public DateTime? EvaluatedAt
        {
            get { return this._evaluatedAt; }
            set { this._evaluatedAt = value; }
        }

        // Check to see if EvaluatedAt property is set
        internal bool IsSetEvaluatedAt()
        {
            return this._evaluatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutOfSyncReasons. 
        /// <para>
        /// The reasons the resource is out of sync, keyed by firewall type. This is null when
        /// the resource is in sync.
        /// </para>
        /// </summary>
        public OutOfSyncReasonsView OutOfSyncReasons
        {
            get { return this._outOfSyncReasons; }
            set { this._outOfSyncReasons = value; }
        }

        // Check to see if OutOfSyncReasons property is set
        internal bool IsSetOutOfSyncReasons()
        {
            return this._outOfSyncReasons != null;
        }

        /// <summary>
        /// Gets and sets the property RemediationIssues. 
        /// <para>
        /// Details about remediation issues, keyed by firewall type. This is null when there
        /// are no remediation issues.
        /// </para>
        /// </summary>
        public RemediationIssuesView RemediationIssues
        {
            get { return this._remediationIssues; }
            set { this._remediationIssues = value; }
        }

        // Check to see if RemediationIssues property is set
        internal bool IsSetRemediationIssues()
        {
            return this._remediationIssues != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource whose synchronization status is reported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1010)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource, in AWS CloudFormation format.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SynchronizationStatus. 
        /// <para>
        /// The synchronization status of the resource, such as <c>IN_SYNC</c> or <c>OUT_OF_SYNC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SynchronizationStatus SynchronizationStatus
        {
            get { return this._synchronizationStatus; }
            set { this._synchronizationStatus = value; }
        }

        // Check to see if SynchronizationStatus property is set
        internal bool IsSetSynchronizationStatus()
        {
            return this._synchronizationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}