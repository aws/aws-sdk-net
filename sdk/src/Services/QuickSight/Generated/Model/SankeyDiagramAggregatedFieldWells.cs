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
    /// The field well configuration of a sankey diagram.
    /// </summary>
    public partial class SankeyDiagramAggregatedFieldWells
    {
        private List<DimensionField> _destination = new List<DimensionField>();
        private List<DimensionField> _source = new List<DimensionField>();
        private List<MeasureField> _weight = new List<MeasureField>();

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination field wells of a sankey diagram.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null && this._destination.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source field wells of a sankey diagram.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null && this._source.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The weight field wells of a sankey diagram.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight != null && this._weight.Count > 0; 
        }

    }
}