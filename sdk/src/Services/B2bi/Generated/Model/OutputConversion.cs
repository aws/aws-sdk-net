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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains the formatting options for an outbound transformer (takes JSON or XML as
    /// input and converts it to an EDI document (currently only X12 format is supported).
    /// </summary>
    public partial class OutputConversion
    {
        private AdvancedOptions _advancedOptions;
        private FormatOptions _formatOptions;
        private ToFormat _toFormat;

        /// <summary>
        /// Gets and sets the property AdvancedOptions.
        /// </summary>
        public AdvancedOptions AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FormatOptions. 
        /// <para>
        /// A structure that contains the X12 transaction set and version for the transformer
        /// output.
        /// </para>
        /// </summary>
        public FormatOptions FormatOptions
        {
            get { return this._formatOptions; }
            set { this._formatOptions = value; }
        }

        // Check to see if FormatOptions property is set
        internal bool IsSetFormatOptions()
        {
            return this._formatOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ToFormat. 
        /// <para>
        /// The format for the output from an outbound transformer: only X12 is currently supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ToFormat ToFormat
        {
            get { return this._toFormat; }
            set { this._toFormat = value; }
        }

        // Check to see if ToFormat property is set
        internal bool IsSetToFormat()
        {
            return this._toFormat != null;
        }

    }
}