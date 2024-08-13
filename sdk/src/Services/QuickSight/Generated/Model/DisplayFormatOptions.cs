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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents additional options for display formatting.
    /// </summary>
    public partial class DisplayFormatOptions
    {
        private string _blankCellFormat;
        private string _currencySymbol;
        private string _dateFormat;
        private TopicNumericSeparatorSymbol _decimalSeparator;
        private int? _fractionDigits;
        private string _groupingSeparator;
        private NegativeFormat _negativeFormat;
        private string _prefix;
        private string _suffix;
        private NumberScale _unitScaler;
        private bool? _useBlankCellFormat;
        private bool? _useGrouping;

        /// <summary>
        /// Gets and sets the property BlankCellFormat. 
        /// <para>
        /// Determines the blank cell format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string BlankCellFormat
        {
            get { return this._blankCellFormat; }
            set { this._blankCellFormat = value; }
        }

        // Check to see if BlankCellFormat property is set
        internal bool IsSetBlankCellFormat()
        {
            return this._blankCellFormat != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencySymbol. 
        /// <para>
        /// The currency symbol, such as <c>USD</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string CurrencySymbol
        {
            get { return this._currencySymbol; }
            set { this._currencySymbol = value; }
        }

        // Check to see if CurrencySymbol property is set
        internal bool IsSetCurrencySymbol()
        {
            return this._currencySymbol != null;
        }

        /// <summary>
        /// Gets and sets the property DateFormat. 
        /// <para>
        /// Determines the <c>DateTime</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DateFormat
        {
            get { return this._dateFormat; }
            set { this._dateFormat = value; }
        }

        // Check to see if DateFormat property is set
        internal bool IsSetDateFormat()
        {
            return this._dateFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DecimalSeparator. 
        /// <para>
        /// Determines the decimal separator.
        /// </para>
        /// </summary>
        public TopicNumericSeparatorSymbol DecimalSeparator
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
        /// Gets and sets the property FractionDigits. 
        /// <para>
        /// Determines the number of fraction digits.
        /// </para>
        /// </summary>
        public int? FractionDigits
        {
            get { return this._fractionDigits; }
            set { this._fractionDigits = value; }
        }

        // Check to see if FractionDigits property is set
        internal bool IsSetFractionDigits()
        {
            return this._fractionDigits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupingSeparator. 
        /// <para>
        /// Determines the grouping separator.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string GroupingSeparator
        {
            get { return this._groupingSeparator; }
            set { this._groupingSeparator = value; }
        }

        // Check to see if GroupingSeparator property is set
        internal bool IsSetGroupingSeparator()
        {
            return this._groupingSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property NegativeFormat. 
        /// <para>
        /// The negative format.
        /// </para>
        /// </summary>
        public NegativeFormat NegativeFormat
        {
            get { return this._negativeFormat; }
            set { this._negativeFormat = value; }
        }

        // Check to see if NegativeFormat property is set
        internal bool IsSetNegativeFormat()
        {
            return this._negativeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix value for a display format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property Suffix. 
        /// <para>
        /// The suffix value for a display format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property UnitScaler. 
        /// <para>
        /// The unit scaler. Valid values for this structure are: <c>NONE</c>, <c>AUTO</c>, <c>THOUSANDS</c>,
        /// <c>MILLIONS</c>, <c>BILLIONS</c>, and <c>TRILLIONS</c>.
        /// </para>
        /// </summary>
        public NumberScale UnitScaler
        {
            get { return this._unitScaler; }
            set { this._unitScaler = value; }
        }

        // Check to see if UnitScaler property is set
        internal bool IsSetUnitScaler()
        {
            return this._unitScaler != null;
        }

        /// <summary>
        /// Gets and sets the property UseBlankCellFormat. 
        /// <para>
        /// A Boolean value that indicates whether to use blank cell format.
        /// </para>
        /// </summary>
        public bool? UseBlankCellFormat
        {
            get { return this._useBlankCellFormat; }
            set { this._useBlankCellFormat = value; }
        }

        // Check to see if UseBlankCellFormat property is set
        internal bool IsSetUseBlankCellFormat()
        {
            return this._useBlankCellFormat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseGrouping. 
        /// <para>
        /// A Boolean value that indicates whether to use grouping.
        /// </para>
        /// </summary>
        public bool? UseGrouping
        {
            get { return this._useGrouping; }
            set { this._useGrouping = value; }
        }

        // Check to see if UseGrouping property is set
        internal bool IsSetUseGrouping()
        {
            return this._useGrouping.HasValue; 
        }

    }
}