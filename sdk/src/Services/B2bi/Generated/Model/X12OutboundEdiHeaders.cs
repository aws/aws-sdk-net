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
    /// A structure containing the details for an outbound EDI object.
    /// </summary>
    public partial class X12OutboundEdiHeaders
    {
        private X12Delimiters _delimiters;
        private X12FunctionalGroupHeaders _functionalGroupHeaders;
        private X12InterchangeControlHeaders _interchangeControlHeaders;
        private bool? _validateEdi;

        /// <summary>
        /// Gets and sets the property Delimiters. 
        /// <para>
        /// The delimiters, for example semicolon (<c>;</c>), that separates sections of the headers
        /// for the X12 object.
        /// </para>
        /// </summary>
        public X12Delimiters Delimiters
        {
            get { return this._delimiters; }
            set { this._delimiters = value; }
        }

        // Check to see if Delimiters property is set
        internal bool IsSetDelimiters()
        {
            return this._delimiters != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionalGroupHeaders. 
        /// <para>
        /// The functional group headers for the X12 object.
        /// </para>
        /// </summary>
        public X12FunctionalGroupHeaders FunctionalGroupHeaders
        {
            get { return this._functionalGroupHeaders; }
            set { this._functionalGroupHeaders = value; }
        }

        // Check to see if FunctionalGroupHeaders property is set
        internal bool IsSetFunctionalGroupHeaders()
        {
            return this._functionalGroupHeaders != null;
        }

        /// <summary>
        /// Gets and sets the property InterchangeControlHeaders. 
        /// <para>
        /// In X12 EDI messages, delimiters are used to mark the end of segments or elements,
        /// and are defined in the interchange control header.
        /// </para>
        /// </summary>
        public X12InterchangeControlHeaders InterchangeControlHeaders
        {
            get { return this._interchangeControlHeaders; }
            set { this._interchangeControlHeaders = value; }
        }

        // Check to see if InterchangeControlHeaders property is set
        internal bool IsSetInterchangeControlHeaders()
        {
            return this._interchangeControlHeaders != null;
        }

        /// <summary>
        /// Gets and sets the property ValidateEdi. 
        /// <para>
        /// Specifies whether or not to validate the EDI for this X12 object: <c>TRUE</c> or <c>FALSE</c>.
        /// </para>
        /// </summary>
        public bool ValidateEdi
        {
            get { return this._validateEdi.GetValueOrDefault(); }
            set { this._validateEdi = value; }
        }

        // Check to see if ValidateEdi property is set
        internal bool IsSetValidateEdi()
        {
            return this._validateEdi.HasValue; 
        }

    }
}