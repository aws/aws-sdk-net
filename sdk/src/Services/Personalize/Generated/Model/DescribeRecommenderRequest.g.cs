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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRecommender operation. Describes the given
    /// recommender, including its status. <para> A recommender can be in one of the following
    /// states: </para> <ul> <li> <para> CREATE PENDING > CREATE IN_PROGRESS > ACTIVE -or-
    /// CREATE FAILED </para> </li> <li> <para> STOP PENDING > STOP IN_PROGRESS > INACTIVE
    /// > START PENDING > START IN_PROGRESS > ACTIVE </para> </li> <li> <para> DELETE PENDING
    /// > DELETE IN_PROGRESS </para> </li> </ul> <para> When the <c>status</c> is <c>CREATE
    /// FAILED</c>, the response includes the <c>failureReason</c> key, which describes why.
    /// </para> <para> The <c>modelMetrics</c> key is null when the recommender is being created
    /// or deleted. </para> <para> For more information on recommenders, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateRecommender.html">CreateRecommender</a>.
    /// </para>
    /// </summary>
    public partial class DescribeRecommenderRequest : AmazonPersonalizeRequest
    {
        /// <summary>
        /// Gets and sets the property RecommenderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommender to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string RecommenderArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderArn property is set.
        /// </summary>
        internal bool IsSetRecommenderArn() => this.RecommenderArn != null;
    }
}
