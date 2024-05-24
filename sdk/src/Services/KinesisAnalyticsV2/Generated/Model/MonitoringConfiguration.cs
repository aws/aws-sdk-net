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
    /// Describes configuration parameters for Amazon CloudWatch logging for an application.
    /// For more information about CloudWatch logging, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/monitoring-overview.html">Monitoring</a>.
    /// </summary>
    public partial class MonitoringConfiguration
    {
        private ConfigurationType _configurationType;
        private LogLevel _logLevel;
        private MetricsLevel _metricsLevel;

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// Describes whether to use the default CloudWatch logging configuration for an application.
        /// You must set this property to <c>CUSTOM</c> in order to set the <c>LogLevel</c> or
        /// <c>MetricsLevel</c> parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationType ConfigurationType
        {
            get { return this._configurationType; }
            set { this._configurationType = value; }
        }

        // Check to see if ConfigurationType property is set
        internal bool IsSetConfigurationType()
        {
            return this._configurationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Describes the verbosity of the CloudWatch Logs for an application.
        /// </para>
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsLevel. 
        /// <para>
        /// Describes the granularity of the CloudWatch Logs for an application. The <c>Parallelism</c>
        /// level is not recommended for applications with a Parallelism over 64 due to excessive
        /// costs.
        /// </para>
        /// </summary>
        public MetricsLevel MetricsLevel
        {
            get { return this._metricsLevel; }
            set { this._metricsLevel = value; }
        }

        // Check to see if MetricsLevel property is set
        internal bool IsSetMetricsLevel()
        {
            return this._metricsLevel != null;
        }

    }
}