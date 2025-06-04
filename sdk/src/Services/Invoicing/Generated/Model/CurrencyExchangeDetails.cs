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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The details of currency exchange.
    /// </summary>
    public partial class CurrencyExchangeDetails
    {
        private string _rate;
        private string _sourceCurrencyCode;
        private string _targetCurrencyCode;

        /// <summary>
        /// Gets and sets the property Rate. 
        /// <para>
        /// The currency exchange rate. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }

        // Check to see if Rate property is set
        internal bool IsSetRate()
        {
            return this._rate != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCurrencyCode. 
        /// <para>
        /// The exchange source currency. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SourceCurrencyCode
        {
            get { return this._sourceCurrencyCode; }
            set { this._sourceCurrencyCode = value; }
        }

        // Check to see if SourceCurrencyCode property is set
        internal bool IsSetSourceCurrencyCode()
        {
            return this._sourceCurrencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCurrencyCode. 
        /// <para>
        /// The exchange target currency. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TargetCurrencyCode
        {
            get { return this._targetCurrencyCode; }
            set { this._targetCurrencyCode = value; }
        }

        // Check to see if TargetCurrencyCode property is set
        internal bool IsSetTargetCurrencyCode()
        {
            return this._targetCurrencyCode != null;
        }

    }
}