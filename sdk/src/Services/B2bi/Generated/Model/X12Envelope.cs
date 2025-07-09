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
    /// A wrapper structure for an X12 definition object.
    /// 
    ///  
    /// <para>
    /// the X12 envelope ensures the integrity of the data and the efficiency of the information
    /// exchange. The X12 message structure has hierarchical levels. From highest to the lowest,
    /// they are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Interchange Envelope
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Functional Group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Transaction Set
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class X12Envelope
    {
        private X12OutboundEdiHeaders _common;
        private WrapOptions _wrapOptions;

        /// <summary>
        /// Gets and sets the property Common. 
        /// <para>
        /// A container for the X12 outbound EDI headers.
        /// </para>
        /// </summary>
        public X12OutboundEdiHeaders Common
        {
            get { return this._common; }
            set { this._common = value; }
        }

        // Check to see if Common property is set
        internal bool IsSetCommon()
        {
            return this._common != null;
        }

        /// <summary>
        /// Gets and sets the property WrapOptions.
        /// </summary>
        public WrapOptions WrapOptions
        {
            get { return this._wrapOptions; }
            set { this._wrapOptions = value; }
        }

        // Check to see if WrapOptions property is set
        internal bool IsSetWrapOptions()
        {
            return this._wrapOptions != null;
        }

    }
}