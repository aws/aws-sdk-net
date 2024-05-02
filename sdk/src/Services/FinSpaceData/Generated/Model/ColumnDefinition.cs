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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// The definition of a column in a tabular Dataset.
    /// </summary>
    public partial class ColumnDefinition
    {
        private string _columnDescription;
        private string _columnName;
        private ColumnDataType _dataType;

        /// <summary>
        /// Gets and sets the property ColumnDescription. 
        /// <para>
        /// Description for a column.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string ColumnDescription
        {
            get { return this._columnDescription; }
            set { this._columnDescription = value; }
        }

        // Check to see if ColumnDescription property is set
        internal bool IsSetColumnDescription()
        {
            return this._columnDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of a column.
        /// </para>
        /// </summary>
        [AWSProperty(Max=126)]
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
        /// Gets and sets the property DataType. 
        /// <para>
        /// Data type of a column.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STRING</c> – A String data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>CHAR</c> – A char data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>INTEGER</c> – An integer data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>TINYINT</c> – A tinyint data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>SMALLINT</c> – A smallint data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>BIGINT</c> – A bigint data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>FLOAT</c> – A float data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>DOUBLE</c> – A double data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>DATE</c> – A date data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>DATETIME</c> – A datetime data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>BOOLEAN</c> – A boolean data type.
        /// </para>
        ///  
        /// <para>
        ///  <c>BINARY</c> – A binary data type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ColumnDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

    }
}