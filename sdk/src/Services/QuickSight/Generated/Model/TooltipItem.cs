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
    /// The tooltip.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class TooltipItem
    {
        private ColumnTooltipItem _columnTooltipItem;
        private FieldTooltipItem _fieldTooltipItem;

        /// <summary>
        /// Gets and sets the property ColumnTooltipItem. 
        /// <para>
        /// The tooltip item for the columns that are not part of a field well.
        /// </para>
        /// </summary>
        public ColumnTooltipItem ColumnTooltipItem
        {
            get { return this._columnTooltipItem; }
            set { this._columnTooltipItem = value; }
        }

        // Check to see if ColumnTooltipItem property is set
        internal bool IsSetColumnTooltipItem()
        {
            return this._columnTooltipItem != null;
        }

        /// <summary>
        /// Gets and sets the property FieldTooltipItem. 
        /// <para>
        /// The tooltip item for the fields.
        /// </para>
        /// </summary>
        public FieldTooltipItem FieldTooltipItem
        {
            get { return this._fieldTooltipItem; }
            set { this._fieldTooltipItem = value; }
        }

        // Check to see if FieldTooltipItem property is set
        internal bool IsSetFieldTooltipItem()
        {
            return this._fieldTooltipItem != null;
        }

    }
}