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

namespace Amazon.PI.Model
{
    /// <summary>
    /// This is the response object from the DescribeDimensionKeys operation.
    /// </summary>
    public partial class DescribeDimensionKeysResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AlignedEndTime. 
        /// <para>
        /// The end time for the returned dimension keys, after alignment to a granular boundary
        /// (as specified by <c>PeriodInSeconds</c>). <c>AlignedEndTime</c> will be greater than
        /// or equal to the value of the user-specified <c>Endtime</c>. 
        /// </para>
        /// </summary>
        public DateTime? AlignedEndTime { get; set; }

        /// <summary>
        /// Checks to see if the AlignedEndTime property is set.
        /// </summary>
        internal bool IsSetAlignedEndTime() => this.AlignedEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property AlignedStartTime. 
        /// <para>
        /// The start time for the returned dimension keys, after alignment to a granular boundary
        /// (as specified by <c>PeriodInSeconds</c>). <c>AlignedStartTime</c> will be less than
        /// or equal to the value of the user-specified <c>StartTime</c>. 
        /// </para>
        /// </summary>
        public DateTime? AlignedStartTime { get; set; }

        /// <summary>
        /// Checks to see if the AlignedStartTime property is set.
        /// </summary>
        internal bool IsSetAlignedStartTime() => this.AlignedStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The dimension keys that were requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DimensionKeyDescription> Keys { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionKeyDescription>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that indicates the response didn’t return all available records
        /// because <c>MaxRecords</c> was specified in the previous request. To get the remaining
        /// records, specify <c>NextToken</c> in a separate request with this value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// If <c>PartitionBy</c> was present in the request, <c>PartitionKeys</c> contains the
        /// breakdown of dimension keys by the specified partitions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResponsePartitionKey> PartitionKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<ResponsePartitionKey>() : null;

        /// <summary>
        /// Checks to see if the PartitionKeys property is set.
        /// </summary>
        internal bool IsSetPartitionKeys() => this.PartitionKeys != null && (this.PartitionKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
