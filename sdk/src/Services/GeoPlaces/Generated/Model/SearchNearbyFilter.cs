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
    /// SearchNearby structure which contains a set of inclusion/exclusion properties that
    /// results must possess in order to be returned as a result.
    /// </summary>
    public partial class SearchNearbyFilter
    {
        private List<double> _boundingBox = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<string> _excludeBusinessChains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludeCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludeFoodTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeBusinessChains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeCountries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeFoodTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property ExcludeBusinessChains. 
        /// <para>
        /// The Business Chains associated with the place.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ExcludeBusinessChains
        {
            get { return this._excludeBusinessChains; }
            set { this._excludeBusinessChains = value; }
        }

        // Check to see if ExcludeBusinessChains property is set
        internal bool IsSetExcludeBusinessChains()
        {
            return this._excludeBusinessChains != null && (this._excludeBusinessChains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeCategories. 
        /// <para>
        /// Categories of results that results are excluded from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ExcludeCategories
        {
            get { return this._excludeCategories; }
            set { this._excludeCategories = value; }
        }

        // Check to see if ExcludeCategories property is set
        internal bool IsSetExcludeCategories()
        {
            return this._excludeCategories != null && (this._excludeCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeFoodTypes. 
        /// <para>
        /// Food types that results are excluded from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ExcludeFoodTypes
        {
            get { return this._excludeFoodTypes; }
            set { this._excludeFoodTypes = value; }
        }

        // Check to see if ExcludeFoodTypes property is set
        internal bool IsSetExcludeFoodTypes()
        {
            return this._excludeFoodTypes != null && (this._excludeFoodTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeBusinessChains. 
        /// <para>
        /// The Business Chains associated with the place.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> IncludeBusinessChains
        {
            get { return this._includeBusinessChains; }
            set { this._includeBusinessChains = value; }
        }

        // Check to see if IncludeBusinessChains property is set
        internal bool IsSetIncludeBusinessChains()
        {
            return this._includeBusinessChains != null && (this._includeBusinessChains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeCategories. 
        /// <para>
        /// Categories of results that results must belong too.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> IncludeCategories
        {
            get { return this._includeCategories; }
            set { this._includeCategories = value; }
        }

        // Check to see if IncludeCategories property is set
        internal bool IsSetIncludeCategories()
        {
            return this._includeCategories != null && (this._includeCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeCountries. 
        /// <para>
        /// A list of countries that all results must be in. Countries are represented by either
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
        /// Gets and sets the property IncludeFoodTypes. 
        /// <para>
        /// Food types that results are included from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> IncludeFoodTypes
        {
            get { return this._includeFoodTypes; }
            set { this._includeFoodTypes = value; }
        }

        // Check to see if IncludeFoodTypes property is set
        internal bool IsSetIncludeFoodTypes()
        {
            return this._includeFoodTypes != null && (this._includeFoodTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}