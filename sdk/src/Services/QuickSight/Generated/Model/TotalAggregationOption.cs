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
    /// The total aggregation settings map of a field id.
    /// </summary>
    public partial class TotalAggregationOption
    {
        private string _fieldId;
        private TotalAggregationFunction _totalAggregationFunction;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field id that's associated with the total aggregation option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAggregationFunction. 
        /// <para>
        /// The total aggregation function that you want to set for a specified field id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TotalAggregationFunction TotalAggregationFunction
        {
            get { return this._totalAggregationFunction; }
            set { this._totalAggregationFunction = value; }
        }

        // Check to see if TotalAggregationFunction property is set
        internal bool IsSetTotalAggregationFunction()
        {
            return this._totalAggregationFunction != null;
        }

    }
}