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
    /// An aggregation function that concatenates values from multiple rows into a single
    /// string with a specified separator.
    /// </summary>
    public partial class DataPrepListAggregationFunction
    {
        private bool? _distinct;
        private string _inputColumnName;
        private string _separator;

        /// <summary>
        /// Gets and sets the property Distinct. 
        /// <para>
        /// Whether to include only distinct values in the concatenated result, removing duplicates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Distinct
        {
            get { return this._distinct; }
            set { this._distinct = value; }
        }

        // Check to see if Distinct property is set
        internal bool IsSetDistinct()
        {
            return this._distinct.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputColumnName. 
        /// <para>
        /// The name of the column containing values to be concatenated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string InputColumnName
        {
            get { return this._inputColumnName; }
            set { this._inputColumnName = value; }
        }

        // Check to see if InputColumnName property is set
        internal bool IsSetInputColumnName()
        {
            return this._inputColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property Separator. 
        /// <para>
        /// The string used to separate values in the concatenated result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Separator
        {
            get { return this._separator; }
            set { this._separator = value; }
        }

        // Check to see if Separator property is set
        internal bool IsSetSeparator()
        {
            return this._separator != null;
        }

    }
}