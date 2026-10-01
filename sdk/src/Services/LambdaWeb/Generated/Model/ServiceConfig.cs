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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The service configuration for a web function revision, including execution role, timeout,
    /// concurrency, and telemetry settings.
    /// </summary>
    public partial class ServiceConfig
    {
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _executionRoleArn;
        private int? _maxConcurrencyPerEnvironment;
        private TelemetryConfig _telemetryConfig;
        private int? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// A map of environment variable key-value pairs available to the web function at runtime.
        /// Environment variable values are sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the web function assumes when it runs. This role provides
        /// permissions to access AWS services and resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrencyPerEnvironment. 
        /// <para>
        /// The maximum number of concurrent requests handled per execution environment. Minimum
        /// value of 1, maximum value of 128. If you don't specify a value, the default is 64,
        /// and this default is returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public int? MaxConcurrencyPerEnvironment
        {
            get { return this._maxConcurrencyPerEnvironment; }
            set { this._maxConcurrencyPerEnvironment = value; }
        }

        // Check to see if MaxConcurrencyPerEnvironment property is set
        internal bool IsSetMaxConcurrencyPerEnvironment()
        {
            return this._maxConcurrencyPerEnvironment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TelemetryConfig. 
        /// <para>
        /// The telemetry configuration for the web function, including logging settings.
        /// </para>
        /// </summary>
        public TelemetryConfig TelemetryConfig
        {
            get { return this._telemetryConfig; }
            set { this._telemetryConfig = value; }
        }

        // Check to see if TelemetryConfig property is set
        internal bool IsSetTelemetryConfig()
        {
            return this._telemetryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The amount of time (in seconds) that Lambda allows the web function to run before
        /// stopping it. Minimum value of 3, maximum value of 900. If you don't specify a value,
        /// the default is 30, and this default is returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=900)]
        public int? TimeoutSeconds
        {
            get { return this._timeoutSeconds; }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

    }
}