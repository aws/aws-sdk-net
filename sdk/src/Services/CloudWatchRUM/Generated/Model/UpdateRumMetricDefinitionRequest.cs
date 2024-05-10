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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the UpdateRumMetricDefinition operation.
    /// Modifies one existing metric definition for CloudWatch RUM extended metrics. For more
    /// information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricsDefinitions.html">BatchCreateRumMetricsDefinitions</a>.
    /// </summary>
    public partial class UpdateRumMetricDefinitionRequest : AmazonCloudWatchRUMRequest
    {
        private string _appMonitorName;
        private MetricDestination _destination;
        private string _destinationArn;
        private MetricDefinitionRequest _metricDefinition;
        private string _metricDefinitionId;

        /// <summary>
        /// Gets and sets the property AppMonitorName. 
        /// <para>
        /// The name of the CloudWatch RUM app monitor that sends these metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AppMonitorName
        {
            get { return this._appMonitorName; }
            set { this._appMonitorName = value; }
        }

        // Check to see if AppMonitorName property is set
        internal bool IsSetAppMonitorName()
        {
            return this._appMonitorName != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination to send the metrics to. Valid values are <c>CloudWatch</c> and <c>Evidently</c>.
        /// If you specify <c>Evidently</c>, you must also specify the ARN of the CloudWatchEvidently
        /// experiment that will receive the metrics and an IAM role that has permission to write
        /// to the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// This parameter is required if <c>Destination</c> is <c>Evidently</c>. If <c>Destination</c>
        /// is <c>CloudWatch</c>, do not use this parameter.
        /// </para>
        ///  
        /// <para>
        /// This parameter specifies the ARN of the Evidently experiment that is to receive the
        /// metrics. You must have already defined this experiment as a valid destination. For
        /// more information, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_PutRumMetricsDestination.html">PutRumMetricsDestination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDefinition. 
        /// <para>
        /// A structure that contains the new definition that you want to use for this metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricDefinitionRequest MetricDefinition
        {
            get { return this._metricDefinition; }
            set { this._metricDefinition = value; }
        }

        // Check to see if MetricDefinition property is set
        internal bool IsSetMetricDefinition()
        {
            return this._metricDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitionId. 
        /// <para>
        /// The ID of the metric definition to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MetricDefinitionId
        {
            get { return this._metricDefinitionId; }
            set { this._metricDefinitionId = value; }
        }

        // Check to see if MetricDefinitionId property is set
        internal bool IsSetMetricDefinitionId()
        {
            return this._metricDefinitionId != null;
        }

    }
}