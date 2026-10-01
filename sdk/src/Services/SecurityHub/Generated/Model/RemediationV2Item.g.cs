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
    /// A remediation target.
    /// </summary>
    public partial class RemediationV2Item
    {
        /// <summary>
        /// Gets and sets the property Guidance. 
        /// <para>
        /// The remediation target's guidance. Returned only when <c>ShowGuidance</c> is <c>true</c>
        /// in the request.
        /// </para>
        /// </summary>
        public RemediationGuidance Guidance { get; set; }

        /// <summary>
        /// Checks to see if the Guidance property is set.
        /// </summary>
        internal bool IsSetGuidance() => this.Guidance != null;

        /// <summary>
        /// Gets and sets the property Outcome. 
        /// <para>
        /// The outcome of the remediation target's resolution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationOutcome Outcome { get; set; }

        /// <summary>
        /// Checks to see if the Outcome property is set.
        /// </summary>
        internal bool IsSetOutcome() => this.Outcome != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The remediation target's priority. Valid values are <c>Critical</c>, <c>High</c>,
        /// <c>Medium</c>, and <c>Low</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationPriority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property RemediationSummary. 
        /// <para>
        /// A summary of the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationSummaryDetail RemediationSummary { get; set; }

        /// <summary>
        /// Checks to see if the RemediationSummary property is set.
        /// </summary>
        internal bool IsSetRemediationSummary() => this.RemediationSummary != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The remediation target's associated resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationResource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the remediation target.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>New</c> specifies that the remediation target was newly identified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updated</c> specifies that the remediation target changed after it was identified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Resolved</c> specifies that the remediation target is no longer present.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetUid. 
        /// <para>
        /// The unique identifier (ID) of the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetUid { get; set; }

        /// <summary>
        /// Checks to see if the TargetUid property is set.
        /// </summary>
        internal bool IsSetTargetUid() => this.TargetUid != null;

        /// <summary>
        /// Gets and sets the property Trait. 
        /// <para>
        /// The trait associated with the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationTrait Trait { get; set; }

        /// <summary>
        /// Checks to see if the Trait property is set.
        /// </summary>
        internal bool IsSetTrait() => this.Trait != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The remediation target's last updated timestamp.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
