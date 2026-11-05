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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Nielsen CBET
    /// </summary>
    public partial class NielsenCBET
    {
        /// <summary>
        /// Gets and sets the property CbetCheckDigitString. Enter the CBET check digits to use
        /// in the watermark.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CbetCheckDigitString { get; set; }

        /// <summary>
        /// Checks to see if the CbetCheckDigitString property is set.
        /// </summary>
        internal bool IsSetCbetCheckDigitString() => this.CbetCheckDigitString != null;

        /// <summary>
        /// Gets and sets the property CbetStepaside. Determines the method of CBET insertion
        /// mode when prior encoding is detected on the same layer.
        /// </summary>
        [AWSProperty(Required = true)]
        public NielsenWatermarksCbetStepaside CbetStepaside { get; set; }

        /// <summary>
        /// Checks to see if the CbetStepaside property is set.
        /// </summary>
        internal bool IsSetCbetStepaside() => this.CbetStepaside != null;

        /// <summary>
        /// Gets and sets the property Csid. Enter the CBET Source ID (CSID) to use in the watermark
        /// </summary>
        [AWSProperty(Required = true)]
        public string Csid { get; set; }

        /// <summary>
        /// Checks to see if the Csid property is set.
        /// </summary>
        internal bool IsSetCsid() => this.Csid != null;
    }
}
