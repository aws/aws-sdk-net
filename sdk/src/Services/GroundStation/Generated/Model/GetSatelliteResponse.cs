/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetSatelliteResponse : AmazonWebServiceResponse
    {
        private DateTime? _dateCreated;
        private DateTime? _lastUpdated;
        private int? _noradSatelliteID;
        private string _satelliteArn;
        private string _satelliteId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// When a satellite was created.
        /// </para>
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated.GetValueOrDefault(); }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// When a satellite was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoradSatelliteID. 
        /// <para>
        /// NORAD satellite ID number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=99999)]
        public int NoradSatelliteID
        {
            get { return this._noradSatelliteID.GetValueOrDefault(); }
            set { this._noradSatelliteID = value; }
        }

        // Check to see if NoradSatelliteID property is set
        internal bool IsSetNoradSatelliteID()
        {
            return this._noradSatelliteID.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SatelliteArn. 
        /// <para>
        /// ARN of a satellite.
        /// </para>
        /// </summary>
        public string SatelliteArn
        {
            get { return this._satelliteArn; }
            set { this._satelliteArn = value; }
        }

        // Check to see if SatelliteArn property is set
        internal bool IsSetSatelliteArn()
        {
            return this._satelliteArn != null;
        }

        /// <summary>
        /// Gets and sets the property SatelliteId. 
        /// <para>
        /// UUID of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SatelliteId
        {
            get { return this._satelliteId; }
            set { this._satelliteId = value; }
        }

        // Check to see if SatelliteId property is set
        internal bool IsSetSatelliteId()
        {
            return this._satelliteId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to a satellite.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}