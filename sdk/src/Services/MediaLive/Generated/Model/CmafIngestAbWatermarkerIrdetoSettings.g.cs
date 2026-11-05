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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// A/B Watermarker settings for CMAF Ingest output groups.
    /// </summary>
    public partial class CmafIngestAbWatermarkerIrdetoSettings
    {
        /// <summary>
        /// Gets and sets the property AdditionalDestinationsAlternateDestinations. The "B" pipeline
        /// renditions for the additional destinations.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputLocationRef> AdditionalDestinationsAlternateDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputLocationRef>() : null;

        /// <summary>
        /// Checks to see if the AdditionalDestinationsAlternateDestinations property is set.
        /// </summary>
        internal bool IsSetAdditionalDestinationsAlternateDestinations() => this.AdditionalDestinationsAlternateDestinations != null && (this.AdditionalDestinationsAlternateDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AlternateDestination. The "B" pipeline renditions for the
        /// main destination.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputLocationRef AlternateDestination { get; set; }

        /// <summary>
        /// Checks to see if the AlternateDestination property is set.
        /// </summary>
        internal bool IsSetAlternateDestination() => this.AlternateDestination != null;

        /// <summary>
        /// Gets and sets the property CustomProfile. The vendor-provided custom profile values.
        /// </summary>
        public AbWatermarkingCustomProfile CustomProfile { get; set; }

        /// <summary>
        /// Checks to see if the CustomProfile property is set.
        /// </summary>
        internal bool IsSetCustomProfile() => this.CustomProfile != null;

        /// <summary>
        /// Gets and sets the property License. The name of the Secrets Manager secret containing
        /// the license file.
        /// </summary>
        public string License { get; set; }

        /// <summary>
        /// Checks to see if the License property is set.
        /// </summary>
        internal bool IsSetLicense() => this.License != null;

        /// <summary>
        /// Gets and sets the property OperatorId. The vendor-provided Operator ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Checks to see if the OperatorId property is set.
        /// </summary>
        internal bool IsSetOperatorId() => this.OperatorId.HasValue;

        /// <summary>
        /// Gets and sets the property PolyPeriod. The number of segments per watermarking bit.
        /// The total duration of the watermarking bit should be the LCM (least common multiple)
        /// of all segments sizes emitted by the downstream packager.
        /// </summary>
        public int? PolyPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PolyPeriod property is set.
        /// </summary>
        internal bool IsSetPolyPeriod() => this.PolyPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property Profile. The vendor-provided profile choice.
        /// </summary>
        [AWSProperty(Required = true)]
        public AbWatermarkingProfile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property WatermarkIdLength. The number of bits that compose the
        /// watermarking identifier to be embedded.
        /// </summary>
        public AbWatermarkerIdLength WatermarkIdLength { get; set; }

        /// <summary>
        /// Checks to see if the WatermarkIdLength property is set.
        /// </summary>
        internal bool IsSetWatermarkIdLength() => this.WatermarkIdLength != null;
    }
}
