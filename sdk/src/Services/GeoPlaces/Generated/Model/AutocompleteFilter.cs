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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Autocomplete structure which contains a set of inclusion/exclusion properties that
    /// results must possess in order to be returned as a result.
    /// </summary>
    public partial class AutocompleteFilter
    {
        private List<double> _boundingBox = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private FilterCircle _circle;
        private List<string> _includeCountries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includePlaceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// The bounding box enclosing the geometric shape (area or line) that an individual result
        /// covers.
        /// </para>
        ///  
        /// <para>
        /// The bounding box formed is defined as a set 4 coordinates: <c>[{westward lng}, {southern
        /// lat}, {eastward lng}, {northern lat}]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=4)]
        public List<double> BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null && (this._boundingBox.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Circle.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FilterCircle Circle
        {
            get { return this._circle; }
            set { this._circle = value; }
        }

        // Check to see if Circle property is set
        internal bool IsSetCircle()
        {
            return this._circle != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeCountries. 
        /// <para>
        ///  A list of countries that all results must be in. Countries are represented by either
        /// their alpha-2 or alpha-3 character codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> IncludeCountries
        {
            get { return this._includeCountries; }
            set { this._includeCountries = value; }
        }

        // Check to see if IncludeCountries property is set
        internal bool IsSetIncludeCountries()
        {
            return this._includeCountries != null && (this._includeCountries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludePlaceTypes. 
        /// <para>
        /// The included place types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> IncludePlaceTypes
        {
            get { return this._includePlaceTypes; }
            set { this._includePlaceTypes = value; }
        }

        // Check to see if IncludePlaceTypes property is set
        internal bool IsSetIncludePlaceTypes()
        {
            return this._includePlaceTypes != null && (this._includePlaceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}