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
    /// A tag for a column in a <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_TagColumnOperation.html">TagColumnOperation</a>
    /// </c> structure. This is a variant type structure. For this structure to be valid,
    /// only one of the attributes can be non-null.
    /// </summary>
    public partial class ColumnTag
    {
        /// <summary>
        /// Gets and sets the property ColumnDescription. 
        /// <para>
        /// A description for a column.
        /// </para>
        /// </summary>
        public ColumnDescription ColumnDescription { get; set; }

        /// <summary>
        /// Checks to see if the ColumnDescription property is set.
        /// </summary>
        internal bool IsSetColumnDescription() => this.ColumnDescription != null;

        /// <summary>
        /// Gets and sets the property ColumnGeographicRole. 
        /// <para>
        /// A geospatial role for a column.
        /// </para>
        /// </summary>
        public GeoSpatialDataRole ColumnGeographicRole { get; set; }

        /// <summary>
        /// Checks to see if the ColumnGeographicRole property is set.
        /// </summary>
        internal bool IsSetColumnGeographicRole() => this.ColumnGeographicRole != null;
    }
}
