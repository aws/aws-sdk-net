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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The metadata transfer job's progress.
    /// </summary>
    public partial class MetadataTransferJobProgress
    {
        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The failed count.
        /// </para>
        /// </summary>
        public int? FailedCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedCount property is set.
        /// </summary>
        internal bool IsSetFailedCount() => this.FailedCount.HasValue;

        /// <summary>
        /// Gets and sets the property SkippedCount. 
        /// <para>
        /// The skipped count.
        /// </para>
        /// </summary>
        public int? SkippedCount { get; set; }

        /// <summary>
        /// Checks to see if the SkippedCount property is set.
        /// </summary>
        internal bool IsSetSkippedCount() => this.SkippedCount.HasValue;

        /// <summary>
        /// Gets and sets the property SucceededCount. 
        /// <para>
        /// The succeeded count.
        /// </para>
        /// </summary>
        public int? SucceededCount { get; set; }

        /// <summary>
        /// Checks to see if the SucceededCount property is set.
        /// </summary>
        internal bool IsSetSucceededCount() => this.SucceededCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total count. [of what]
        /// </para>
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
