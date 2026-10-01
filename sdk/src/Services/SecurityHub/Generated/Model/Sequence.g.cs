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
    /// Contains information about an Amazon GuardDuty Extended Threat Detection attack sequence
    /// finding. GuardDuty generates an attack sequence finding when multiple events align
    /// to a potentially suspicious activity. To receive GuardDuty attack sequence findings
    /// in Security Hub CSPM, you must have GuardDuty enabled. For more information, see <a
    /// href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>.
    /// </summary>
    public partial class Sequence
    {
        /// <summary>
        /// Gets and sets the property Actors. 
        /// <para>
        ///  Provides information about the actors involved in the attack sequence. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<Actor> Actors { get; set; } = AWSConfigs.InitializeCollections ? new List<Actor>() : null;

        /// <summary>
        /// Checks to see if the Actors property is set.
        /// </summary>
        internal bool IsSetActors() => this.Actors != null && (this.Actors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        ///  Contains information about the network endpoints that were used in the attack sequence.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<NetworkEndpoint> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkEndpoint>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SequenceIndicators. 
        /// <para>
        ///  Contains information about the indicators observed in the attack sequence. The values
        /// for <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_Signal.html">SignalIndicators</a>
        /// are a subset of the values for <c>SequenceIndicators</c>, but the values for these
        /// fields don't always match 1:1.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Indicator> SequenceIndicators { get; set; } = AWSConfigs.InitializeCollections ? new List<Indicator>() : null;

        /// <summary>
        /// Checks to see if the SequenceIndicators property is set.
        /// </summary>
        internal bool IsSetSequenceIndicators() => this.SequenceIndicators != null && (this.SequenceIndicators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Signals. 
        /// <para>
        ///  Contains information about the signals involved in the attack sequence. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<Signal> Signals { get; set; } = AWSConfigs.InitializeCollections ? new List<Signal>() : null;

        /// <summary>
        /// Checks to see if the Signals property is set.
        /// </summary>
        internal bool IsSetSignals() => this.Signals != null && (this.Signals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        ///  Unique identifier of the attack sequence. 
        /// </para>
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;
    }
}
