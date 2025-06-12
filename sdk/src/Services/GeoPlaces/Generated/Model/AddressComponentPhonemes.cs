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
    /// How to pronounce the various components of the address or place.
    /// </summary>
    public partial class AddressComponentPhonemes
    {
        private List<PhonemeTranscription> _block = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _country = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _district = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _locality = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _region = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _street = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _subBlock = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _subDistrict = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;
        private List<PhonemeTranscription> _subRegion = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        /// How to pronounce the name of the block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block != null && (this._block.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country that the results will be present
        /// in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null && (this._country.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property District. 
        /// <para>
        /// How to pronounce the district or division of a city results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> District
        {
            get { return this._district; }
            set { this._district = value; }
        }

        // Check to see if District property is set
        internal bool IsSetDistrict()
        {
            return this._district != null && (this._district.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Locality. 
        /// <para>
        /// How to pronounce the city or locality results should be present in. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Vancouver</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> Locality
        {
            get { return this._locality; }
            set { this._locality = value; }
        }

        // Check to see if Locality property is set
        internal bool IsSetLocality()
        {
            return this._locality != null && (this._locality.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// How to pronounce the region or state results should be to be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null && (this._region.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// How to pronounce the name of the street results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> Street
        {
            get { return this._street; }
            set { this._street = value; }
        }

        // Check to see if Street property is set
        internal bool IsSetStreet()
        {
            return this._street != null && (this._street.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubBlock. 
        /// <para>
        /// How to pronounce the name of the sub-block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> SubBlock
        {
            get { return this._subBlock; }
            set { this._subBlock = value; }
        }

        // Check to see if SubBlock property is set
        internal bool IsSetSubBlock()
        {
            return this._subBlock != null && (this._subBlock.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubDistrict. 
        /// <para>
        /// How to pronounce the sub-district or division of a city results should be present
        /// in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> SubDistrict
        {
            get { return this._subDistrict; }
            set { this._subDistrict = value; }
        }

        // Check to see if SubDistrict property is set
        internal bool IsSetSubDistrict()
        {
            return this._subDistrict != null && (this._subDistrict.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// How to pronounce the sub-region or county for which results should be present in.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PhonemeTranscription> SubRegion
        {
            get { return this._subRegion; }
            set { this._subRegion = value; }
        }

        // Check to see if SubRegion property is set
        internal bool IsSetSubRegion()
        {
            return this._subRegion != null && (this._subRegion.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}