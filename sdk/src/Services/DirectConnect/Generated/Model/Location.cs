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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about an AWS Direct Connect location.
    /// </summary>
    public partial class Location
    {
        private List<string> _availablePortSpeeds = new List<string>();
        private string _locationCode;
        private string _locationName;
        private string _region;

        /// <summary>
        /// Gets and sets the property AvailablePortSpeeds. 
        /// <para>
        /// The available port speeds for the location.
        /// </para>
        /// </summary>
        public List<string> AvailablePortSpeeds
        {
            get { return this._availablePortSpeeds; }
            set { this._availablePortSpeeds = value; }
        }

        // Check to see if AvailablePortSpeeds property is set
        internal bool IsSetAvailablePortSpeeds()
        {
            return this._availablePortSpeeds != null && this._availablePortSpeeds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocationCode. 
        /// <para>
        /// The code for the location.
        /// </para>
        /// </summary>
        public string LocationCode
        {
            get { return this._locationCode; }
            set { this._locationCode = value; }
        }

        // Check to see if LocationCode property is set
        internal bool IsSetLocationCode()
        {
            return this._locationCode != null;
        }

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        /// The name of the location. This includes the name of the colocation partner and the
        /// physical site of the building.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region for the location.
        /// </para>
        /// </summary>
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