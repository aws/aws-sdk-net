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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
        private CloudWatchLoggingConfiguration _cloudWatchLoggingConfiguration;
        private ManagedPersistenceMonitoringConfiguration _managedPersistenceMonitoringConfiguration;
        private PrometheusMonitoringConfiguration _prometheusMonitoringConfiguration;
        private S3MonitoringConfiguration _s3MonitoringConfiguration;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingConfiguration. 
        /// <para>
        /// The Amazon CloudWatch configuration for monitoring logs. You can configure your jobs
        /// to send log information to CloudWatch.
        /// </para>
        /// </summary>
        public CloudWatchLoggingConfiguration CloudWatchLoggingConfiguration
        {
            get { return this._cloudWatchLoggingConfiguration; }
            set { this._cloudWatchLoggingConfiguration = value; }
        }

        // Check to see if CloudWatchLoggingConfiguration property is set
        internal bool IsSetCloudWatchLoggingConfiguration()
        {
            return this._cloudWatchLoggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedPersistenceMonitoringConfiguration. 
        /// <para>
        /// The managed log persistence configuration for a job run.
        /// </para>
        /// </summary>
        public ManagedPersistenceMonitoringConfiguration ManagedPersistenceMonitoringConfiguration
        {
            get { return this._managedPersistenceMonitoringConfiguration; }
            set { this._managedPersistenceMonitoringConfiguration = value; }
        }

        // Check to see if ManagedPersistenceMonitoringConfiguration property is set
        internal bool IsSetManagedPersistenceMonitoringConfiguration()
        {
            return this._managedPersistenceMonitoringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PrometheusMonitoringConfiguration. 
        /// <para>
        /// The monitoring configuration object you can configure to send metrics to Amazon Managed
        /// Service for Prometheus for a job run.
        /// </para>
        /// </summary>
        public PrometheusMonitoringConfiguration PrometheusMonitoringConfiguration
        {
            get { return this._prometheusMonitoringConfiguration; }
            set { this._prometheusMonitoringConfiguration = value; }
        }

        // Check to see if PrometheusMonitoringConfiguration property is set
        internal bool IsSetPrometheusMonitoringConfiguration()
        {
            return this._prometheusMonitoringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3MonitoringConfiguration. 
        /// <para>
        /// The Amazon S3 configuration for monitoring log publishing.
        /// </para>
        /// </summary>
        public S3MonitoringConfiguration S3MonitoringConfiguration
        {
            get { return this._s3MonitoringConfiguration; }
            set { this._s3MonitoringConfiguration = value; }
        }

        // Check to see if S3MonitoringConfiguration property is set
        internal bool IsSetS3MonitoringConfiguration()
        {
            return this._s3MonitoringConfiguration != null;
        }

    }
}