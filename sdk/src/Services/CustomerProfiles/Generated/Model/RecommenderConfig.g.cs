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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Configuration settings that define the behavior and parameters of a recommender.
    /// </summary>
    public partial class RecommenderConfig
    {
        /// <summary>
        /// Gets and sets the property DiversityConfig. 
        /// <para>
        /// Configuration for diversity-aware recommendations. When set, the recommender applies
        /// diversity constraints defined per item column to reduce over-concentration of similar
        /// items in the results.
        /// </para>
        /// </summary>
        public DiversityConfig DiversityConfig { get; set; }

        /// <summary>
        /// Checks to see if the DiversityConfig property is set.
        /// </summary>
        internal bool IsSetDiversityConfig() => this.DiversityConfig != null;

        /// <summary>
        /// Gets and sets the property EventsConfig. 
        /// <para>
        /// Configuration settings for how the recommender processes and uses events.
        /// </para>
        /// </summary>
        public EventsConfig EventsConfig { get; set; }

        /// <summary>
        /// Checks to see if the EventsConfig property is set.
        /// </summary>
        internal bool IsSetEventsConfig() => this.EventsConfig != null;

        /// <summary>
        /// Gets and sets the property ExcludedColumns. 
        /// <para>
        /// A map of dataset type to a list of column names to exclude from training. The <c>_webAnalytics</c>
        /// and <c>_catalogItem</c> keys are supported. The column names must be valid columns
        /// defined in the recommender schema. All columns in the schema except the listed columns
        /// will be used for training. The following columns are mandatory and cannot be excluded:
        /// <c>Item.Id</c>, <c>EventTimestamp</c>, and <c>EventType</c> for <c>_webAnalytics</c>;
        /// <c>Id</c> for <c>_catalogItem</c>. Mutually exclusive with IncludedColumns — both
        /// cannot be specified in the same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public Dictionary<string, List<string>> ExcludedColumns { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the ExcludedColumns property is set.
        /// </summary>
        internal bool IsSetExcludedColumns() => this.ExcludedColumns != null && (this.ExcludedColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludedColumns. 
        /// <para>
        /// A map of dataset type to a list of column names to train on. The <c>_webAnalytics</c>
        /// and <c>_catalogItem</c> keys are supported. The column names must be a subset of the
        /// columns defined in the recommender schema. If not specified, all columns in the schema
        /// are used for training. The following columns are always included in training and do
        /// not need to be specified: <c>Item.Id</c>, <c>EventTimestamp</c>, and <c>EventType</c>
        /// for <c>_webAnalytics</c>; <c>Id</c> for <c>_catalogItem</c>. Mutually exclusive with
        /// ExcludedColumns — both cannot be specified in the same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public Dictionary<string, List<string>> IncludedColumns { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the IncludedColumns property is set.
        /// </summary>
        internal bool IsSetIncludedColumns() => this.IncludedColumns != null && (this.IncludedColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// Configuration settings for how the recommender handles inference requests.
        /// </para>
        /// </summary>
        public InferenceConfig InferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfig property is set.
        /// </summary>
        internal bool IsSetInferenceConfig() => this.InferenceConfig != null;

        /// <summary>
        /// Gets and sets the property TrainingFrequency. 
        /// <para>
        /// How often the recommender should retrain its model with new data. If set to 0, automatic
        /// retraining will not be enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public int? TrainingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the TrainingFrequency property is set.
        /// </summary>
        internal bool IsSetTrainingFrequency() => this.TrainingFrequency.HasValue;
    }
}
