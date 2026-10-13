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
    /// Container for the parameters to the CreateMetricAttribution operation. Creates a metric
    /// attribution. A metric attribution creates reports on the data that you import into
    /// Amazon Personalize. Depending on how you imported the data, you can view reports in
    /// Amazon CloudWatch or Amazon S3. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
    /// impact of recommendations</a>.
    /// </summary>
    public partial class CreateMetricAttributionRequest : AmazonPersonalizeRequest
    {
        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination dataset group for the metric attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string DatasetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetGroupArn property is set.
        /// </summary>
        internal bool IsSetDatasetGroupArn() => this.DatasetGroupArn != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A list of metric attributes for the metric attribution. Each metric attribute specifies
        /// an event type to track and a function. Available functions are <c>SUM()</c> or <c>SAMPLECOUNT()</c>.
        /// For SUM() functions, provide the dataset type (either Interactions or Items) and column
        /// to sum as a parameter. For example SUM(Items.PRICE).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<MetricAttribute> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricAttribute>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricsOutputConfig. 
        /// <para>
        /// The output configuration details for the metric attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricAttributionOutput MetricsOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetricsOutputConfig property is set.
        /// </summary>
        internal bool IsSetMetricsOutputConfig() => this.MetricsOutputConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the metric attribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
