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
    /// The lookback window setup of an incremental refresh configuration.
    /// </summary>
    public partial class LookbackWindow
    {
        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the lookback window column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The lookback window column size.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property SizeUnit. 
        /// <para>
        /// The size unit that is used for the lookback window column. Valid values for this structure
        /// are <c>HOUR</c>, <c>DAY</c>, and <c>WEEK</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LookbackWindowSizeUnit SizeUnit { get; set; }

        /// <summary>
        /// Checks to see if the SizeUnit property is set.
        /// </summary>
        internal bool IsSetSizeUnit() => this.SizeUnit != null;
    }
}
