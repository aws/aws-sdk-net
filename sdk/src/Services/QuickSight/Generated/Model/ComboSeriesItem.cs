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
    /// The series item configuration of a <c>ComboChartVisual</c>.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class ComboSeriesItem
    {
        private DataFieldComboSeriesItem _dataFieldComboSeriesItem;
        private FieldComboSeriesItem _fieldComboSeriesItem;

        /// <summary>
        /// Gets and sets the property DataFieldComboSeriesItem. 
        /// <para>
        /// The data field series item configuration of a <c>ComboChartVisual</c>.
        /// </para>
        /// </summary>
        public DataFieldComboSeriesItem DataFieldComboSeriesItem
        {
            get { return this._dataFieldComboSeriesItem; }
            set { this._dataFieldComboSeriesItem = value; }
        }

        // Check to see if DataFieldComboSeriesItem property is set
        internal bool IsSetDataFieldComboSeriesItem()
        {
            return this._dataFieldComboSeriesItem != null;
        }

        /// <summary>
        /// Gets and sets the property FieldComboSeriesItem. 
        /// <para>
        /// The field series item configuration of a <c>ComboChartVisual</c>.
        /// </para>
        /// </summary>
        public FieldComboSeriesItem FieldComboSeriesItem
        {
            get { return this._fieldComboSeriesItem; }
            set { this._fieldComboSeriesItem = value; }
        }

        // Check to see if FieldComboSeriesItem property is set
        internal bool IsSetFieldComboSeriesItem()
        {
            return this._fieldComboSeriesItem != null;
        }

    }
}