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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The options that determine the numeric separator configuration.
    /// </summary>
    public partial class NumericSeparatorConfiguration
    {
        private NumericSeparatorSymbol _decimalSeparator;
        private ThousandSeparatorOptions _thousandsSeparator;

        /// <summary>
        /// Gets and sets the property DecimalSeparator. 
        /// <para>
        /// Determines the decimal separator.
        /// </para>
        /// </summary>
        public NumericSeparatorSymbol DecimalSeparator
        {
            get { return this._decimalSeparator; }
            set { this._decimalSeparator = value; }
        }

        // Check to see if DecimalSeparator property is set
        internal bool IsSetDecimalSeparator()
        {
            return this._decimalSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property ThousandsSeparator. 
        /// <para>
        /// The options that determine the thousands separator configuration.
        /// </para>
        /// </summary>
        public ThousandSeparatorOptions ThousandsSeparator
        {
            get { return this._thousandsSeparator; }
            set { this._thousandsSeparator = value; }
        }

        // Check to see if ThousandsSeparator property is set
        internal bool IsSetThousandsSeparator()
        {
            return this._thousandsSeparator != null;
        }

    }
}