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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides text and information about where to highlight the text.
    /// </summary>
    public partial class TextWithHighlights
    {
        private List<Highlight> _highlights = new List<Highlight>();
        private string _text;

        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// The beginning and end of the text that should be highlighted.
        /// </para>
        /// </summary>
        public List<Highlight> Highlights
        {
            get { return this._highlights; }
            set { this._highlights = value; }
        }

        // Check to see if Highlights property is set
        internal bool IsSetHighlights()
        {
            return this._highlights != null && this._highlights.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text to display to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}