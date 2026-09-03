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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the array properties of a job.
    /// </summary>
    public partial class ArrayPropertiesDetail
    {
        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The job index within the array that's associated with this job. This parameter is
        /// returned for array job children.
        /// </para>
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Checks to see if the Index property is set.
        /// </summary>
        internal bool IsSetIndex() => this.Index.HasValue;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the array job. This parameter is returned for parent array jobs.
        /// </para>
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// A summary of the number of array job children in each available job status. This parameter
        /// is returned for parent array jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> StatusSummary { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the StatusSummary property is set.
        /// </summary>
        internal bool IsSetStatusSummary() => this.StatusSummary != null && (this.StatusSummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatusSummaryLastUpdatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the <c>statusSummary</c> was last updated.
        /// </para>
        /// </summary>
        public long? StatusSummaryLastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the StatusSummaryLastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetStatusSummaryLastUpdatedAt() => this.StatusSummaryLastUpdatedAt.HasValue;
    }
}
