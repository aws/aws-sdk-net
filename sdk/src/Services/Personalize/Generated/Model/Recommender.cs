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
    /// Describes a recommendation generator for a Domain dataset group. You create a recommender
    /// in a Domain dataset group for a specific domain use case (domain recipe), and specify
    /// the recommender in a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// request.
    /// </summary>
    public partial class Recommender
    {
        private DateTime? _creationDateTime;
        private string _datasetGroupArn;
        private string _failureReason;
        private DateTime? _lastUpdatedDateTime;
        private RecommenderUpdateSummary _latestRecommenderUpdate;
        private Dictionary<string, double> _modelMetrics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private string _name;
        private string _recipeArn;
        private string _recommenderArn;
        private RecommenderConfig _recommenderConfig;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the recommender was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Domain dataset group that contains the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a recommender fails, the reason behind the failure.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the recommender was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestRecommenderUpdate. 
        /// <para>
        /// Provides a summary of the latest updates to the recommender. 
        /// </para>
        /// </summary>
        public RecommenderUpdateSummary LatestRecommenderUpdate
        {
            get { return this._latestRecommenderUpdate; }
            set { this._latestRecommenderUpdate = value; }
        }

        // Check to see if LatestRecommenderUpdate property is set
        internal bool IsSetLatestRecommenderUpdate()
        {
            return this._latestRecommenderUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Provides evaluation metrics that help you determine the performance of a recommender.
        /// For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/evaluating-recommenders.html">
        /// Evaluating a recommender</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, double> ModelMetrics
        {
            get { return this._modelMetrics; }
            set { this._modelMetrics = value; }
        }

        // Check to see if ModelMetrics property is set
        internal bool IsSetModelMetrics()
        {
            return this._modelMetrics != null && (this._modelMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recipe (Domain dataset group use case) that
        /// the recommender was created for. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RecipeArn
        {
            get { return this._recipeArn; }
            set { this._recipeArn = value; }
        }

        // Check to see if RecipeArn property is set
        internal bool IsSetRecipeArn()
        {
            return this._recipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the recommender.
        /// </para>
        ///  
        /// <para>
        /// A recommender can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOP PENDING &gt; STOP IN_PROGRESS &gt; INACTIVE &gt; START PENDING &gt; START IN_PROGRESS
        /// &gt; ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}