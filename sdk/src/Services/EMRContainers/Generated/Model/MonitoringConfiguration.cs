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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Configuration setting for monitoring.
    /// </summary>
    public partial class MonitoringConfiguration
    {
        private CloudWatchMonitoringConfiguration _cloudWatchMonitoringConfiguration;
        private ContainerLogRotationConfiguration _containerLogRotationConfiguration;
        private ManagedLogs _managedLogs;
        private PersistentAppUI _persistentAppUI;
        private S3MonitoringConfiguration _s3MonitoringConfiguration;

        /// <summary>
        /// Gets and sets the property CloudWatchMonitoringConfiguration. 
        /// <para>
        /// Monitoring configurations for CloudWatch.
        /// </para>
        /// </summary>
        public CloudWatchMonitoringConfiguration CloudWatchMonitoringConfiguration
        {
            get { return this._cloudWatchMonitoringConfiguration; }
            set { this._cloudWatchMonitoringConfiguration = value; }
        }

        // Check to see if CloudWatchMonitoringConfiguration property is set
        internal bool IsSetCloudWatchMonitoringConfiguration()
        {
            return this._cloudWatchMonitoringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerLogRotationConfiguration. 
        /// <para>
        /// Enable or disable container log rotation.
        /// </para>
        /// </summary>
        public ContainerLogRotationConfiguration ContainerLogRotationConfiguration
        {
            get { return this._containerLogRotationConfiguration; }
            set { this._containerLogRotationConfiguration = value; }
        }

        // Check to see if ContainerLogRotationConfiguration property is set
        internal bool IsSetContainerLogRotationConfiguration()
        {
            return this._containerLogRotationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedLogs. 
        /// <para>
        /// The entity that controls configuration for managed logs.
        /// </para>
        /// </summary>
        public ManagedLogs ManagedLogs
        {
            get { return this._managedLogs; }
            set { this._managedLogs = value; }
        }

        // Check to see if ManagedLogs property is set
        internal bool IsSetManagedLogs()
        {
            return this._managedLogs != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentAppUI. 
        /// <para>
        /// Monitoring configurations for the persistent application UI. 
        /// </para>
        /// </summary>
        public PersistentAppUI PersistentAppUI
        {
            get { return this._persistentAppUI; }
            set { this._persistentAppUI = value; }
        }

        // Check to see if PersistentAppUI property is set
        internal bool IsSetPersistentAppUI()
        {
            return this._persistentAppUI != null;
        }

        /// <summary>
        /// Gets and sets the property S3MonitoringConfiguration. 
        /// <para>
        /// Amazon S3 configuration for monitoring log publishing.
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