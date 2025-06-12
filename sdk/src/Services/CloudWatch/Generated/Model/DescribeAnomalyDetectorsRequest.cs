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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
    /// Container for the parameters to the DescribeAnomalyDetectors operation.
    /// Lists the anomaly detection models that you have created in your account. For single
    /// metric anomaly detectors, you can list all of the models in your account or filter
    /// the results to only the models that are related to a certain namespace, metric name,
    /// or metric dimension. For metric math anomaly detectors, you can list them by adding
    /// <c>METRIC_MATH</c> to the <c>AnomalyDetectorTypes</c> array. This will return all
    /// metric math anomaly detectors in your account.
    /// </summary>
    public partial class DescribeAnomalyDetectorsRequest : AmazonCloudWatchRequest
    {
        private List<string> _anomalyDetectorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private int? _maxResults;
        private string _metricName;
        private string _awsNamespace;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorTypes. 
        /// <para>
        /// The anomaly detector types to request when using <c>DescribeAnomalyDetectorsInput</c>.
        /// If empty, defaults to <c>SINGLE_METRIC</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> AnomalyDetectorTypes
        {
            get { return this._anomalyDetectorTypes; }
            set { this._anomalyDetectorTypes = value; }
        }

        // Check to see if AnomalyDetectorTypes property is set
        internal bool IsSetAnomalyDetectorTypes()
        {
            return this._anomalyDetectorTypes != null && (this._anomalyDetectorTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified metric dimensions. If there are multiple metrics that have these dimensions
        /// and have anomaly detection models associated, they're all returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified metric name. If there are multiple metrics with this name in different namespaces
        /// that have anomaly detection models, they're all returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// Limits the results to only the anomaly detection models that are associated with the
        /// specified namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by the previous operation to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}