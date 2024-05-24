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
    /// Configuration setting for monitoring. This data type allows job template parameters
    /// to be specified within.
    /// </summary>
    public partial class ParametricMonitoringConfiguration
    {
        private ParametricCloudWatchMonitoringConfiguration _cloudWatchMonitoringConfiguration;
        private string _persistentAppUI;
        private ParametricS3MonitoringConfiguration _s3MonitoringConfiguration;

        /// <summary>
        /// Gets and sets the property CloudWatchMonitoringConfiguration. 
        /// <para>
        ///  Monitoring configurations for CloudWatch.
        /// </para>
        /// </summary>
        public ParametricCloudWatchMonitoringConfiguration CloudWatchMonitoringConfiguration
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
        /// Gets and sets the property PersistentAppUI. 
        /// <para>
        ///  Monitoring configurations for the persistent application UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string PersistentAppUI
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
        ///  Amazon S3 configuration for monitoring log publishing.
        /// </para>
        /// </summary>
        public ParametricS3MonitoringConfiguration S3MonitoringConfiguration
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