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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the signals involved in the attack sequence.
    /// </summary>
    public partial class Signal
    {
        /// <summary>
        /// Gets and sets the property Activities. 
        /// <para>
        /// Contains information about the activities, such as API calls, that were observed for
        /// this signal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Activity> Activities { get; set; } = AWSConfigs.InitializeCollections ? new List<Activity>() : null;

        /// <summary>
        /// Checks to see if the Activities property is set.
        /// </summary>
        internal bool IsSetActivities() => this.Activities != null && (this.Activities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ActorIds. 
        /// <para>
        /// Information about the IDs of the threat actors involved in the signal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public List<string> ActorIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActorIds property is set.
        /// </summary>
        internal bool IsSetActorIds() => this.ActorIds != null && (this.ActorIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of times this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the first finding or activity related to this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndpointIds. 
        /// <para>
        /// Information about the endpoint IDs associated with this signal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public List<string> EndpointIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EndpointIds property is set.
        /// </summary>
        internal bool IsSetEndpointIds() => this.EndpointIds != null && (this.EndpointIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirstSeenAt. 
        /// <para>
        /// The timestamp when the first finding or activity related to this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? FirstSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstSeenAt property is set.
        /// </summary>
        internal bool IsSetFirstSeenAt() => this.FirstSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The timestamp when the last finding or activity related to this signal was observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenAt property is set.
        /// </summary>
        internal bool IsSetLastSeenAt() => this.LastSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the signal. For example, when signal type is <c>FINDING</c>, the signal
        /// name is the name of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceUids. 
        /// <para>
        /// Information about the unique identifiers of the resources involved in the signal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public List<string> ResourceUids { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceUids property is set.
        /// </summary>
        internal bool IsSetResourceUids() => this.ResourceUids != null && (this.ResourceUids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity associated with the signal. For more information about severity, see
        /// <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings-severity.html">Findings
        /// severity levels</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        /// </summary>
        public double? Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity.HasValue;

        /// <summary>
        /// Gets and sets the property SignalIndicators. 
        /// <para>
        /// Contains information about the indicators associated with the signals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public List<Indicator> SignalIndicators { get; set; } = AWSConfigs.InitializeCollections ? new List<Indicator>() : null;

        /// <summary>
        /// Checks to see if the SignalIndicators property is set.
        /// </summary>
        internal bool IsSetSignalIndicators() => this.SignalIndicators != null && (this.SignalIndicators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the signal used to identify an attack sequence.
        /// </para>
        ///  
        /// <para>
        /// Signals can be GuardDuty findings or activities observed in data sources that GuardDuty
        /// monitors. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_data-sources.html">Foundational
        /// data sources</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A signal type can be one of the valid values listed in this API. Here are the related
        /// descriptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FINDING</c> - Individually generated GuardDuty finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLOUD_TRAIL</c> - Activity observed from CloudTrail logs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_DATA_EVENTS</c> - Activity observed from CloudTrail data events for S3. Activities
        /// associated with this type will show up only when you have enabled GuardDuty S3 Protection
        /// feature in your account. For more information about S3 Protection and steps to enable
        /// it, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/s3-protection.html">S3
        /// Protection</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SignalType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when this signal was last observed.
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
