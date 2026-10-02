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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The capabilities enabled for a GitHub resource integration.
    /// </summary>
    public partial class GitHubResourceCapabilities
    {
        /// <summary>
        /// Gets and sets the property LeaveComments. 
        /// <para>
        /// Indicates whether the integration can leave comments on pull requests.
        /// </para>
        /// </summary>
        public bool? LeaveComments { get; set; }

        /// <summary>
        /// Checks to see if the LeaveComments property is set.
        /// </summary>
        internal bool IsSetLeaveComments() => this.LeaveComments.HasValue;

        /// <summary>
        /// Gets and sets the property RemediateCode. 
        /// <para>
        /// Indicates whether the integration can create code remediation pull requests.
        /// </para>
        /// </summary>
        public bool? RemediateCode { get; set; }

        /// <summary>
        /// Checks to see if the RemediateCode property is set.
        /// </summary>
        internal bool IsSetRemediateCode() => this.RemediateCode.HasValue;

        /// <summary>
        /// Gets and sets the property TriggerFilterGroups. 
        /// <para>
        /// The filter groups that control which pull request events start an automatic code review
        /// when <c>leaveComments</c> is enabled. A review starts when any group matches. If you
        /// omit this, a review starts on <c>PULL_REQUEST_READY_FOR_REVIEW</c> events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<TriggerFilterGroup> TriggerFilterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<TriggerFilterGroup>() : null;

        /// <summary>
        /// Checks to see if the TriggerFilterGroups property is set.
        /// </summary>
        internal bool IsSetTriggerFilterGroups() => this.TriggerFilterGroups != null && (this.TriggerFilterGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
