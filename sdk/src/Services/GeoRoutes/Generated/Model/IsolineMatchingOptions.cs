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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Isoline matching related options.
    /// </summary>
    public partial class IsolineMatchingOptions
    {
        private string _nameHint;
        private long? _onRoadThreshold;
        private long? _radius;
        private MatchingStrategy _strategy;

        /// <summary>
        /// Gets and sets the property NameHint. 
        /// <para>
        /// Attempts to match the provided position to a road similar to the provided name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string NameHint
        {
            get { return this._nameHint; }
            set { this._nameHint = value; }
        }

        // Check to see if NameHint property is set
        internal bool IsSetNameHint()
        {
            return this._nameHint != null;
        }

        /// <summary>
        /// Gets and sets the property OnRoadThreshold. 
        /// <para>
        /// If the distance to a highway/bridge/tunnel/sliproad is within threshold, the waypoint
        /// will be snapped to the highway/bridge/tunnel/sliproad.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? OnRoadThreshold
        {
            get { return this._onRoadThreshold; }
            set { this._onRoadThreshold = value; }
        }

        // Check to see if OnRoadThreshold property is set
        internal bool IsSetOnRoadThreshold()
        {
            return this._onRoadThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Radius. 
        /// <para>
        /// Considers all roads within the provided radius to match the provided destination to.
        /// The roads that are considered are determined by the provided Strategy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Radius
        {
            get { return this._radius; }
            set { this._radius = value; }
        }

        // Check to see if Radius property is set
        internal bool IsSetRadius()
        {
            return this._radius.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// Strategy that defines matching of the position onto the road network. MatchAny considers
        /// all roads possible, whereas MatchMostSignificantRoad matches to the most significant
        /// road.
        /// </para>
        /// </summary>
        public MatchingStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}