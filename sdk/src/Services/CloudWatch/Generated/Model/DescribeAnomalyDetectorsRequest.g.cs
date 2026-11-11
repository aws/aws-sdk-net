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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAnomalyDetectors operation. Lists the
    /// anomaly detection models that you have created in your account. For single metric
    /// anomaly detectors, you can list all of the models in your account or filter the results
    /// to only the models that are related to a certain namespace, metric name, or metric
    /// dimension. For metric math anomaly detectors, you can list them by adding <c>METRIC_MATH</c>
    /// to the <c>AnomalyDetectorTypes</c> array. This will return all metric math anomaly
    /// detectors in your account.
    /// </summary>
    public partial class DescribeAnomalyDetectorsRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property AnomalyDetectorIds. 
        /// <para>
        /// Specifies the unique identifiers of the anomaly detectors to describe. You can specify
        /// up to 50 identifiers. If you specify this parameter, you cannot also specify the <c>Namespace</c>,
        /// <c>MetricName</c>, <c>Dimensions</c>, or <c>AnomalyDetectorTypes</c> metric filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> AnomalyDetectorIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AnomalyDetectorIds property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorIds() => this.AnomalyDetectorIds != null && (this.AnomalyDetectorIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AnomalyDetectorTypes. 
        /// <para>
        /// The anomaly detector types to request when using <c>DescribeAnomalyDetectorsInput</c>.
        /// If empty, defaults to <c>SINGLE_METRIC</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> AnomalyDetectorTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AnomalyDetectorTypes property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorTypes() => this.AnomalyDetectorTypes != null && (this.AnomalyDetectorTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified metric dimensions. If there are multiple metrics that have these dimensions
        /// and have anomaly detection models associated, they're all returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<Dimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one operation. The maximum value that you
        /// can specify is 100.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another call with the returned <c>NextToken</c>
        /// value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified metric name. If there are multiple metrics with this name in different namespaces
        /// that have anomaly detection models, they're all returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by the previous operation to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
