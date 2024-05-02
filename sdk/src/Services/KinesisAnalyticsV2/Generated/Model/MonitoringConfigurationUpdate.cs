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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
        private ConfigurationType _configurationTypeUpdate;
        private LogLevel _logLevelUpdate;
        private MetricsLevel _metricsLevelUpdate;

        /// <summary>
        /// Gets and sets the property ConfigurationTypeUpdate. 
        /// <para>
        /// Describes updates to whether to use the default CloudWatch logging configuration for
        /// an application. You must set this property to <c>CUSTOM</c> in order to set the <c>LogLevel</c>
        /// or <c>MetricsLevel</c> parameters.
        /// </para>
        /// </summary>
        public ConfigurationType ConfigurationTypeUpdate
        {
            get { return this._configurationTypeUpdate; }
            set { this._configurationTypeUpdate = value; }
        }

        // Check to see if ConfigurationTypeUpdate property is set
        internal bool IsSetConfigurationTypeUpdate()
        {
            return this._configurationTypeUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevelUpdate. 
        /// <para>
        /// Describes updates to the verbosity of the CloudWatch Logs for an application.
        /// </para>
        /// </summary>
        public LogLevel LogLevelUpdate
        {
            get { return this._logLevelUpdate; }
            set { this._logLevelUpdate = value; }
        }

        // Check to see if LogLevelUpdate property is set
        internal bool IsSetLogLevelUpdate()
        {
            return this._logLevelUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsLevelUpdate. 
        /// <para>
        /// Describes updates to the granularity of the CloudWatch Logs for an application. The
        /// <c>Parallelism</c> level is not recommended for applications with a Parallelism over
        /// 64 due to excessive costs.
        /// </para>
        /// </summary>
        public MetricsLevel MetricsLevelUpdate
        {
            get { return this._metricsLevelUpdate; }
            set { this._metricsLevelUpdate = value; }
        }

        // Check to see if MetricsLevelUpdate property is set
        internal bool IsSetMetricsLevelUpdate()
        {
            return this._metricsLevelUpdate != null;
        }

    }
}