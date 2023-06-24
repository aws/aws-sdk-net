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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration for a section-based layout.
    /// </summary>
    public partial class SectionBasedLayoutConfiguration
    {
        private List<BodySectionConfiguration> _bodySections = new List<BodySectionConfiguration>();
        private SectionBasedLayoutCanvasSizeOptions _canvasSizeOptions;
        private List<HeaderFooterSectionConfiguration> _footerSections = new List<HeaderFooterSectionConfiguration>();
        private List<HeaderFooterSectionConfiguration> _headerSections = new List<HeaderFooterSectionConfiguration>();

        /// <summary>
        /// Gets and sets the property BodySections. 
        /// <para>
        /// A list of body section configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=28)]
        public List<BodySectionConfiguration> BodySections
        {
            get { return this._bodySections; }
            set { this._bodySections = value; }
        }

        // Check to see if BodySections property is set
        internal bool IsSetBodySections()
        {
            return this._bodySections != null && this._bodySections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CanvasSizeOptions. 
        /// <para>
        /// The options for the canvas of a section-based layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions
        {
            get { return this._canvasSizeOptions; }
            set { this._canvasSizeOptions = value; }
        }

        // Check to see if CanvasSizeOptions property is set
        internal bool IsSetCanvasSizeOptions()
        {
            return this._canvasSizeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FooterSections. 
        /// <para>
        /// A list of footer section configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1)]
        public List<HeaderFooterSectionConfiguration> FooterSections
        {
            get { return this._footerSections; }
            set { this._footerSections = value; }
        }

        // Check to see if FooterSections property is set
        internal bool IsSetFooterSections()
        {
            return this._footerSections != null && this._footerSections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HeaderSections. 
        /// <para>
        /// A list of header section configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1)]
        public List<HeaderFooterSectionConfiguration> HeaderSections
        {
            get { return this._headerSections; }
            set { this._headerSections = value; }
        }

        // Check to see if HeaderSections property is set
        internal bool IsSetHeaderSections()
        {
            return this._headerSections != null && this._headerSections.Count > 0; 
        }

    }
}