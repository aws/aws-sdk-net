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
    /// The dimension type field with date type columns.
    /// </summary>
    public partial class DateDimensionField
    {
        private ColumnIdentifier _column;
        private TimeGranularity _dateGranularity;
        private string _fieldId;
        private DateTimeFormatConfiguration _formatConfiguration;
        private string _hierarchyId;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that is used in the <code>DateDimensionField</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property DateGranularity. 
        /// <para>
        /// The date granularity of the <code>DateDimensionField</code>. Choose one of the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>YEAR</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QUARTER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MONTH</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WEEK</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HOUR</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MINUTE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SECOND</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MILLISECOND</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TimeGranularity DateGranularity
        {
            get { return this._dateGranularity; }
            set { this._dateGranularity = value; }
        }

        // Check to see if DateGranularity property is set
        internal bool IsSetDateGranularity()
        {
            return this._dateGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The custom field ID.
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
        /// Gets and sets the property FormatConfiguration. 
        /// <para>
        /// The format configuration of the field.
        /// </para>
        /// </summary>
        public DateTimeFormatConfiguration FormatConfiguration
        {
            get { return this._formatConfiguration; }
            set { this._formatConfiguration = value; }
        }

        // Check to see if FormatConfiguration property is set
        internal bool IsSetFormatConfiguration()
        {
            return this._formatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchyId. 
        /// <para>
        /// The custom hierarchy ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string HierarchyId
        {
            get { return this._hierarchyId; }
            set { this._hierarchyId = value; }
        }

        // Check to see if HierarchyId property is set
        internal bool IsSetHierarchyId()
        {
            return this._hierarchyId != null;
        }

    }
}