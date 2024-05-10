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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private string _cbetCheckDigitString;
        private NielsenWatermarksCbetStepaside _cbetStepaside;
        private string _csid;

        /// <summary>
        /// Gets and sets the property CbetCheckDigitString. Enter the CBET check digits to use
        /// in the watermark.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public string CbetCheckDigitString
        {
            get { return this._cbetCheckDigitString; }
            set { this._cbetCheckDigitString = value; }
        }

        // Check to see if CbetCheckDigitString property is set
        internal bool IsSetCbetCheckDigitString()
        {
            return this._cbetCheckDigitString != null;
        }

        /// <summary>
        /// Gets and sets the property CbetStepaside. Determines the method of CBET insertion
        /// mode when prior encoding is detected on the same layer.
        /// </summary>
        [AWSProperty(Required=true)]
        public NielsenWatermarksCbetStepaside CbetStepaside
        {
            get { return this._cbetStepaside; }
            set { this._cbetStepaside = value; }
        }

        // Check to see if CbetStepaside property is set
        internal bool IsSetCbetStepaside()
        {
            return this._cbetStepaside != null;
        }

        /// <summary>
        /// Gets and sets the property Csid. Enter the CBET Source ID (CSID) to use in the watermark
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=7)]
        public string Csid
        {
            get { return this._csid; }
            set { this._csid = value; }
        }

        // Check to see if Csid property is set
        internal bool IsSetCsid()
        {
            return this._csid != null;
        }

    }
}