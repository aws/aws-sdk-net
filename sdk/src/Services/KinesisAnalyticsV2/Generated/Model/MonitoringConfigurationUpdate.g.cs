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
    /// Describes updates to configuration parameters for Amazon CloudWatch logging for an
    /// application.
    /// </summary>
    public partial class MonitoringConfigurationUpdate
    {
        /// <summary>
        /// Gets and sets the property ConfigurationTypeUpdate. 
        /// <para>
        /// Describes updates to whether to use the default CloudWatch logging configuration for
        /// an application. You must set this property to <c>CUSTOM</c> in order to set the <c>LogLevel</c>
        /// or <c>MetricsLevel</c> parameters.
        /// </para>
        /// </summary>
        public ConfigurationType ConfigurationTypeUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationTypeUpdate property is set.
        /// </summary>
        internal bool IsSetConfigurationTypeUpdate() => this.ConfigurationTypeUpdate != null;

        /// <summary>
        /// Gets and sets the property LogLevelUpdate. 
        /// <para>
        /// Describes updates to the verbosity of the CloudWatch Logs for an application.
        /// </para>
        /// </summary>
        public LogLevel LogLevelUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LogLevelUpdate property is set.
        /// </summary>
        internal bool IsSetLogLevelUpdate() => this.LogLevelUpdate != null;

        /// <summary>
        /// Gets and sets the property MetricsLevelUpdate. 
        /// <para>
        /// Describes updates to the granularity of the CloudWatch Logs for an application. The
        /// <c>Parallelism</c> level is not recommended for applications with a Parallelism over
        /// 64 due to excessive costs.
        /// </para>
        /// </summary>
        public MetricsLevel MetricsLevelUpdate { get; set; }

        /// <summary>
        /// Checks to see if the MetricsLevelUpdate property is set.
        /// </summary>
        internal bool IsSetMetricsLevelUpdate() => this.MetricsLevelUpdate != null;
    }
}
