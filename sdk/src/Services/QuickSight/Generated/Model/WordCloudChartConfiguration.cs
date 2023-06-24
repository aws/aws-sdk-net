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
    /// The configuration of a word cloud visual.
    /// </summary>
    public partial class WordCloudChartConfiguration
    {
        private ChartAxisLabelOptions _categoryLabelOptions;
        private WordCloudFieldWells _fieldWells;
        private WordCloudSortConfiguration _sortConfiguration;
        private WordCloudOptions _wordCloudOptions;

        /// <summary>
        /// Gets and sets the property CategoryLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility, and sort icon visibility) for the
        /// word cloud category.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions
        {
            get { return this._categoryLabelOptions; }
            set { this._categoryLabelOptions = value; }
        }

        // Check to see if CategoryLabelOptions property is set
        internal bool IsSetCategoryLabelOptions()
        {
            return this._categoryLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public WordCloudFieldWells FieldWells
        {
            get { return this._fieldWells; }
            set { this._fieldWells = value; }
        }

        // Check to see if FieldWells property is set
        internal bool IsSetFieldWells()
        {
            return this._fieldWells != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a word cloud visual.
        /// </para>
        /// </summary>
        public WordCloudSortConfiguration SortConfiguration
        {
            get { return this._sortConfiguration; }
            set { this._sortConfiguration = value; }
        }

        // Check to see if SortConfiguration property is set
        internal bool IsSetSortConfiguration()
        {
            return this._sortConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WordCloudOptions. 
        /// <para>
        /// The options for a word cloud visual.
        /// </para>
        /// </summary>
        public WordCloudOptions WordCloudOptions
        {
            get { return this._wordCloudOptions; }
            set { this._wordCloudOptions = value; }
        }

        // Check to see if WordCloudOptions property is set
        internal bool IsSetWordCloudOptions()
        {
            return this._wordCloudOptions != null;
        }

    }
}