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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the GetTelemetryRule operation.
    /// </summary>
    public partial class GetTelemetryRuleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        ///  The timestamp when the telemetry rule was created. 
        /// </para>
        /// </summary>
        public long? CreatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimeStamp() => this.CreatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        ///  The Amazon Web Services Region where the telemetry rule was originally created. For
        /// replicated rules in spoke regions, this indicates the region that manages the rule.
        /// For rules created without multi-region scope, this field is not present. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property IsReplicated. 
        /// <para>
        ///  Indicates whether this telemetry rule is a replica that was created in this region
        /// through multi-region fan-out from the home region. Replicated rules cannot be directly
        /// updated or deleted in the spoke region. To modify a replicated rule, make changes
        /// in the home region. 
        /// </para>
        /// </summary>
        public bool? IsReplicated { get; set; }

        /// <summary>
        /// Checks to see if the IsReplicated property is set.
        /// </summary>
        internal bool IsSetIsReplicated() => this.IsReplicated.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        ///  The timestamp when the telemetry rule was last updated. 
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimeStamp() => this.LastUpdateTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property RegionStatuses. 
        /// <para>
        ///  A list of per-region replication statuses for the telemetry rule. Each entry indicates
        /// the replication status of the rule in a specific spoke region. This field is only
        /// present for rules created with multi-region scope. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegionStatus> RegionStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<RegionStatus>() : null;

        /// <summary>
        /// Checks to see if the RegionStatuses property is set.
        /// </summary>
        internal bool IsSetRegionStatuses() => this.RegionStatuses != null && (this.RegionStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the telemetry rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string RuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleArn property is set.
        /// </summary>
        internal bool IsSetRuleArn() => this.RuleArn != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        ///  The name of the telemetry rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property TelemetryRule. 
        /// <para>
        ///  The configuration details of the telemetry rule. 
        /// </para>
        /// </summary>
        public TelemetryRule TelemetryRule { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryRule property is set.
        /// </summary>
        internal bool IsSetTelemetryRule() => this.TelemetryRule != null;
    }
}
