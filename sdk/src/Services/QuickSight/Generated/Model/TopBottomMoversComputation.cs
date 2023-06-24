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
    /// The top movers and bottom movers computation setup.
    /// </summary>
    public partial class TopBottomMoversComputation
    {
        private DimensionField _category;
        private string _computationId;
        private int? _moverSize;
        private string _name;
        private TopBottomSortOrder _sortOrder;
        private DimensionField _time;
        private TopBottomComputationType _type;
        private MeasureField _value;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category field that is used in a computation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionField Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationId. 
        /// <para>
        /// The ID for a computation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ComputationId
        {
            get { return this._computationId; }
            set { this._computationId = value; }
        }

        // Check to see if ComputationId property is set
        internal bool IsSetComputationId()
        {
            return this._computationId != null;
        }

        /// <summary>
        /// Gets and sets the property MoverSize. 
        /// <para>
        /// The mover size setup of the top and bottom movers computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int MoverSize
        {
            get { return this._moverSize.GetValueOrDefault(); }
            set { this._moverSize = value; }
        }

        // Check to see if MoverSize property is set
        internal bool IsSetMoverSize()
        {
            return this._moverSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a computation.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order setup of the top and bottom movers computation.
        /// </para>
        /// </summary>
        public TopBottomSortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time field that is used in a computation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionField Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The computation type. Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TOP: Top movers computation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BOTTOM: Bottom movers computation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TopBottomComputationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value field that is used in a computation.
        /// </para>
        /// </summary>
        public MeasureField Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}