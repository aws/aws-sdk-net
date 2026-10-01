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
    /// Contains information about the signals involved in an Amazon GuardDuty Extended Threat
    /// Detection attack sequence. An attack sequence is a type of threat detected by GuardDuty.
    /// GuardDuty generates an attack sequence finding when multiple events, or signals, align
    /// to a potentially suspicious activity. When GuardDuty and Security Hub CSPM are integrated,
    /// GuardDuty sends attack sequence findings to Security Hub CSPM.
    /// 
    ///  
    /// <para>
    /// A signal can be an API activity or a finding that GuardDuty uses to detect an attack
    /// sequence finding.
    /// </para>
    /// </summary>
    public partial class Signal
    {
        /// <summary>
        /// Gets and sets the property ActorIds. 
        /// <para>
        ///  The IDs of the threat actors involved in the signal. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ActorIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActorIds property is set.
        /// </summary>
        internal bool IsSetActorIds() => this.ActorIds != null && (this.ActorIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        ///  The number of times this signal was observed. 
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the first finding or activity related to this signal was observed.
        /// 
        /// </para>
        /// </summary>
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

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
        public List<string> EndpointIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EndpointIds property is set.
        /// </summary>
        internal bool IsSetEndpointIds() => this.EndpointIds != null && (this.EndpointIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirstSeenAt. 
        /// <para>
        ///  The timestamp when the first finding or activity related to this signal was observed.
        /// 
        /// </para>
        /// </summary>
        public long? FirstSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstSeenAt property is set.
        /// </summary>
        internal bool IsSetFirstSeenAt() => this.FirstSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the signal. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        ///  The timestamp when the last finding or activity related to this signal was observed.
        /// 
        /// </para>
        /// </summary>
        public long? LastSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenAt property is set.
        /// </summary>
        internal bool IsSetLastSeenAt() => this.LastSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the GuardDuty signal. For example, when signal type is <c>FINDING</c>,
        /// the signal name is the name of the finding. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the product that generated the signal. 
        /// </para>
        /// </summary>
        public string ProductArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductArn property is set.
        /// </summary>
        internal bool IsSetProductArn() => this.ProductArn != null;

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        ///  The ARN or ID of the Amazon Web Services resource associated with the signal. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceIds property is set.
        /// </summary>
        internal bool IsSetResourceIds() => this.ResourceIds != null && (this.ResourceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity associated with the signal. For more information about severity, see
        /// <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings-severity.html">Severity
        /// levels for GuardDuty findings</a> in the <i>Amazon GuardDuty User Guide</i>.
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
        ///  Contains information about the indicators associated with the signals in this attack
        /// sequence finding. The values for <c>SignalIndicators</c> are a subset of the values
        /// for <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_Sequence.html">SequenceIndicators</a>,
        /// but the values for these fields don't always match 1:1. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Indicator> SignalIndicators { get; set; } = AWSConfigs.InitializeCollections ? new List<Indicator>() : null;

        /// <summary>
        /// Checks to see if the SignalIndicators property is set.
        /// </summary>
        internal bool IsSetSignalIndicators() => this.SignalIndicators != null && (this.SignalIndicators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  The description of the GuardDuty finding. 
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the signal used to identify an attack sequence. 
        /// </para>
        ///  
        /// <para>
        /// Signals can be GuardDuty findings or activities observed in data sources that GuardDuty
        /// monitors. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_data-sources.html">GuardDuty
        /// foundational data sources</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A signal type can be one of the following values. Here are the related descriptions:
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
        ///  <c>S3_DATA_EVENTS</c> - Activity observed from CloudTrail data events for Amazon
        /// Simple Storage Service (S3). Activities associated with this type will show up only
        /// when you have enabled GuardDuty S3 Protection feature in your account. For more information
        /// about S3 Protection and the steps to enable it, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/s3-protection.html">S3
        /// Protection</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when this signal was last observed. 
        /// </para>
        /// </summary>
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
