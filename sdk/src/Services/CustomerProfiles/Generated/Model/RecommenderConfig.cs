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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private EventsConfig _eventsConfig;
        private Dictionary<string, List<string>> _includedColumns = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private InferenceConfig _inferenceConfig;
        private int? _trainingFrequency;

        /// <summary>
        /// Gets and sets the property EventsConfig. 
        /// <para>
        /// Configuration settings for how the recommender processes and uses events.
        /// </para>
        /// </summary>
        public EventsConfig EventsConfig
        {
            get { return this._eventsConfig; }
            set { this._eventsConfig = value; }
        }

        // Check to see if EventsConfig property is set
        internal bool IsSetEventsConfig()
        {
            return this._eventsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedColumns. 
        /// <para>
        /// A map of dataset type to a list of column names to train on. The column names must
        /// be a subset of the columns defined in the recommender schema. If not specified, all
        /// columns in the schema are used for training. The following columns are always included
        /// and do not need to be specified: <c>Item.Id</c>, <c>ItemList[].Id</c>, <c>EventTimestamp</c>,
        /// <c>EventType</c>, and <c>EventValue</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public Dictionary<string, List<string>> IncludedColumns
        {
            get { return this._includedColumns; }
            set { this._includedColumns = value; }
        }

        // Check to see if IncludedColumns property is set
        internal bool IsSetIncludedColumns()
        {
            return this._includedColumns != null && (this._includedColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// Configuration settings for how the recommender handles inference requests.
        /// </para>
        /// </summary>
        public InferenceConfig InferenceConfig
        {
            get { return this._inferenceConfig; }
            set { this._inferenceConfig = value; }
        }

        // Check to see if InferenceConfig property is set
        internal bool IsSetInferenceConfig()
        {
            return this._inferenceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingFrequency. 
        /// <para>
        /// How often the recommender should retrain its model with new data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public int? TrainingFrequency
        {
            get { return this._trainingFrequency; }
            set { this._trainingFrequency = value; }
        }

        // Check to see if TrainingFrequency property is set
        internal bool IsSetTrainingFrequency()
        {
            return this._trainingFrequency.HasValue; 
        }

    }
}