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
    /// A transform operation that casts a column to a different type.
    /// </summary>
    public partial class CastColumnTypeOperation
    {
        private string _columnName;
        private string _format;
        private ColumnDataType _newColumnType;
        private ColumnDataSubType _subType;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// Column name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// When casting a column from string to datetime type, you can supply a string in a format
        /// supported by Amazon QuickSight to denote the source data format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string Format
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
        /// Gets and sets the property NewColumnType. 
        /// <para>
        /// New column data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnDataType NewColumnType
        {
            get { return this._newColumnType; }
            set { this._newColumnType = value; }
        }

        // Check to see if NewColumnType property is set
        internal bool IsSetNewColumnType()
        {
            return this._newColumnType != null;
        }

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The sub data type of the new column. Sub types are only available for decimal columns
        /// that are part of a SPICE dataset.
        /// </para>
        /// </summary>
        public ColumnDataSubType SubType
        {
            get { return this._subType; }
            set { this._subType = value; }
        }

        // Check to see if SubType property is set
        internal bool IsSetSubType()
        {
            return this._subType != null;
        }

    }
}