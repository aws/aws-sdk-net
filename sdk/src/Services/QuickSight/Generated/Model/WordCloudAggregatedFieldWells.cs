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
    /// The aggregated field wells of a word cloud.
    /// </summary>
    public partial class WordCloudAggregatedFieldWells
    {
        private List<DimensionField> _groupBy = new List<DimensionField>();
        private List<MeasureField> _size = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The group by field well of a word cloud. Values are grouped by group by fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<DimensionField> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && this._groupBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size field well of a word cloud. Values are aggregated based on group by fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<MeasureField> Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size != null && this._size.Count > 0; 
        }

    }
}