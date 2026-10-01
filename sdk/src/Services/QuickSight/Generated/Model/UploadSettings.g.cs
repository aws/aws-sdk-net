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
    /// Information about the format for a source file or files.
    /// </summary>
    public partial class UploadSettings
    {
        /// <summary>
        /// Gets and sets the property ContainsHeader. 
        /// <para>
        /// Whether the file has a header row, or the files each have a header row.
        /// </para>
        /// </summary>
        public bool? ContainsHeader { get; set; }

        /// <summary>
        /// Checks to see if the ContainsHeader property is set.
        /// </summary>
        internal bool IsSetContainsHeader() => this.ContainsHeader.HasValue;

        /// <summary>
        /// Gets and sets the property CustomCellAddressRange. 
        /// <para>
        /// A custom cell address range for Excel files, specifying which cells to import from
        /// the spreadsheet.
        /// </para>
        /// </summary>
        public string CustomCellAddressRange { get; set; }

        /// <summary>
        /// Checks to see if the CustomCellAddressRange property is set.
        /// </summary>
        internal bool IsSetCustomCellAddressRange() => this.CustomCellAddressRange != null;

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// The delimiter between values in the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Checks to see if the Delimiter property is set.
        /// </summary>
        internal bool IsSetDelimiter() => this.Delimiter != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// File format.
        /// </para>
        /// </summary>
        public FileFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property StartFromRow. 
        /// <para>
        /// A row number to start reading data from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? StartFromRow { get; set; }

        /// <summary>
        /// Checks to see if the StartFromRow property is set.
        /// </summary>
        internal bool IsSetStartFromRow() => this.StartFromRow.HasValue;

        /// <summary>
        /// Gets and sets the property TextQualifier. 
        /// <para>
        /// Text qualifier.
        /// </para>
        /// </summary>
        public TextQualifier TextQualifier { get; set; }

        /// <summary>
        /// Checks to see if the TextQualifier property is set.
        /// </summary>
        internal bool IsSetTextQualifier() => this.TextQualifier != null;
    }
}
