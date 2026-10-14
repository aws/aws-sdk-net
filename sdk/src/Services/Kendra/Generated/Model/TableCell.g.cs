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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about a table cell in a table excerpt.
    /// </summary>
    public partial class TableCell
    {
        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        ///  <c>TRUE</c> means that the table cell should be treated as a header.
        /// </para>
        /// </summary>
        public bool? Header { get; set; }

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header.HasValue;

        /// <summary>
        /// Gets and sets the property Highlighted. 
        /// <para>
        ///  <c>TRUE</c> means that the table cell has a high enough confidence and is relevant
        /// to the query, so the value or content should be highlighted.
        /// </para>
        /// </summary>
        public bool? Highlighted { get; set; }

        /// <summary>
        /// Checks to see if the Highlighted property is set.
        /// </summary>
        internal bool IsSetHighlighted() => this.Highlighted.HasValue;

        /// <summary>
        /// Gets and sets the property TopAnswer. 
        /// <para>
        ///  <c>TRUE</c> if the response of the table cell is the top answer. This is the cell
        /// value or content with the highest confidence score or is the most relevant to the
        /// query.
        /// </para>
        /// </summary>
        public bool? TopAnswer { get; set; }

        /// <summary>
        /// Checks to see if the TopAnswer property is set.
        /// </summary>
        internal bool IsSetTopAnswer() => this.TopAnswer.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The actual value or content within a table cell. A table cell could contain a date
        /// value of a year, or a string value of text, for example.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
