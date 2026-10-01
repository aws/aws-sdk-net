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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The configuration setting for monitoring.
    /// </summary>
    public partial class MonitoringConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLoggingConfiguration. 
        /// <para>
        /// The Amazon CloudWatch configuration for monitoring logs. You can configure your jobs
        /// to send log information to CloudWatch.
        /// </para>
        /// </summary>
        public CloudWatchLoggingConfiguration CloudWatchLoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingConfiguration() => this.CloudWatchLoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManagedPersistenceMonitoringConfiguration. 
        /// <para>
        /// The managed log persistence configuration for a job run.
        /// </para>
        /// </summary>
        public ManagedPersistenceMonitoringConfiguration ManagedPersistenceMonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedPersistenceMonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedPersistenceMonitoringConfiguration() => this.ManagedPersistenceMonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property PrometheusMonitoringConfiguration. 
        /// <para>
        /// The monitoring configuration object you can configure to send metrics to Amazon Managed
        /// Service for Prometheus for a job run.
        /// </para>
        /// </summary>
        public PrometheusMonitoringConfiguration PrometheusMonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PrometheusMonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetPrometheusMonitoringConfiguration() => this.PrometheusMonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3MonitoringConfiguration. 
        /// <para>
        /// The Amazon S3 configuration for monitoring log publishing.
        /// </para>
        /// </summary>
        public S3MonitoringConfiguration S3MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetS3MonitoringConfiguration() => this.S3MonitoringConfiguration != null;
    }
}
