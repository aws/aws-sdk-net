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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing the column name and column importance score for a column. 
    /// 
    ///  
    /// <para>
    /// Column importance helps you understand how columns contribute to your model, by identifying
    /// which columns in your records are more important than others.
    /// </para>
    /// </summary>
    public partial class ColumnImportance
    {
        private string _columnName;
        private double? _importance;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of a column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Importance. 
        /// <para>
        /// The column importance score for the column, as a decimal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Importance
        {
            get { return this._importance; }
            set { this._importance = value; }
        }

        // Check to see if Importance property is set
        internal bool IsSetImportance()
        {
            return this._importance.HasValue; 
        }

    }
}