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
    /// Contains metrics and performance indicators from the training of a recommender model.
    /// </summary>
    public partial class TrainingMetrics
    {
        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A collection of performance metrics and statistics from the training process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommenderVersionName. 
        /// <para>
        /// The name of the recommender version that produced these training metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RecommenderVersionName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderVersionName property is set.
        /// </summary>
        internal bool IsSetRecommenderVersionName() => this.RecommenderVersionName != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The timestamp when these training metrics were recorded.
        /// </para>
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;
    }
}
