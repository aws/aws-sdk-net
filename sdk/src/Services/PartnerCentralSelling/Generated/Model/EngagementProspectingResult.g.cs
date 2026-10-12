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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Contains the result of processing a single engagement within a prospecting task. Each
    /// engagement is processed independently, so individual engagements can succeed or fail
    /// regardless of other engagements in the same task.
    /// </summary>
    public partial class EngagementProspectingResult
    {
        /// <summary>
        /// Gets and sets the property EngagementContextId. 
        /// <para>
        /// The identifier of the prospecting context created for this engagement. This field
        /// is only populated when the engagement was processed successfully (status is <c>COMPLETED</c>).
        /// Use this identifier to reference the prospecting context in subsequent operations.
        /// </para>
        /// </summary>
        public string EngagementContextId { get; set; }

        /// <summary>
        /// Checks to see if the EngagementContextId property is set.
        /// </summary>
        internal bool IsSetEngagementContextId() => this.EngagementContextId != null;

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        /// The unique identifier of the engagement that was processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EngagementIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EngagementIdentifier property is set.
        /// </summary>
        internal bool IsSetEngagementIdentifier() => this.EngagementIdentifier != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable description of the failure for this engagement, including suggested
        /// recovery steps. This field is only populated when <c>Status</c> is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// An enumerated code indicating the reason this engagement failed to process. This field
        /// is only populated when <c>Status</c> is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string ReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the ReasonCode property is set.
        /// </summary>
        internal bool IsSetReasonCode() => this.ReasonCode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The processing status of this specific engagement. Possible values are <c>PENDING</c>,
        /// <c>IN_PROGRESS</c>, <c>COMPLETED</c>, and <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProspectingTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
