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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the PutRumMetricsDestination operation.
    /// Creates or updates a destination to receive extended metrics from CloudWatch RUM.
    /// You can send extended metrics to CloudWatch or to a CloudWatch Evidently experiment.
    /// 
    ///  
    /// <para>
    /// For more information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricDefinitions.html">BatchCreateRumMetricDefinitions</a>.
    /// </para>
    /// </summary>
    public partial class PutRumMetricsDestinationRequest : AmazonCloudWatchRUMRequest
    {
        private string _appMonitorName;
        private MetricDestination _destination;
        private string _destinationArn;
        private string _iamRoleArn;

        /// <summary>
        /// Gets and sets the property AppMonitorName. 
        /// <para>
        /// The name of the CloudWatch RUM app monitor that will send the metrics.
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
        /// Defines the destination to send the metrics to. Valid values are <code>CloudWatch</code>
        /// and <code>Evidently</code>. If you specify <code>Evidently</code>, you must also specify
        /// the ARN of the CloudWatchEvidently experiment that is to be the destination and an
        /// IAM role that has permission to write to the experiment.
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
        /// Use this parameter only if <code>Destination</code> is <code>Evidently</code>. This
        /// parameter specifies the ARN of the Evidently experiment that will receive the extended
        /// metrics.
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// This parameter is required if <code>Destination</code> is <code>Evidently</code>.
        /// If <code>Destination</code> is <code>CloudWatch</code>, do not use this parameter.
        /// </para>
        ///  
        /// <para>
        /// This parameter specifies the ARN of an IAM role that RUM will assume to write to the
        /// Evidently experiment that you are sending metrics to. This role must have permission
        /// to write to that experiment.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

    }
}