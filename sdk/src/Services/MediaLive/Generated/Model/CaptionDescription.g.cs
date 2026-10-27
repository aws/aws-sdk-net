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
    /// Caption Description
    /// </summary>
    public partial class CaptionDescription
    {
        /// <summary>
        /// Gets and sets the property Accessibility. Indicates whether the caption track implements
        /// accessibility features such as written descriptions of spoken dialog, music, and sounds.
        /// This signaling is added to HLS output group and MediaPackage output group.
        /// </summary>
        public AccessibilityType Accessibility { get; set; }

        /// <summary>
        /// Checks to see if the Accessibility property is set.
        /// </summary>
        internal bool IsSetAccessibility() => this.Accessibility != null;

        /// <summary>
        /// Gets and sets the property CaptionDashRoles. Identifies the DASH roles to assign to
        /// this captions output. Applies only when the captions output is configured for DVB
        /// DASH accessibility signaling.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CaptionDashRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CaptionDashRoles property is set.
        /// </summary>
        internal bool IsSetCaptionDashRoles() => this.CaptionDashRoles != null && (this.CaptionDashRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptionSelectorName. Specifies which input caption selector
        /// to use as a caption source when generating output captions. This field should match
        /// a captionSelector name.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CaptionSelectorName { get; set; }

        /// <summary>
        /// Checks to see if the CaptionSelectorName property is set.
        /// </summary>
        internal bool IsSetCaptionSelectorName() => this.CaptionSelectorName != null;

        /// <summary>
        /// Gets and sets the property DestinationSettings. Additional settings for captions destination
        /// that depend on the destination type.
        /// </summary>
        public CaptionDestinationSettings DestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the DestinationSettings property is set.
        /// </summary>
        internal bool IsSetDestinationSettings() => this.DestinationSettings != null;

        /// <summary>
        /// Gets and sets the property DvbDashAccessibility. Identifies DVB DASH accessibility
        /// signaling in this captions output. Used in Microsoft Smooth Streaming outputs to signal
        /// accessibility information to packagers.
        /// </summary>
        public DvbDashAccessibility DvbDashAccessibility { get; set; }

        /// <summary>
        /// Checks to see if the DvbDashAccessibility property is set.
        /// </summary>
        internal bool IsSetDvbDashAccessibility() => this.DvbDashAccessibility != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. ISO 639-2 three-digit code: http://www.loc.gov/standards/iso639-2/
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageDescription. Human readable information to indicate
        /// captions available for players (eg. English, or Spanish).
        /// </summary>
        public string LanguageDescription { get; set; }

        /// <summary>
        /// Checks to see if the LanguageDescription property is set.
        /// </summary>
        internal bool IsSetLanguageDescription() => this.LanguageDescription != null;

        /// <summary>
        /// Gets and sets the property Name. Name of the caption description. Used to associate
        /// a caption description with an output. Names must be unique within an event.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
