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
    /// Aggregated field wells of a tree map.
    /// </summary>
    public partial class TreeMapAggregatedFieldWells
    {
        private List<MeasureField> _colors = new List<MeasureField>();
        private List<DimensionField> _groups = new List<DimensionField>();
        private List<MeasureField> _sizes = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property Colors. 
        /// <para>
        /// The color field well of a tree map. Values are grouped by aggregations based on group
        /// by fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<MeasureField> Colors
        {
            get { return this._colors; }
            set { this._colors = value; }
        }

        // Check to see if Colors property is set
        internal bool IsSetColors()
        {
            return this._colors != null && this._colors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The group by field well of a tree map. Values are grouped based on group by fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<DimensionField> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sizes. 
        /// <para>
        /// The size field well of a tree map. Values are aggregated based on group by fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<MeasureField> Sizes
        {
            get { return this._sizes; }
            set { this._sizes = value; }
        }

        // Check to see if Sizes property is set
        internal bool IsSetSizes()
        {
            return this._sizes != null && this._sizes.Count > 0; 
        }

    }
}