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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about an Direct Connect location.
    /// </summary>
    public partial class Location
    {
        private List<string> _availableMacSecPortSpeeds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _availablePortSpeeds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _availableProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _locationCode;
        private string _locationName;
        private string _region;

        /// <summary>
        /// Gets and sets the property AvailableMacSecPortSpeeds. 
        /// <para>
        /// The available MAC Security (MACsec) port speeds for the location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailableMacSecPortSpeeds
        {
            get { return this._availableMacSecPortSpeeds; }
            set { this._availableMacSecPortSpeeds = value; }
        }

        // Check to see if AvailableMacSecPortSpeeds property is set
        internal bool IsSetAvailableMacSecPortSpeeds()
        {
            return this._availableMacSecPortSpeeds != null && (this._availableMacSecPortSpeeds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailablePortSpeeds. 
        /// <para>
        /// The available port speeds for the location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailablePortSpeeds
        {
            get { return this._availablePortSpeeds; }
            set { this._availablePortSpeeds = value; }
        }

        // Check to see if AvailablePortSpeeds property is set
        internal bool IsSetAvailablePortSpeeds()
        {
            return this._availablePortSpeeds != null && (this._availablePortSpeeds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailableProviders. 
        /// <para>
        /// The name of the service provider for the location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailableProviders
        {
            get { return this._availableProviders; }
            set { this._availableProviders = value; }
        }

        // Check to see if AvailableProviders property is set
        internal bool IsSetAvailableProviders()
        {
            return this._availableProviders != null && (this._availableProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The Amazon Web Services Region for the location.
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