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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteRumMetricDefinitions operation. Removes
    /// the specified metrics from being sent to an extended metrics destination. <para> If
    /// some metric definition IDs specified in a <c>BatchDeleteRumMetricDefinitions</c> operations
    /// are not valid, those metric definitions fail and return errors, but all valid metric
    /// definition IDs in the same operation are still deleted. </para> <para> The maximum
    /// number of metric definitions that you can specify in one <c>BatchDeleteRumMetricDefinitions</c>
    /// operation is 200. </para>
    /// </summary>
    public partial class BatchDeleteRumMetricDefinitionsRequest : AmazonCloudWatchRUMRequest
    {
        /// <summary>
        /// Gets and sets the property AppMonitorName. 
        /// <para>
        /// The name of the CloudWatch RUM app monitor that is sending these metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AppMonitorName { get; set; }

        /// <summary>
        /// Checks to see if the AppMonitorName property is set.
        /// </summary>
        internal bool IsSetAppMonitorName() => this.AppMonitorName != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Defines the destination where you want to stop sending the specified metrics. Valid
        /// values are <c>CloudWatch</c> and <c>Evidently</c>. If you specify <c>Evidently</c>,
        /// you must also specify the ARN of the CloudWatchEvidently experiment that is to be
        /// the destination and an IAM role that has permission to write to the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// This parameter is required if <c>Destination</c> is <c>Evidently</c>. If <c>Destination</c>
        /// is <c>CloudWatch</c>, do not use this parameter. 
        /// </para>
        ///  
        /// <para>
        /// This parameter specifies the ARN of the Evidently experiment that was receiving the
        /// metrics that are being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property MetricDefinitionIds. 
        /// <para>
        /// An array of structures which define the metrics that you want to stop sending.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> MetricDefinitionIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MetricDefinitionIds property is set.
        /// </summary>
        internal bool IsSetMetricDefinitionIds() => this.MetricDefinitionIds != null && (this.MetricDefinitionIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
