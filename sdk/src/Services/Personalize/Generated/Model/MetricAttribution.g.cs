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
    /// Contains information on a metric attribution. A metric attribution creates reports
    /// on the data that you import into Amazon Personalize. Depending on how you import the
    /// data, you can view reports in Amazon CloudWatch or Amazon S3. For more information,
    /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
    /// impact of recommendations</a>.
    /// </summary>
    public partial class MetricAttribution
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The metric attribution's creation date time.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The metric attribution's dataset group Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetGroupArn property is set.
        /// </summary>
        internal bool IsSetDatasetGroupArn() => this.DatasetGroupArn != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The metric attribution's failure reason.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The metric attribution's last updated date time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property MetricAttributionArn. 
        /// <para>
        /// The metric attribution's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MetricAttributionArn { get; set; }

        /// <summary>
        /// Checks to see if the MetricAttributionArn property is set.
        /// </summary>
        internal bool IsSetMetricAttributionArn() => this.MetricAttributionArn != null;

        /// <summary>
        /// Gets and sets the property MetricsOutputConfig. 
        /// <para>
        /// The metric attribution's output configuration.
        /// </para>
        /// </summary>
        public MetricAttributionOutput MetricsOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetricsOutputConfig property is set.
        /// </summary>
        internal bool IsSetMetricsOutputConfig() => this.MetricsOutputConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The metric attribution's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The metric attribution's status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
