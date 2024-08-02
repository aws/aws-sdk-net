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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates the rejected grouping recommendation.
    /// </summary>
    public partial class RejectGroupingRecommendationEntry
    {
        private string _groupingRecommendationId;
        private GroupingRecommendationRejectionReason _rejectionReason;

        /// <summary>
        /// Gets and sets the property GroupingRecommendationId. 
        /// <para>
        /// Indicates the identifier of the grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GroupingRecommendationId
        {
            get { return this._groupingRecommendationId; }
            set { this._groupingRecommendationId = value; }
        }

        // Check to see if GroupingRecommendationId property is set
        internal bool IsSetGroupingRecommendationId()
        {
            return this._groupingRecommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// Indicates the reason you had selected while rejecting a grouping recommendation.
        /// </para>
        /// </summary>
        public GroupingRecommendationRejectionReason RejectionReason
        {
            get { return this._rejectionReason; }
            set { this._rejectionReason = value; }
        }

        // Check to see if RejectionReason property is set
        internal bool IsSetRejectionReason()
        {
            return this._rejectionReason != null;
        }

    }
}