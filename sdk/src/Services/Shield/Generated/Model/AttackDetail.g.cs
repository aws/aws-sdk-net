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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// The details of a DDoS attack.
    /// </summary>
    public partial class AttackDetail
    {
        /// <summary>
        /// Gets and sets the property AttackCounters. 
        /// <para>
        /// List of counters that describe the attack for the specified time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizedCounter> AttackCounters { get; set; } = AWSConfigs.InitializeCollections ? new List<SummarizedCounter>() : null;

        /// <summary>
        /// Checks to see if the AttackCounters property is set.
        /// </summary>
        internal bool IsSetAttackCounters() => this.AttackCounters != null && (this.AttackCounters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttackId. 
        /// <para>
        /// The unique identifier (ID) of the attack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AttackId { get; set; }

        /// <summary>
        /// Checks to see if the AttackId property is set.
        /// </summary>
        internal bool IsSetAttackId() => this.AttackId != null;

        /// <summary>
        /// Gets and sets the property AttackProperties. 
        /// <para>
        /// The array of objects that provide details of the Shield event. 
        /// </para>
        ///  
        /// <para>
        /// For infrastructure layer events (L3 and L4 events), you can view metrics for top contributors
        /// in Amazon CloudWatch metrics. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/monitoring-cloudwatch.html#set-ddos-alarms">Shield
        /// metrics and alarms</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttackProperty> AttackProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<AttackProperty>() : null;

        /// <summary>
        /// Checks to see if the AttackProperties property is set.
        /// </summary>
        internal bool IsSetAttackProperties() => this.AttackProperties != null && (this.AttackProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the attack ended, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Mitigations. 
        /// <para>
        /// List of mitigation actions taken for the attack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Mitigation> Mitigations { get; set; } = AWSConfigs.InitializeCollections ? new List<Mitigation>() : null;

        /// <summary>
        /// Checks to see if the Mitigations property is set.
        /// </summary>
        internal bool IsSetMitigations() => this.Mitigations != null && (this.Mitigations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the resource that was attacked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the attack started, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SubResources. 
        /// <para>
        /// If applicable, additional detail about the resource being attacked, for example, IP
        /// address or URL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubResourceSummary> SubResources { get; set; } = AWSConfigs.InitializeCollections ? new List<SubResourceSummary>() : null;

        /// <summary>
        /// Checks to see if the SubResources property is set.
        /// </summary>
        internal bool IsSetSubResources() => this.SubResources != null && (this.SubResources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
