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
    /// The options that determine the currency display format configuration.
    /// </summary>
    public partial class CurrencyDisplayFormatConfiguration
    {
        private DecimalPlacesConfiguration _decimalPlacesConfiguration;
        private NegativeValueConfiguration _negativeValueConfiguration;
        private NullValueFormatConfiguration _nullValueFormatConfiguration;
        private NumberScale _numberScale;
        private string _prefix;
        private NumericSeparatorConfiguration _separatorConfiguration;
        private string _suffix;
        private string _symbol;

        /// <summary>
        /// Gets and sets the property DecimalPlacesConfiguration. 
        /// <para>
        /// The option that determines the decimal places configuration.
        /// </para>
        /// </summary>
        public DecimalPlacesConfiguration DecimalPlacesConfiguration
        {
            get { return this._decimalPlacesConfiguration; }
            set { this._decimalPlacesConfiguration = value; }
        }

        // Check to see if DecimalPlacesConfiguration property is set
        internal bool IsSetDecimalPlacesConfiguration()
        {
            return this._decimalPlacesConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NegativeValueConfiguration. 
        /// <para>
        /// The options that determine the negative value configuration.
        /// </para>
        /// </summary>
        public NegativeValueConfiguration NegativeValueConfiguration
        {
            get { return this._negativeValueConfiguration; }
            set { this._negativeValueConfiguration = value; }
        }

        // Check to see if NegativeValueConfiguration property is set
        internal bool IsSetNegativeValueConfiguration()
        {
            return this._negativeValueConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NullValueFormatConfiguration. 
        /// <para>
        /// The options that determine the null value format configuration.
        /// </para>
        /// </summary>
        public NullValueFormatConfiguration NullValueFormatConfiguration
        {
            get { return this._nullValueFormatConfiguration; }
            set { this._nullValueFormatConfiguration = value; }
        }

        // Check to see if NullValueFormatConfiguration property is set
        internal bool IsSetNullValueFormatConfiguration()
        {
            return this._nullValueFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NumberScale. 
        /// <para>
        /// Determines the number scale value for the currency format.
        /// </para>
        /// </summary>
        public NumberScale NumberScale
        {
            get { return this._numberScale; }
            set { this._numberScale = value; }
        }

        // Check to see if NumberScale property is set
        internal bool IsSetNumberScale()
        {
            return this._numberScale != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Determines the prefix value of the currency format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property SeparatorConfiguration. 
        /// <para>
        /// The options that determine the numeric separator configuration.
        /// </para>
        /// </summary>
        public NumericSeparatorConfiguration SeparatorConfiguration
        {
            get { return this._separatorConfiguration; }
            set { this._separatorConfiguration = value; }
        }

        // Check to see if SeparatorConfiguration property is set
        internal bool IsSetSeparatorConfiguration()
        {
            return this._separatorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// Determines the suffix value of the currency format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Suffix
        {
            get { return this._suffix; }
            set { this._suffix = value; }
        }

        // Check to see if Suffix property is set
        internal bool IsSetSuffix()
        {
            return this._suffix != null;
        }

        /// <summary>
        /// Gets and sets the property Symbol. 
        /// <para>
        /// Determines the symbol for the currency format.
        /// </para>
        /// </summary>
        public string Symbol
        {
            get { return this._symbol; }
            set { this._symbol = value; }
        }

        // Check to see if Symbol property is set
        internal bool IsSetSymbol()
        {
            return this._symbol != null;
        }

    }
}