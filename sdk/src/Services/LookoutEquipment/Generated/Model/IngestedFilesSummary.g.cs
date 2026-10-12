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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Gives statistics about how many files have been ingested, and which files have not
    /// been ingested, for a particular ingestion job.
    /// </summary>
    public partial class IngestedFilesSummary
    {
        /// <summary>
        /// Gets and sets the property DiscardedFiles. 
        /// <para>
        /// Indicates the number of files that were discarded. A file could be discarded because
        /// its format is invalid (for example, a jpg or pdf) or not readable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<S3Object> DiscardedFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Object>() : null;

        /// <summary>
        /// Checks to see if the DiscardedFiles property is set.
        /// </summary>
        internal bool IsSetDiscardedFiles() => this.DiscardedFiles != null && (this.DiscardedFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IngestedNumberOfFiles. 
        /// <para>
        /// Indicates the number of files that were successfully ingested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? IngestedNumberOfFiles { get; set; }

        /// <summary>
        /// Checks to see if the IngestedNumberOfFiles property is set.
        /// </summary>
        internal bool IsSetIngestedNumberOfFiles() => this.IngestedNumberOfFiles.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfFiles. 
        /// <para>
        /// Indicates the total number of files that were submitted for ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalNumberOfFiles { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfFiles property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfFiles() => this.TotalNumberOfFiles.HasValue;
    }
}
