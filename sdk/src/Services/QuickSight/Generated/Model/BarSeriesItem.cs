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
    /// The series item configuration of a <c>BarChartVisual</c>.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class BarSeriesItem
    {
        private DataFieldBarSeriesItem _dataFieldBarSeriesItem;
        private FieldBarSeriesItem _fieldBarSeriesItem;

        /// <summary>
        /// Gets and sets the property DataFieldBarSeriesItem. 
        /// <para>
        /// The data field series item configuration of a <c>BarChartVisual</c>.
        /// </para>
        /// </summary>
        public DataFieldBarSeriesItem DataFieldBarSeriesItem
        {
            get { return this._dataFieldBarSeriesItem; }
            set { this._dataFieldBarSeriesItem = value; }
        }

        // Check to see if DataFieldBarSeriesItem property is set
        internal bool IsSetDataFieldBarSeriesItem()
        {
            return this._dataFieldBarSeriesItem != null;
        }

        /// <summary>
        /// Gets and sets the property FieldBarSeriesItem. 
        /// <para>
        /// The field series item configuration of a <c>BarChartVisual</c>.
        /// </para>
        /// </summary>
        public FieldBarSeriesItem FieldBarSeriesItem
        {
            get { return this._fieldBarSeriesItem; }
            set { this._fieldBarSeriesItem = value; }
        }

        // Check to see if FieldBarSeriesItem property is set
        internal bool IsSetFieldBarSeriesItem()
        {
            return this._fieldBarSeriesItem != null;
        }

    }
}