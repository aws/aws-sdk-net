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
    /// Contains options specific to processing inbound X12 EDI files.
    /// </summary>
    public partial class X12InboundEdiOptions
    {
        private X12AcknowledgmentOptions _acknowledgmentOptions;

        /// <summary>
        /// Gets and sets the property AcknowledgmentOptions. 
        /// <para>
        /// Specifies acknowledgment options for inbound X12 EDI files. These options control
        /// how functional and technical acknowledgments are handled.
        /// </para>
        /// </summary>
        public X12AcknowledgmentOptions AcknowledgmentOptions
        {
            get { return this._acknowledgmentOptions; }
            set { this._acknowledgmentOptions = value; }
        }

        // Check to see if AcknowledgmentOptions property is set
        internal bool IsSetAcknowledgmentOptions()
        {
            return this._acknowledgmentOptions != null;
        }

    }
}