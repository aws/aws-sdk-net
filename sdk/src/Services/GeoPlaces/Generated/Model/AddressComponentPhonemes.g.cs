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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        /// How to pronounce the name of the block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> Block { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the Block property is set.
        /// </summary>
        internal bool IsSetBlock() => this.Block != null && (this.Block.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country that the results will be present
        /// in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> Country { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null && (this.Country.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property District. 
        /// <para>
        /// How to pronounce the district or division of a city results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> District { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the District property is set.
        /// </summary>
        internal bool IsSetDistrict() => this.District != null && (this.District.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> Locality { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the Locality property is set.
        /// </summary>
        internal bool IsSetLocality() => this.Locality != null && (this.Locality.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// How to pronounce the region or state results should be to be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> Region { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null && (this.Region.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// How to pronounce the name of the street results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> Street { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the Street property is set.
        /// </summary>
        internal bool IsSetStreet() => this.Street != null && (this.Street.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubBlock. 
        /// <para>
        /// How to pronounce the name of the sub-block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> SubBlock { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the SubBlock property is set.
        /// </summary>
        internal bool IsSetSubBlock() => this.SubBlock != null && (this.SubBlock.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubDistrict. 
        /// <para>
        /// How to pronounce the sub-district or division of a city results should be present
        /// in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> SubDistrict { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the SubDistrict property is set.
        /// </summary>
        internal bool IsSetSubDistrict() => this.SubDistrict != null && (this.SubDistrict.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// How to pronounce the sub-region or county for which results should be present in.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PhonemeTranscription> SubRegion { get; set; } = AWSConfigs.InitializeCollections ? new List<PhonemeTranscription>() : null;

        /// <summary>
        /// Checks to see if the SubRegion property is set.
        /// </summary>
        internal bool IsSetSubRegion() => this.SubRegion != null && (this.SubRegion.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
