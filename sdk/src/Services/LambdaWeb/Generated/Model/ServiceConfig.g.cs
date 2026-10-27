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

namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The service configuration for a web function revision, including execution role, timeout,
    /// VPC network access, concurrency, and telemetry settings.
    /// </summary>
    public partial class ServiceConfig
    {
        /// <summary>
        /// Gets and sets the property EgressNetworkConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda network connector that gives the web
        /// function access to resources in your VPC. You must specify the fully qualified ARN,
        /// including the connector version, which pins the revision to that version. If the network
        /// connector is deleted, invocations of revisions that reference it fail. Revisions that
        /// specify a network connector support only <c>HomeRegion</c> endpoints, not <c>MultiRegion</c>
        /// or <c>PerRegion</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EgressNetworkConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the EgressNetworkConnectorArn property is set.
        /// </summary>
        internal bool IsSetEgressNetworkConnectorArn() => this.EgressNetworkConnectorArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// A map of environment variable key-value pairs available to the web function at runtime.
        /// Environment variable values are sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the web function assumes when it runs. This role provides
        /// permissions to access AWS services and resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrencyPerEnvironment. 
        /// <para>
        /// The maximum number of concurrent requests handled per execution environment. Minimum
        /// value of 1, maximum value of 128. If you don't specify a value, the default is 64,
        /// and this default is returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public int? MaxConcurrencyPerEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrencyPerEnvironment property is set.
        /// </summary>
        internal bool IsSetMaxConcurrencyPerEnvironment() => this.MaxConcurrencyPerEnvironment.HasValue;

        /// <summary>
        /// Gets and sets the property TelemetryConfig. 
        /// <para>
        /// The telemetry configuration for the web function, including logging settings.
        /// </para>
        /// </summary>
        public TelemetryConfig TelemetryConfig { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryConfig property is set.
        /// </summary>
        internal bool IsSetTelemetryConfig() => this.TelemetryConfig != null;

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The amount of time (in seconds) that Lambda allows the web function to run before
        /// stopping it. Minimum value of 3, maximum value of 900. If you don't specify a value,
        /// the default is 30, and this default is returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 900)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;
    }
}
