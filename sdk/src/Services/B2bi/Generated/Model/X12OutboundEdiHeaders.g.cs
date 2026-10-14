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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// A structure containing the details for an outbound EDI object.
    /// </summary>
    public partial class X12OutboundEdiHeaders
    {
        /// <summary>
        /// Gets and sets the property ControlNumbers. 
        /// <para>
        /// Specifies control number configuration for outbound X12 EDI headers. These settings
        /// determine the starting values for interchange, functional group, and transaction set
        /// control numbers.
        /// </para>
        /// </summary>
        public X12ControlNumbers ControlNumbers { get; set; }

        /// <summary>
        /// Checks to see if the ControlNumbers property is set.
        /// </summary>
        internal bool IsSetControlNumbers() => this.ControlNumbers != null;

        /// <summary>
        /// Gets and sets the property Delimiters. 
        /// <para>
        /// The delimiters, for example semicolon (<c>;</c>), that separates sections of the headers
        /// for the X12 object.
        /// </para>
        /// </summary>
        public X12Delimiters Delimiters { get; set; }

        /// <summary>
        /// Checks to see if the Delimiters property is set.
        /// </summary>
        internal bool IsSetDelimiters() => this.Delimiters != null;

        /// <summary>
        /// Gets and sets the property FunctionalGroupHeaders. 
        /// <para>
        /// The functional group headers for the X12 object.
        /// </para>
        /// </summary>
        public X12FunctionalGroupHeaders FunctionalGroupHeaders { get; set; }

        /// <summary>
        /// Checks to see if the FunctionalGroupHeaders property is set.
        /// </summary>
        internal bool IsSetFunctionalGroupHeaders() => this.FunctionalGroupHeaders != null;

        /// <summary>
        /// Gets and sets the property Gs05TimeFormat.
        /// </summary>
        public X12GS05TimeFormat Gs05TimeFormat { get; set; }

        /// <summary>
        /// Checks to see if the Gs05TimeFormat property is set.
        /// </summary>
        internal bool IsSetGs05TimeFormat() => this.Gs05TimeFormat != null;

        /// <summary>
        /// Gets and sets the property InterchangeControlHeaders. 
        /// <para>
        /// In X12 EDI messages, delimiters are used to mark the end of segments or elements,
        /// and are defined in the interchange control header.
        /// </para>
        /// </summary>
        public X12InterchangeControlHeaders InterchangeControlHeaders { get; set; }

        /// <summary>
        /// Checks to see if the InterchangeControlHeaders property is set.
        /// </summary>
        internal bool IsSetInterchangeControlHeaders() => this.InterchangeControlHeaders != null;

        /// <summary>
        /// Gets and sets the property ValidateEdi. 
        /// <para>
        /// Specifies whether or not to validate the EDI for this X12 object: <c>TRUE</c> or <c>FALSE</c>.
        /// When enabled, this performs both standard EDI validation and applies any configured
        /// custom validation rules including element length constraints, code list validations,
        /// and element requirement checks. Validation results are returned in the response validation
        /// messages.
        /// </para>
        /// </summary>
        public bool? ValidateEdi { get; set; }

        /// <summary>
        /// Checks to see if the ValidateEdi property is set.
        /// </summary>
        internal bool IsSetValidateEdi() => this.ValidateEdi.HasValue;
    }
}
