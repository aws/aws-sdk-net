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
    /// The configuration of a body section.
    /// </summary>
    public partial class BodySectionConfiguration
    {
        private BodySectionContent _content;
        private SectionPageBreakConfiguration _pageBreakConfiguration;
        private string _sectionId;
        private SectionStyle _style;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The configuration of content in a body section.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BodySectionContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property PageBreakConfiguration. 
        /// <para>
        /// The configuration of a page break for a section.
        /// </para>
        /// </summary>
        public SectionPageBreakConfiguration PageBreakConfiguration
        {
            get { return this._pageBreakConfiguration; }
            set { this._pageBreakConfiguration = value; }
        }

        // Check to see if PageBreakConfiguration property is set
        internal bool IsSetPageBreakConfiguration()
        {
            return this._pageBreakConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SectionId. 
        /// <para>
        /// The unique identifier of a body section.
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
        /// The style options of a body section.
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