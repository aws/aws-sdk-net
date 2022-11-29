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
    /// The configuration of a header or footer section.
    /// </summary>
    public partial class HeaderFooterSectionConfiguration
    {
        private SectionLayoutConfiguration _layout;
        private string _sectionId;
        private SectionStyle _style;

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// The layout configuration of the header or footer section.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SectionLayoutConfiguration Layout
        {
            get { return this._layout; }
            set { this._layout = value; }
        }

        // Check to see if Layout property is set
        internal bool IsSetLayout()
        {
            return this._layout != null;
        }

        /// <summary>
        /// Gets and sets the property SectionId. 
        /// <para>
        /// The unique identifier of the header or footer section.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SectionId
        {
            get { return this._sectionId; }
            set { this._sectionId = value; }
        }

        // Check to see if SectionId property is set
        internal bool IsSetSectionId()
        {
            return this._sectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// The style options of a header or footer section.
        /// </para>
        /// </summary>
        public SectionStyle Style
        {
            get { return this._style; }
            set { this._style = value; }
        }

        // Check to see if Style property is set
        internal bool IsSetStyle()
        {
            return this._style != null;
        }

    }
}