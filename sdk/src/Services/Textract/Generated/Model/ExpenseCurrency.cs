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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Returns the kind of currency detected.
    /// </summary>
    public partial class ExpenseCurrency
    {
        private string _code;
        private float? _confidence;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Currency code for detected currency. the current supported codes are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// USD
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EUR
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GBP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CAD
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INR
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// JPY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CHF
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AUD
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CNY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BZR
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SEK
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HKD
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Percentage confideence in the detected currency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

    }
}