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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Represents the features configuration for a hosted zone, including the status of various
    /// features and any associated failure reasons.
    /// </summary>
    public partial class HostedZoneFeatures
    {
        /// <summary>
        /// Gets and sets the property AcceleratedRecoveryStatus. 
        /// <para>
        /// The current status of accelerated recovery for the hosted zone.
        /// </para>
        /// </summary>
        public AcceleratedRecoveryStatus AcceleratedRecoveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratedRecoveryStatus property is set.
        /// </summary>
        internal bool IsSetAcceleratedRecoveryStatus() => this.AcceleratedRecoveryStatus != null;

        /// <summary>
        /// Gets and sets the property PublicDNSFallbackStatus. 
        /// <para>
        /// The current status of public DNS fallback for the hosted zone. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Public DNS fallback is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c>: Public DNS fallback is disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLING</c>: A request to enable public DNS fallback is still propagating.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLING</c>: A request to disable public DNS fallback is still propagating.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FeatureStatus PublicDNSFallbackStatus { get; set; }

        /// <summary>
        /// Checks to see if the PublicDNSFallbackStatus property is set.
        /// </summary>
        internal bool IsSetPublicDNSFallbackStatus() => this.PublicDNSFallbackStatus != null;

        /// <summary>
        /// Gets and sets the property ChangeHistory. 
        /// <para>
        /// The status of Change History for the hosted zone, and the earliest time from which
        /// you can read its change history.
        /// </para>
        /// </summary>
        public ChangeHistoryFeature ChangeHistory { get; set; }

        /// <summary>
        /// Checks to see if the ChangeHistory property is set.
        /// </summary>
        internal bool IsSetChangeHistory() => this.ChangeHistory != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// Information about any failures that occurred when attempting to enable or configure
        /// features for the hosted zone.
        /// </para>
        /// </summary>
        public HostedZoneFailureReasons FailureReasons { get; set; }

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null;

        /// <summary>
        /// Gets and sets the property ChangeGuardrails. 
        /// <para>
        /// The name and status of each Change Guardrail for the hosted zone. For the guardrail
        /// names and statuses, see <c>ChangeGuardrail</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ChangeGuardrail> ChangeGuardrails { get; set; } = AWSConfigs.InitializeCollections ? new List<ChangeGuardrail>() : null;

        /// <summary>
        /// Checks to see if the ChangeGuardrails property is set.
        /// </summary>
        internal bool IsSetChangeGuardrails() => this.ChangeGuardrails != null && (this.ChangeGuardrails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
