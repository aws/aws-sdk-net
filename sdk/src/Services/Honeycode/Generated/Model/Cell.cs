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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that represents a single cell in a table.
    /// </summary>
    public partial class Cell
    {
        private Format _format;
        private string _formattedValue;
        private List<string> _formattedValues = new List<string>();
        private string _formula;
        private string _rawValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the cell. If this field is empty, then the format is either not specified
        /// in the workbook or the format is set to AUTO.
        /// </para>
        /// </summary>
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property FormattedValue. 
        /// <para>
        ///  The formatted value of the cell. This is the value that you see displayed in the
        /// cell in the UI. 
        /// </para>
        ///  
        /// <para>
        ///  Note that the formatted value of a cell is always represented as a string irrespective
        /// of the data that is stored in the cell. For example, if a cell contains a date, the
        /// formatted value of the cell is the string representation of the formatted date being
        /// shown in the cell in the UI. See details in the rawValue field below for how cells
        /// of different formats will have different raw and formatted values. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string FormattedValue
        {
            get { return this._formattedValue; }
            set { this._formattedValue = value; }
        }

        // Check to see if FormattedValue property is set
        internal bool IsSetFormattedValue()
        {
            return this._formattedValue != null;
        }

        /// <summary>
        /// Gets and sets the property FormattedValues. 
        /// <para>
        ///  A list of formatted values of the cell. This field is only returned when the cell
        /// is ROWSET format (aka multi-select or multi-record picklist). Values in the list are
        /// always represented as strings. The formattedValue field will be empty if this field
        /// is returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=220)]
        public List<string> FormattedValues
        {
            get { return this._formattedValues; }
            set { this._formattedValues = value; }
        }

        // Check to see if FormattedValues property is set
        internal bool IsSetFormattedValues()
        {
            return this._formattedValues != null && this._formattedValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Formula. 
        /// <para>
        ///  The formula contained in the cell. This field is empty if a cell does not have a
        /// formula. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=8192)]
        public string Formula
        {
            get { return this._formula; }
            set { this._formula = value; }
        }

        // Check to see if Formula property is set
        internal bool IsSetFormula()
        {
            return this._formula != null;
        }

        /// <summary>
        /// Gets and sets the property RawValue. 
        /// <para>
        ///  The raw value of the data contained in the cell. The raw value depends on the format
        /// of the data in the cell. However the attribute in the API return value is always a
        /// string containing the raw value. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format DATE, DATE_TIME or TIME have the raw value as a floating point
        /// number where the whole number represents the number of days since 1/1/1900 and the
        /// fractional part represents the fraction of the day since midnight. For example, a
        /// cell with date 11/3/2020 has the raw value "44138". A cell with the time 9:00 AM has
        /// the raw value "0.375" and a cell with date/time value of 11/3/2020 9:00 AM has the
        /// raw value "44138.375". Notice that even though the raw value is a number in all three
        /// cases, it is still represented as a string. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format NUMBER, CURRENCY, PERCENTAGE and ACCOUNTING have the raw value
        /// of the data as the number representing the data being displayed. For example, the
        /// number 1.325 with two decimal places in the format will have it's raw value as "1.325"
        /// and formatted value as "1.33". A currency value for $10 will have the raw value as
        /// "10" and formatted value as "$10.00". A value representing 20% with two decimal places
        /// in the format will have its raw value as "0.2" and the formatted value as "20.00%".
        /// An accounting value of -$25 will have "-25" as the raw value and "$ (25.00)" as the
        /// formatted value. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format TEXT will have the raw text as the raw value. For example, a cell
        /// with text "John Smith" will have "John Smith" as both the raw value and the formatted
        /// value. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format CONTACT will have the name of the contact as a formatted value
        /// and the email address of the contact as the raw value. For example, a contact for
        /// John Smith will have "John Smith" as the formatted value and "john.smith@example.com"
        /// as the raw value. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format ROWLINK (aka picklist) will have the first column of the linked
        /// row as the formatted value and the row id of the linked row as the raw value. For
        /// example, a cell containing a picklist to a table that displays task status might have
        /// "Completed" as the formatted value and "row:dfcefaee-5b37-4355-8f28-40c3e4ff5dd4/ca432b2f-b8eb-431d-9fb5-cbe0342f9f03"
        /// as the raw value. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format ROWSET (aka multi-select or multi-record picklist) will by default
        /// have the first column of each of the linked rows as the formatted value in the list,
        /// and the rowset id of the linked rows as the raw value. For example, a cell containing
        /// a multi-select picklist to a table that contains items might have "Item A", "Item
        /// B" in the formatted value list and "rows:b742c1f4-6cb0-4650-a845-35eb86fcc2bb/ [fdea123b-8f68-474a-aa8a-5ff87aa333af,6daf41f0-a138-4eee-89da-123086d36ecf]"
        /// as the raw value. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format ATTACHMENT will have the name of the attachment as the formatted
        /// value and the attachment id as the raw value. For example, a cell containing an attachment
        /// named "image.jpeg" will have "image.jpeg" as the formatted value and "attachment:ca432b2f-b8eb-431d-9fb5-cbe0342f9f03"
        /// as the raw value. 
        /// </para>
        ///  
        /// <para>
        ///  Cells with format AUTO or cells without any format that are auto-detected as one
        /// of the formats above will contain the raw and formatted values as mentioned above,
        /// based on the auto-detected formats. If there is no auto-detected format, the raw and
        /// formatted values will be the same as the data in the cell. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32767)]
        public string RawValue
        {
            get { return this._rawValue; }
            set { this._rawValue = value; }
        }

        // Check to see if RawValue property is set
        internal bool IsSetRawValue()
        {
            return this._rawValue != null;
        }

    }
}