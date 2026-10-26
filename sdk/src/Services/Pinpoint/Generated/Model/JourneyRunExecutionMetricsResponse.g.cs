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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides the results of a query that retrieved the data for a standard execution metric
    /// that applies to a journey run, and provides information about that query.
    /// </summary>
    public partial class JourneyRunExecutionMetricsResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the metric applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property JourneyId. 
        /// <para>
        /// The unique identifier for the journey that the metric applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JourneyId { get; set; }

        /// <summary>
        /// Checks to see if the JourneyId property is set.
        /// </summary>
        internal bool IsSetJourneyId() => this.JourneyId != null;

        /// <summary>
        /// Gets and sets the property LastEvaluatedTime. 
        /// <para>
        /// The date and time, in ISO 8601 format, when Amazon Pinpoint last evaluated the journey
        /// run and updated the data for the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastEvaluatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedTime property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedTime() => this.LastEvaluatedTime != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A JSON object that contains the results of the query. For information about the structure
        /// and contents of the results, see the <a href="https://docs.aws.amazon.com//pinpoint/latest/developerguide/analytics-standard-metrics.html">Standard
        /// Amazon Pinpoint analytics metrics</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier for the journey run that the metric applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;
    }
}
