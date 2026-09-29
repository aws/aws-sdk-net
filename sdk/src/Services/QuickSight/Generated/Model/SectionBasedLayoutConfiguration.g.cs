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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration for a section-based layout.
    /// </summary>
    public partial class SectionBasedLayoutConfiguration
    {
        /// <summary>
        /// Gets and sets the property BodySections. 
        /// <para>
        /// A list of body section configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 28)]
        public List<BodySectionConfiguration> BodySections { get; set; } = AWSConfigs.InitializeCollections ? new List<BodySectionConfiguration>() : null;

        /// <summary>
        /// Checks to see if the BodySections property is set.
        /// </summary>
        internal bool IsSetBodySections() => this.BodySections != null && (this.BodySections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CanvasSizeOptions. 
        /// <para>
        /// The options for the canvas of a section-based layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }

        /// <summary>
        /// Checks to see if the CanvasSizeOptions property is set.
        /// </summary>
        internal bool IsSetCanvasSizeOptions() => this.CanvasSizeOptions != null;

        /// <summary>
        /// Gets and sets the property FooterSections. 
        /// <para>
        /// A list of footer section configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public List<HeaderFooterSectionConfiguration> FooterSections { get; set; } = AWSConfigs.InitializeCollections ? new List<HeaderFooterSectionConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FooterSections property is set.
        /// </summary>
        internal bool IsSetFooterSections() => this.FooterSections != null && (this.FooterSections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderSections. 
        /// <para>
        /// A list of header section configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public List<HeaderFooterSectionConfiguration> HeaderSections { get; set; } = AWSConfigs.InitializeCollections ? new List<HeaderFooterSectionConfiguration>() : null;

        /// <summary>
        /// Checks to see if the HeaderSections property is set.
        /// </summary>
        internal bool IsSetHeaderSections() => this.HeaderSections != null && (this.HeaderSections.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
