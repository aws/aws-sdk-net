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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
    /// Container for the parameters to the UpdateRecommender operation.
    /// Updates the recommender to modify the recommender configuration. If you update the
    /// recommender to modify the columns used in training, Amazon Personalize automatically
    /// starts a full retraining of the models backing your recommender. While the update
    /// completes, you can still get recommendations from the recommender. The recommender
    /// uses the previous configuration until the update completes. To track the status of
    /// this update, use the <c>latestRecommenderUpdate</c> returned in the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeRecommender.html">DescribeRecommender</a>
    /// operation.
    /// </summary>
    public partial class UpdateRecommenderRequest : AmazonPersonalizeRequest
    {
        private string _recommenderArn;
        private RecommenderConfig _recommenderConfig;

        /// <summary>
        /// Gets and sets the property RecommenderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommender to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string RecommenderArn
        {
            get { return this._recommenderArn; }
            set { this._recommenderArn = value; }
        }

        // Check to see if RecommenderArn property is set
        internal bool IsSetRecommenderArn()
        {
            return this._recommenderArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderConfig. 
        /// <para>
        /// The configuration details of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommenderConfig RecommenderConfig
        {
            get { return this._recommenderConfig; }
            set { this._recommenderConfig = value; }
        }

        // Check to see if RecommenderConfig property is set
        internal bool IsSetRecommenderConfig()
        {
            return this._recommenderConfig != null;
        }

    }
}