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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// A/B Watermarker settings for MediaPackage V2 output groups.
    /// </summary>
    public partial class MediaPackageV2AbWatermarkerIrdetoSettings
    {
        private List<OutputLocationRef> _additionalDestinationsAlternateDestinations = AWSConfigs.InitializeCollections ? new List<OutputLocationRef>() : null;
        private OutputLocationRef _alternateDestination;
        private AbWatermarkingCustomProfile _customProfile;
        private string _license;
        private int? _operatorId;
        private int? _polyPeriod;
        private AbWatermarkingProfile _profile;
        private AbWatermarkerIdLength _watermarkIdLength;

        /// <summary>
        /// Gets and sets the property AdditionalDestinationsAlternateDestinations. The "B" pipeline
        /// renditions for the additional destinations.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputLocationRef> AdditionalDestinationsAlternateDestinations
        {
            get { return this._additionalDestinationsAlternateDestinations; }
            set { this._additionalDestinationsAlternateDestinations = value; }
        }

        // Check to see if AdditionalDestinationsAlternateDestinations property is set
        internal bool IsSetAdditionalDestinationsAlternateDestinations()
        {
            return this._additionalDestinationsAlternateDestinations != null && (this._additionalDestinationsAlternateDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AlternateDestination. The "B" pipeline renditions for the
        /// main destination.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef AlternateDestination
        {
            get { return this._alternateDestination; }
            set { this._alternateDestination = value; }
        }

        // Check to see if AlternateDestination property is set
        internal bool IsSetAlternateDestination()
        {
            return this._alternateDestination != null;
        }

        /// <summary>
        /// Gets and sets the property CustomProfile. The vendor-provided custom profile values.
        /// </summary>
        public AbWatermarkingCustomProfile CustomProfile
        {
            get { return this._customProfile; }
            set { this._customProfile = value; }
        }

        // Check to see if CustomProfile property is set
        internal bool IsSetCustomProfile()
        {
            return this._customProfile != null;
        }

        /// <summary>
        /// Gets and sets the property License. The name of the Secrets Manager secret containing
        /// the license file.
        /// </summary>
        public string License
        {
            get { return this._license; }
            set { this._license = value; }
        }

        // Check to see if License property is set
        internal bool IsSetLicense()
        {
            return this._license != null;
        }

        /// <summary>
        /// Gets and sets the property OperatorId. The vendor-provided Operator ID.
        /// </summary>
        [AWSProperty(Required=true)]
        public int? OperatorId
        {
            get { return this._operatorId; }
            set { this._operatorId = value; }
        }

        // Check to see if OperatorId property is set
        internal bool IsSetOperatorId()
        {
            return this._operatorId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolyPeriod. The number of segments per watermarking bit.
        /// The total duration of the watermarking bitshould be the LCM (least common multiple)
        /// of all segments sizes emitted by the downstream packager.
        /// </summary>
        public int? PolyPeriod
        {
            get { return this._polyPeriod; }
            set { this._polyPeriod = value; }
        }

        // Check to see if PolyPeriod property is set
        internal bool IsSetPolyPeriod()
        {
            return this._polyPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Profile. The vendor-provided profile choice.
        /// </summary>
        [AWSProperty(Required=true)]
        public AbWatermarkingProfile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property WatermarkIdLength. The number of bits that compose the
        /// watermarking identifier to be embedded.
        /// </summary>
        public AbWatermarkerIdLength WatermarkIdLength
        {
            get { return this._watermarkIdLength; }
            set { this._watermarkIdLength = value; }
        }

        // Check to see if WatermarkIdLength property is set
        internal bool IsSetWatermarkIdLength()
        {
            return this._watermarkIdLength != null;
        }

    }
}