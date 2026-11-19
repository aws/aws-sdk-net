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
    /// Describes the current rollout state of an Amazon Web Services Organization source
    /// configuration, including the number of accounts that have been deployed to and any
    /// issues encountered during deployment.
    /// </summary>
    public partial class OrgSourceDeploymentState
    {
        /// <summary>
        /// Gets and sets the property DeployedAccountCount. 
        /// <para>
        /// The number of accounts in the targeted Amazon Web Services Organization or organizational
        /// unit that have successfully been deployed to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DeployedAccountCount { get; set; }

        /// <summary>
        /// Checks to see if the DeployedAccountCount property is set.
        /// </summary>
        internal bool IsSetDeployedAccountCount() => this.DeployedAccountCount.HasValue;

        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// The issues encountered while deploying the source configuration across the accounts
        /// in the Amazon Web Services Organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<OrgSourceIssue> Issues { get; set; } = AWSConfigs.InitializeCollections ? new List<OrgSourceIssue>() : null;

        /// <summary>
        /// Checks to see if the Issues property is set.
        /// </summary>
        internal bool IsSetIssues() => this.Issues != null && (this.Issues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastEvaluatedAt. 
        /// <para>
        /// The timestamp of the most recent evaluation of the organization-wide deployment state.
        /// </para>
        /// </summary>
        public DateTime? LastEvaluatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedAt property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedAt() => this.LastEvaluatedAt.HasValue;
    }
}
