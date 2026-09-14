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
    /// A summary of a telemetry rule's key properties.
    /// </summary>
    public partial class TelemetryRuleSummary
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
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        ///  The timestamp when the telemetry rule was last modified. 
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimeStamp() => this.LastUpdateTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  The type of Amazon Web Services resource the rule applies to. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

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
        /// Gets and sets the property TelemetrySourceTypes. 
        /// <para>
        ///  The types of telemetry sources configured for this rule, such as VPC Flow Logs or
        /// EKS audit logs. TelemetrySourceTypes must be correlated with the specific resource
        /// type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TelemetrySourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TelemetrySourceTypes property is set.
        /// </summary>
        internal bool IsSetTelemetrySourceTypes() => this.TelemetrySourceTypes != null && (this.TelemetrySourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetryType. 
        /// <para>
        ///  The type of telemetry (Logs, Metrics, or Traces) the rule configures. 
        /// </para>
        /// </summary>
        public TelemetryType TelemetryType { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryType property is set.
        /// </summary>
        internal bool IsSetTelemetryType() => this.TelemetryType != null;
    }
}
