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
    /// The title label options for a visual.
    /// </summary>
    public partial class VisualTitleLabelOptions
    {
        private ShortFormatText _formatText;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property FormatText. 
        /// <para>
        /// The short text format of the title label, such as plain text or rich text.
        /// </para>
        /// </summary>
        public ShortFormatText FormatText
        {
            get { return this._formatText; }
            set { this._formatText = value; }
        }

        // Check to see if FormatText property is set
        internal bool IsSetFormatText()
        {
            return this._formatText != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the title label.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}