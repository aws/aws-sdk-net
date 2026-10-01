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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The aggregation settings that you can use to customize the output format of your
    /// flow data.
    /// </summary>
    public partial class AggregationConfig
    {
        /// <summary>
        /// Gets and sets the property AggregationType. 
        /// <para>
        ///  Specifies whether Amazon AppFlow aggregates the flow records into a single file,
        /// or leave them unaggregated. 
        /// </para>
        /// </summary>
        public AggregationType AggregationType { get; set; }

        /// <summary>
        /// Checks to see if the AggregationType property is set.
        /// </summary>
        internal bool IsSetAggregationType() => this.AggregationType != null;

        /// <summary>
        /// Gets and sets the property TargetFileSize. 
        /// <para>
        /// The desired file size, in MB, for each output file that Amazon AppFlow writes to the
        /// flow destination. For each file, Amazon AppFlow attempts to achieve the size that
        /// you specify. The actual file sizes might differ from this target based on the number
        /// and size of the records that each file contains.
        /// </para>
        /// </summary>
        public long? TargetFileSize { get; set; }

        /// <summary>
        /// Checks to see if the TargetFileSize property is set.
        /// </summary>
        internal bool IsSetTargetFileSize() => this.TargetFileSize.HasValue;
    }
}
