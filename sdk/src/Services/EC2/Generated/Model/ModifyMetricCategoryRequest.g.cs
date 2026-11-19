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
    /// Container for the parameters to the ModifyMetricCategory operation. Modifies the metrics
    /// in the specified metric category. The metrics that you specify replace the existing
    /// metrics. <para> Instances that are associated with the metric category are updated
    /// asynchronously. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/manage-detailed-monitoring.html#detailed-monitoring-metric-categories">Use
    /// metric categories for additional metrics</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyMetricCategoryRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property MetricCategoryId. 
        /// <para>
        /// The ID of the metric category.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetricCategoryId { get; set; }

        /// <summary>
        /// Checks to see if the MetricCategoryId property is set.
        /// </summary>
        internal bool IsSetMetricCategoryId() => this.MetricCategoryId != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The names of the metrics for the metric category. These metrics replace the existing
        /// metrics, and must differ from the current set.
        /// </para>
        ///  
        /// <para>
        /// Specify each metric by its Amazon CloudWatch metric name or its OpenTelemetry metric
        /// name. The two names for a measurement are separate entries, and you can include both.
        /// </para>
        ///  
        /// <para>
        /// In Regions where Amazon CloudWatch OpenTelemetry metrics aren't available, you can't
        /// specify OpenTelemetry metric names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
