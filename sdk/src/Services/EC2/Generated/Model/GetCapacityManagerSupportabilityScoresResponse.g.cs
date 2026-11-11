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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetCapacityManagerSupportabilityScores operation.
    /// </summary>
    public partial class GetCapacityManagerSupportabilityScoresResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AggregateScore. 
        /// <para>
        ///  The score for all instance type and Availability Zone combinations in the request
        /// together. A <c>high</c> aggregate score with lower individual scores means that no
        /// single combination can support the full request, but the combinations together can.
        /// 
        /// </para>
        /// </summary>
        public SupportabilityScore AggregateScore { get; set; }

        /// <summary>
        /// Checks to see if the AggregateScore property is set.
        /// </summary>
        internal bool IsSetAggregateScore() => this.AggregateScore != null;

        /// <summary>
        /// Gets and sets the property CapacityManagerSupportabilityScores. 
        /// <para>
        ///  The score for each instance type and Availability Zone combination in the request.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityManagerSupportabilityScore> CapacityManagerSupportabilityScores { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityManagerSupportabilityScore>() : null;

        /// <summary>
        /// Checks to see if the CapacityManagerSupportabilityScores property is set.
        /// </summary>
        internal bool IsSetCapacityManagerSupportabilityScores() => this.CapacityManagerSupportabilityScores != null && (this.CapacityManagerSupportabilityScores.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
