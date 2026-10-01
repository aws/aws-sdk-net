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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the GetAgentRecommendation operation. Retrieves detailed
    /// information about a specific optimization recommendation, including its impact analysis,
    /// content, and implementation guidance.
    /// </summary>
    public partial class GetAgentRecommendationRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RecommendationArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationArn property is set.
        /// </summary>
        internal bool IsSetRecommendationArn() => this.RecommendationArn != null;

        /// <summary>
        /// Gets and sets the property RemediationType. 
        /// <para>
        /// Optional filter on remediation type.
        /// </para>
        /// </summary>
        public RemediationType RemediationType { get; set; }

        /// <summary>
        /// Checks to see if the RemediationType property is set.
        /// </summary>
        internal bool IsSetRemediationType() => this.RemediationType != null;
    }
}
