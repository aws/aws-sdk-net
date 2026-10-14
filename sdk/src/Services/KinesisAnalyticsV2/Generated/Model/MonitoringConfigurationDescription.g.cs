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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes configuration parameters for CloudWatch logging for an application.
    /// </summary>
    public partial class MonitoringConfigurationDescription
    {
        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// Describes whether to use the default CloudWatch logging configuration for an application.
        /// </para>
        /// </summary>
        public ConfigurationType ConfigurationType { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationType property is set.
        /// </summary>
        internal bool IsSetConfigurationType() => this.ConfigurationType != null;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Describes the verbosity of the CloudWatch Logs for an application.
        /// </para>
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property MetricsLevel. 
        /// <para>
        /// Describes the granularity of the CloudWatch Logs for an application.
        /// </para>
        /// </summary>
        public MetricsLevel MetricsLevel { get; set; }

        /// <summary>
        /// Checks to see if the MetricsLevel property is set.
        /// </summary>
        internal bool IsSetMetricsLevel() => this.MetricsLevel != null;
    }
}
