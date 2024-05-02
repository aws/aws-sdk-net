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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMonitoring operation.
    /// Updates the monitoring settings for the cluster. You can use this operation to specify
    /// which Apache Kafka metrics you want Amazon MSK to send to Amazon CloudWatch. You can
    /// also specify settings for open monitoring with Prometheus.
    /// </summary>
    public partial class UpdateMonitoringRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private string _currentVersion;
        private EnhancedMonitoring _enhancedMonitoring;
        private LoggingInfo _loggingInfo;
        private OpenMonitoringInfo _openMonitoring;

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion.             
        /// <para>
        /// The version of the MSK cluster to update. Cluster versions aren't simple numbers.
        /// You can describe an MSK cluster to find its version. When this update operation is
        /// successful, it generates a new cluster version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedMonitoring.             
        /// <para>
        /// Specifies which Apache Kafka metrics Amazon MSK gathers and sends to Amazon CloudWatch
        /// for this cluster.
        /// </para>
        /// </summary>
        public EnhancedMonitoring EnhancedMonitoring
        {
            get { return this._enhancedMonitoring; }
            set { this._enhancedMonitoring = value; }
        }

        // Check to see if EnhancedMonitoring property is set
        internal bool IsSetEnhancedMonitoring()
        {
            return this._enhancedMonitoring != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingInfo.
        /// </summary>
        public LoggingInfo LoggingInfo
        {
            get { return this._loggingInfo; }
            set { this._loggingInfo = value; }
        }

        // Check to see if LoggingInfo property is set
        internal bool IsSetLoggingInfo()
        {
            return this._loggingInfo != null;
        }

        /// <summary>
        /// Gets and sets the property OpenMonitoring.             
        /// <para>
        /// The settings for open monitoring.
        /// </para>
        /// </summary>
        public OpenMonitoringInfo OpenMonitoring
        {
            get { return this._openMonitoring; }
            set { this._openMonitoring = value; }
        }

        // Check to see if OpenMonitoring property is set
        internal bool IsSetOpenMonitoring()
        {
            return this._openMonitoring != null;
        }

    }
}