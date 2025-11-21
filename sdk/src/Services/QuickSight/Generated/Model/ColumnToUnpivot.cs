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
    /// Specifies a column to be unpivoted, transforming it from a column into rows with associated
    /// values.
    /// </summary>
    public partial class ColumnToUnpivot
    {
        private string _columnName;
        private string _newValue;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the column to unpivot from the source data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property NewValue. 
        /// <para>
        /// The value to assign to this column in the unpivoted result, typically the column name
        /// or a descriptive label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2047)]
        public string NewValue
        {
            get { return this._newValue; }
            set { this._newValue = value; }
        }

        // Check to see if NewValue property is set
        internal bool IsSetNewValue()
        {
            return this._newValue != null;
        }

    }
}