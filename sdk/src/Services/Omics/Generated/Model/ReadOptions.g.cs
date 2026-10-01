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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Read options for an annotation import job.
    /// </summary>
    public partial class ReadOptions
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The file's comment character.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// The file's encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Encoding { get; set; }

        /// <summary>
        /// Checks to see if the Encoding property is set.
        /// </summary>
        internal bool IsSetEncoding() => this.Encoding != null;

        /// <summary>
        /// Gets and sets the property Escape. 
        /// <para>
        /// A character for escaping quotes in the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string Escape { get; set; }

        /// <summary>
        /// Checks to see if the Escape property is set.
        /// </summary>
        internal bool IsSetEscape() => this.Escape != null;

        /// <summary>
        /// Gets and sets the property EscapeQuotes. 
        /// <para>
        /// Whether quotes need to be escaped in the file.
        /// </para>
        /// </summary>
        public bool? EscapeQuotes { get; set; }

        /// <summary>
        /// Checks to see if the EscapeQuotes property is set.
        /// </summary>
        internal bool IsSetEscapeQuotes() => this.EscapeQuotes.HasValue;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// Whether the file has a header row.
        /// </para>
        /// </summary>
        public bool? Header { get; set; }

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header.HasValue;

        /// <summary>
        /// Gets and sets the property LineSep. 
        /// <para>
        /// A line separator for the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string LineSep { get; set; }

        /// <summary>
        /// Checks to see if the LineSep property is set.
        /// </summary>
        internal bool IsSetLineSep() => this.LineSep != null;

        /// <summary>
        /// Gets and sets the property Quote. 
        /// <para>
        /// The file's quote character.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string Quote { get; set; }

        /// <summary>
        /// Checks to see if the Quote property is set.
        /// </summary>
        internal bool IsSetQuote() => this.Quote != null;

        /// <summary>
        /// Gets and sets the property QuoteAll. 
        /// <para>
        /// Whether all values need to be quoted, or just those that contain quotes.
        /// </para>
        /// </summary>
        public bool? QuoteAll { get; set; }

        /// <summary>
        /// Checks to see if the QuoteAll property is set.
        /// </summary>
        internal bool IsSetQuoteAll() => this.QuoteAll.HasValue;

        /// <summary>
        /// Gets and sets the property Sep. 
        /// <para>
        /// The file's field separator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Sep { get; set; }

        /// <summary>
        /// Checks to see if the Sep property is set.
        /// </summary>
        internal bool IsSetSep() => this.Sep != null;
    }
}
