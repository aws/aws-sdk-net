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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// in Security Hub, you must have GuardDuty enabled. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>.
    /// </summary>
    public partial class Sequence
    {
        private List<Actor> _actors = AWSConfigs.InitializeCollections ? new List<Actor>() : null;
        private List<NetworkEndpoint> _endpoints = AWSConfigs.InitializeCollections ? new List<NetworkEndpoint>() : null;
        private List<Indicator> _sequenceIndicators = AWSConfigs.InitializeCollections ? new List<Indicator>() : null;
        private List<Signal> _signals = AWSConfigs.InitializeCollections ? new List<Signal>() : null;
        private string _uid;

        /// <summary>
        /// Gets and sets the property Actors. 
        /// <para>
        ///  Provides information about the actors involved in the attack sequence. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<Actor> Actors
        {
            get { return this._actors; }
            set { this._actors = value; }
        }

        // Check to see if Actors property is set
        internal bool IsSetActors()
        {
            return this._actors != null && (this._actors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        ///  Contains information about the network endpoints that were used in the attack sequence.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<NetworkEndpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SequenceIndicators. 
        /// <para>
        ///  Contains information about the indicators observed in the attack sequence. The values
        /// for <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_Signal.html">SignalIndicators</a>
        /// are a subset of the values for <c>SequenceIndicators</c>, but the values for these
        /// fields don't always match 1:1.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<Indicator> SequenceIndicators
        {
            get { return this._sequenceIndicators; }
            set { this._sequenceIndicators = value; }
        }

        // Check to see if SequenceIndicators property is set
        internal bool IsSetSequenceIndicators()
        {
            return this._sequenceIndicators != null && (this._sequenceIndicators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Signals. 
        /// <para>
        ///  Contains information about the signals involved in the attack sequence. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<Signal> Signals
        {
            get { return this._signals; }
            set { this._signals = value; }
        }

        // Check to see if Signals property is set
        internal bool IsSetSignals()
        {
            return this._signals != null && (this._signals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        ///  Unique identifier of the attack sequence. 
        /// </para>
        /// </summary>
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

    }
}