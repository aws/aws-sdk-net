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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Configuration setting for monitoring. This data type allows job template parameters
    /// to be specified within.
    /// </summary>
    public partial class ParametricMonitoringConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudWatchMonitoringConfiguration. 
        /// <para>
        ///  Monitoring configurations for CloudWatch.
        /// </para>
        /// </summary>
        public ParametricCloudWatchMonitoringConfiguration CloudWatchMonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchMonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudWatchMonitoringConfiguration() => this.CloudWatchMonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property PersistentAppUI. 
        /// <para>
        ///  Monitoring configurations for the persistent application UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string PersistentAppUI { get; set; }

        /// <summary>
        /// Checks to see if the PersistentAppUI property is set.
        /// </summary>
        internal bool IsSetPersistentAppUI() => this.PersistentAppUI != null;

        /// <summary>
        /// Gets and sets the property S3MonitoringConfiguration. 
        /// <para>
        ///  Amazon S3 configuration for monitoring log publishing.
        /// </para>
        /// </summary>
        public ParametricS3MonitoringConfiguration S3MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetS3MonitoringConfiguration() => this.S3MonitoringConfiguration != null;
    }
}
