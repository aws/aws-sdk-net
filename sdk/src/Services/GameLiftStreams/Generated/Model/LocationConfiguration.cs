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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Configuration settings that define a stream group's stream capacity for a location.
    /// When configuring a location for the first time, you must specify a numeric value for
    /// at least one of the two capacity types. To update the capacity for an existing stream
    /// group, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html">UpdateStreamGroup</a>.
    /// To add a new location and specify its capacity, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_AddStreamGroupLocations.html">AddStreamGroupLocations</a>.
    /// </summary>
    public partial class LocationConfiguration
    {
        private int? _alwaysOnCapacity;
        private string _locationName;
        private int? _onDemandCapacity;

        /// <summary>
        /// Gets and sets the property AlwaysOnCapacity. 
        /// <para>
        /// The streaming capacity that is allocated and ready to handle stream requests without
        /// delay. You pay for this capacity whether it's in use or not. Best for quickest time
        /// from streaming request to streaming session. Default is 1 when creating a stream group
        /// or adding a location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AlwaysOnCapacity
        {
            get { return this._alwaysOnCapacity; }
            set { this._alwaysOnCapacity = value; }
        }

        // Check to see if AlwaysOnCapacity property is set
        internal bool IsSetAlwaysOnCapacity()
        {
            return this._alwaysOnCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        ///  A location's name. For example, <c>us-east-1</c>. For a complete list of locations
        /// that Amazon GameLift Streams supports, refer to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string LocationName
        {
            get { return this._locationName; }
            set { this._locationName = value; }
        }

        // Check to see if LocationName property is set
        internal bool IsSetLocationName()
        {
            return this._locationName != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandCapacity. 
        /// <para>
        /// The streaming capacity that Amazon GameLift Streams can allocate in response to stream
        /// requests, and then de-allocate when the session has terminated. This offers a cost
        /// control measure at the expense of a greater startup time (typically under 5 minutes).
        /// Default is 0 when creating a stream group or adding a location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? OnDemandCapacity
        {
            get { return this._onDemandCapacity; }
            set { this._onDemandCapacity = value; }
        }

        // Check to see if OnDemandCapacity property is set
        internal bool IsSetOnDemandCapacity()
        {
            return this._onDemandCapacity.HasValue; 
        }

    }
}