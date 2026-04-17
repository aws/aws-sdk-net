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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// An antenna at a ground station.
    /// </summary>
    public partial class AntennaListItem
    {
        private string _antennaName;
        private string _groundStationName;
        private string _region;

        /// <summary>
        /// Gets and sets the property AntennaName. 
        /// <para>
        /// Name of the antenna.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=256)]
        public string AntennaName
        {
            get { return this._antennaName; }
            set { this._antennaName = value; }
        }

        // Check to see if AntennaName property is set
        internal bool IsSetAntennaName()
        {
            return this._antennaName != null;
        }

        /// <summary>
        /// Gets and sets the property GroundStationName. 
        /// <para>
        /// Name of the ground station the antenna is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=97)]
        public string GroundStationName
        {
            get { return this._groundStationName; }
            set { this._groundStationName = value; }
        }

        // Check to see if GroundStationName property is set
        internal bool IsSetGroundStationName()
        {
            return this._groundStationName != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Region of the antenna.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}