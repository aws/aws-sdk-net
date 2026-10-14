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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the basic configuration needed for building and running an App Runner service.
    /// This type doesn't support the full set of possible configuration options. Fur full
    /// configuration capabilities, use a <c>apprunner.yaml</c> file in the source code repository.
    /// </summary>
    public partial class CodeConfigurationValues
    {
        /// <summary>
        /// Gets and sets the property BuildCommand. 
        /// <para>
        /// The command App Runner runs to build your application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string BuildCommand { get; set; }

        /// <summary>
        /// Checks to see if the BuildCommand property is set.
        /// </summary>
        internal bool IsSetBuildCommand() => this.BuildCommand != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that your application listens to in the container.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>8080</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 51200)]
        public string Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// A runtime environment type for building and running an App Runner service. It represents
        /// a programming language runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property RuntimeEnvironmentSecrets. 
        /// <para>
        /// An array of key-value pairs representing the secrets and parameters that get referenced
        /// to your service as an environment variable. The supported values are either the full
        /// Amazon Resource Name (ARN) of the Secrets Manager secret or the full ARN of the parameter
        /// in the Amazon Web Services Systems Manager Parameter Store.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  If the Amazon Web Services Systems Manager Parameter Store parameter exists in the
        /// same Amazon Web Services Region as the service that you're launching, you can use
        /// either the full ARN or name of the secret. If the parameter exists in a different
        /// Region, then the full ARN must be specified. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Currently, cross account referencing of Amazon Web Services Systems Manager Parameter
        /// Store parameter is not supported. 
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RuntimeEnvironmentSecrets { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RuntimeEnvironmentSecrets property is set.
        /// </summary>
        internal bool IsSetRuntimeEnvironmentSecrets() => this.RuntimeEnvironmentSecrets != null && (this.RuntimeEnvironmentSecrets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuntimeEnvironmentVariables. 
        /// <para>
        /// The environment variables that are available to your running App Runner service. An
        /// array of key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RuntimeEnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RuntimeEnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetRuntimeEnvironmentVariables() => this.RuntimeEnvironmentVariables != null && (this.RuntimeEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartCommand. 
        /// <para>
        /// The command App Runner runs to start your application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StartCommand { get; set; }

        /// <summary>
        /// Checks to see if the StartCommand property is set.
        /// </summary>
        internal bool IsSetStartCommand() => this.StartCommand != null;
    }
}
