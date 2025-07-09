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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
    /// Contains information about the GuardDuty attack sequence finding.
    /// </summary>
    public partial class Sequence
    {
        private List<Actor> _actors = AWSConfigs.InitializeCollections ? new List<Actor>() : null;
        private List<string> _additionalSequenceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private List<NetworkEndpoint> _endpoints = AWSConfigs.InitializeCollections ? new List<NetworkEndpoint>() : null;
        private List<ResourceV2> _resources = AWSConfigs.InitializeCollections ? new List<ResourceV2>() : null;
        private List<Indicator> _sequenceIndicators = AWSConfigs.InitializeCollections ? new List<Indicator>() : null;
        private List<Signal> _signals = AWSConfigs.InitializeCollections ? new List<Signal>() : null;
        private string _uid;

        /// <summary>
        /// Gets and sets the property Actors. 
        /// <para>
        /// Contains information about the actors involved in the attack sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
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
        /// Gets and sets the property AdditionalSequenceTypes. 
        /// <para>
        /// Additional types of sequences that may be associated with the attack sequence finding,
        /// providing further context about the nature of the detected threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalSequenceTypes
        {
            get { return this._additionalSequenceTypes; }
            set { this._additionalSequenceTypes = value; }
        }

        // Check to see if AdditionalSequenceTypes property is set
        internal bool IsSetAdditionalSequenceTypes()
        {
            return this._additionalSequenceTypes != null && (this._additionalSequenceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the attack sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// Contains information about the network endpoints that were used in the attack sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// Contains information about the resources involved in the attack sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
        public List<ResourceV2> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SequenceIndicators. 
        /// <para>
        /// Contains information about the indicators observed in the attack sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
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
        /// Contains information about the signals involved in the attack sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Unique identifier of the attack sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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