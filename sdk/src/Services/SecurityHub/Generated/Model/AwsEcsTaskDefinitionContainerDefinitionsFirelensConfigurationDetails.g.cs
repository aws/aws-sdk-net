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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The FireLens configuration for the container. The configuration specifies and configures
    /// a log router for container logs.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options to use to configure the log router.
        /// </para>
        ///  
        /// <para>
        /// The valid option keys are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>enable-ecs-log-metadata</c>. The value can be <c>true</c> or <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>config-file-type</c>. The value can be <c>s3</c> or <c>file</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>config-file-value</c>. The value is either an S3 ARN or a file path.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Options { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The log router to use. Valid values are <c>fluentbit</c> or <c>fluentd</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
