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
    /// Information about rows for a data set SPICE ingestion.
    /// </summary>
    public partial class RowInfo
    {
        /// <summary>
        /// Gets and sets the property RowsDropped. 
        /// <para>
        /// The number of rows that were not ingested.
        /// </para>
        /// </summary>
        public long? RowsDropped { get; set; }

        /// <summary>
        /// Checks to see if the RowsDropped property is set.
        /// </summary>
        internal bool IsSetRowsDropped() => this.RowsDropped.HasValue;

        /// <summary>
        /// Gets and sets the property RowsIngested. 
        /// <para>
        /// The number of rows that were ingested.
        /// </para>
        /// </summary>
        public long? RowsIngested { get; set; }

        /// <summary>
        /// Checks to see if the RowsIngested property is set.
        /// </summary>
        internal bool IsSetRowsIngested() => this.RowsIngested.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRowsInDataset. 
        /// <para>
        /// The total number of rows in the dataset.
        /// </para>
        /// </summary>
        public long? TotalRowsInDataset { get; set; }

        /// <summary>
        /// Checks to see if the TotalRowsInDataset property is set.
        /// </summary>
        internal bool IsSetTotalRowsInDataset() => this.TotalRowsInDataset.HasValue;
    }
}
