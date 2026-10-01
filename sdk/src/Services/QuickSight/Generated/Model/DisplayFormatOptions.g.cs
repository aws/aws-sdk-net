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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents additional options for display formatting.
    /// </summary>
    public partial class DisplayFormatOptions
    {
        /// <summary>
        /// Gets and sets the property BlankCellFormat. 
        /// <para>
        /// Determines the blank cell format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string BlankCellFormat { get; set; }

        /// <summary>
        /// Checks to see if the BlankCellFormat property is set.
        /// </summary>
        internal bool IsSetBlankCellFormat() => this.BlankCellFormat != null;

        /// <summary>
        /// Gets and sets the property CurrencySymbol. 
        /// <para>
        /// The currency symbol, such as <c>USD</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Checks to see if the CurrencySymbol property is set.
        /// </summary>
        internal bool IsSetCurrencySymbol() => this.CurrencySymbol != null;

        /// <summary>
        /// Gets and sets the property DateFormat. 
        /// <para>
        /// Determines the <c>DateTime</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DateFormat { get; set; }

        /// <summary>
        /// Checks to see if the DateFormat property is set.
        /// </summary>
        internal bool IsSetDateFormat() => this.DateFormat != null;

        /// <summary>
        /// Gets and sets the property DecimalSeparator. 
        /// <para>
        /// Determines the decimal separator.
        /// </para>
        /// </summary>
        public TopicNumericSeparatorSymbol DecimalSeparator { get; set; }

        /// <summary>
        /// Checks to see if the DecimalSeparator property is set.
        /// </summary>
        internal bool IsSetDecimalSeparator() => this.DecimalSeparator != null;

        /// <summary>
        /// Gets and sets the property FractionDigits. 
        /// <para>
        /// Determines the number of fraction digits.
        /// </para>
        /// </summary>
        public int? FractionDigits { get; set; }

        /// <summary>
        /// Checks to see if the FractionDigits property is set.
        /// </summary>
        internal bool IsSetFractionDigits() => this.FractionDigits.HasValue;

        /// <summary>
        /// Gets and sets the property GroupingSeparator. 
        /// <para>
        /// Determines the grouping separator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string GroupingSeparator { get; set; }

        /// <summary>
        /// Checks to see if the GroupingSeparator property is set.
        /// </summary>
        internal bool IsSetGroupingSeparator() => this.GroupingSeparator != null;

        /// <summary>
        /// Gets and sets the property NegativeFormat. 
        /// <para>
        /// The negative format.
        /// </para>
        /// </summary>
        public NegativeFormat NegativeFormat { get; set; }

        /// <summary>
        /// Checks to see if the NegativeFormat property is set.
        /// </summary>
        internal bool IsSetNegativeFormat() => this.NegativeFormat != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix value for a display format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// The suffix value for a display format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Suffix { get; set; }

        /// <summary>
        /// Checks to see if the Suffix property is set.
        /// </summary>
        internal bool IsSetSuffix() => this.Suffix != null;

        /// <summary>
        /// Gets and sets the property UnitScaler. 
        /// <para>
        /// The unit scaler. Valid values for this structure are: <c>NONE</c>, <c>AUTO</c>, <c>THOUSANDS</c>,
        /// <c>MILLIONS</c>, <c>BILLIONS</c>, and <c>TRILLIONS</c>.
        /// </para>
        /// </summary>
        public NumberScale UnitScaler { get; set; }

        /// <summary>
        /// Checks to see if the UnitScaler property is set.
        /// </summary>
        internal bool IsSetUnitScaler() => this.UnitScaler != null;

        /// <summary>
        /// Gets and sets the property UseBlankCellFormat. 
        /// <para>
        /// A Boolean value that indicates whether to use blank cell format.
        /// </para>
        /// </summary>
        public bool? UseBlankCellFormat { get; set; }

        /// <summary>
        /// Checks to see if the UseBlankCellFormat property is set.
        /// </summary>
        internal bool IsSetUseBlankCellFormat() => this.UseBlankCellFormat.HasValue;

        /// <summary>
        /// Gets and sets the property UseGrouping. 
        /// <para>
        /// A Boolean value that indicates whether to use grouping.
        /// </para>
        /// </summary>
        public bool? UseGrouping { get; set; }

        /// <summary>
        /// Checks to see if the UseGrouping property is set.
        /// </summary>
        internal bool IsSetUseGrouping() => this.UseGrouping.HasValue;
    }
}
