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
    /// A structure that represents a data aggregation.
    /// </summary>
    public partial class DataAggregation
    {
        private TopicTimeGranularity _datasetRowDateGranularity;
        private string _defaultDateColumnName;

        /// <summary>
        /// Gets and sets the property DatasetRowDateGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        public TopicTimeGranularity DatasetRowDateGranularity
        {
            get { return this._datasetRowDateGranularity; }
            set { this._datasetRowDateGranularity = value; }
        }

        // Check to see if DatasetRowDateGranularity property is set
        internal bool IsSetDatasetRowDateGranularity()
        {
            return this._datasetRowDateGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultDateColumnName. 
        /// <para>
        /// The column name for the default date.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DefaultDateColumnName
        {
            get { return this._defaultDateColumnName; }
            set { this._defaultDateColumnName = value; }
        }

        // Check to see if DefaultDateColumnName property is set
        internal bool IsSetDefaultDateColumnName()
        {
            return this._defaultDateColumnName != null;
        }

    }
}