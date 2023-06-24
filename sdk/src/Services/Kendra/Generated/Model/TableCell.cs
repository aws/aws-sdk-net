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
    /// Provides information about a table cell in a table excerpt.
    /// </summary>
    public partial class TableCell
    {
        private bool? _header;
        private bool? _highlighted;
        private bool? _topAnswer;
        private string _value;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        ///  <code>TRUE</code> means that the table cell should be treated as a header.
        /// </para>
        /// </summary>
        public bool Header
        {
            get { return this._header.GetValueOrDefault(); }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Highlighted. 
        /// <para>
        ///  <code>TRUE</code> means that the table cell has a high enough confidence and is relevant
        /// to the query, so the value or content should be highlighted.
        /// </para>
        /// </summary>
        public bool Highlighted
        {
            get { return this._highlighted.GetValueOrDefault(); }
            set { this._highlighted = value; }
        }

        // Check to see if Highlighted property is set
        internal bool IsSetHighlighted()
        {
            return this._highlighted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopAnswer. 
        /// <para>
        ///  <code>TRUE</code> if the response of the table cell is the top answer. This is the
        /// cell value or content with the highest confidence score or is the most relevant to
        /// the query.
        /// </para>
        /// </summary>
        public bool TopAnswer
        {
            get { return this._topAnswer.GetValueOrDefault(); }
            set { this._topAnswer = value; }
        }

        // Check to see if TopAnswer property is set
        internal bool IsSetTopAnswer()
        {
            return this._topAnswer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The actual value or content within a table cell. A table cell could contain a date
        /// value of a year, or a string value of text, for example.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}