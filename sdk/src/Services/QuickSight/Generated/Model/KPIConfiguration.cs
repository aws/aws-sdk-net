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
    /// The configuration of a KPI visual.
    /// </summary>
    public partial class KPIConfiguration
    {
        private KPIFieldWells _fieldWells;
        private KPIOptions _kpiOptions;
        private KPISortConfiguration _sortConfiguration;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field well configuration of a KPI visual.
        /// </para>
        /// </summary>
        public KPIFieldWells FieldWells
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
        /// Gets and sets the property KPIOptions. 
        /// <para>
        /// The options that determine the presentation of a KPI visual.
        /// </para>
        /// </summary>
        public KPIOptions KPIOptions
        {
            get { return this._kpiOptions; }
            set { this._kpiOptions = value; }
        }

        // Check to see if KPIOptions property is set
        internal bool IsSetKPIOptions()
        {
            return this._kpiOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a KPI visual.
        /// </para>
        /// </summary>
        public KPISortConfiguration SortConfiguration
        {
            get { return this._sortConfiguration; }
            set { this._sortConfiguration = value; }
        }

        // Check to see if SortConfiguration property is set
        internal bool IsSetSortConfiguration()
        {
            return this._sortConfiguration != null;
        }

    }
}