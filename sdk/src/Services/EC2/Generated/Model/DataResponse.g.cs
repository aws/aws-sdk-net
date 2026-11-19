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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The response to a <c>DataQuery</c>.
    /// </summary>
    public partial class DataResponse
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Region or Availability Zone that's the destination for the data query. For example,
        /// <c>eu-west-1</c>.
        /// </para>
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID passed in the <c>DataQuery</c>.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric used for the network performance request.
        /// </para>
        /// </summary>
        public MetricType Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property MetricPoints. 
        /// <para>
        /// A list of <c>MetricPoint</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricPoint> MetricPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricPoint>() : null;

        /// <summary>
        /// Checks to see if the MetricPoints property is set.
        /// </summary>
        internal bool IsSetMetricPoints() => this.MetricPoints != null && (this.MetricPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period used for the network performance request.
        /// </para>
        /// </summary>
        public PeriodType Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Region or Availability Zone that's the source for the data query. For example,
        /// <c>us-east-1</c>.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic used for the network performance request.
        /// </para>
        /// </summary>
        public StatisticType Statistic { get; set; }

        /// <summary>
        /// Checks to see if the Statistic property is set.
        /// </summary>
        internal bool IsSetStatistic() => this.Statistic != null;
    }
}
