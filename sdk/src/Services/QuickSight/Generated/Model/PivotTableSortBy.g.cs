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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The sort by field for the field sort options.
    /// </summary>
    public partial class PivotTableSortBy
    {
        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column sort (field id, direction) for the pivot table sort by options.
        /// </para>
        /// </summary>
        public ColumnSort Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property DataPath. 
        /// <para>
        /// The data path sort (data path value, direction) for the pivot table sort by options.
        /// </para>
        /// </summary>
        public DataPathSort DataPath { get; set; }

        /// <summary>
        /// Checks to see if the DataPath property is set.
        /// </summary>
        internal bool IsSetDataPath() => this.DataPath != null;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field sort (field id, direction) for the pivot table sort by options.
        /// </para>
        /// </summary>
        public FieldSort Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;
    }
}
