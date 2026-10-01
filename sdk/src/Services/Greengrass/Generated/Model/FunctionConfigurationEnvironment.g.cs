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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// The environment configuration of the function.
    /// </summary>
    public partial class FunctionConfigurationEnvironment
    {
        /// <summary>
        /// Gets and sets the property AccessSysfs. If true, the Lambda function is allowed to
        /// access the host's /sys folder. Use this when the Lambda function needs to read device
        /// information from /sys. This setting applies only when you run the Lambda function
        /// in a Greengrass container.
        /// </summary>
        public bool? AccessSysfs { get; set; }

        /// <summary>
        /// Checks to see if the AccessSysfs property is set.
        /// </summary>
        internal bool IsSetAccessSysfs() => this.AccessSysfs.HasValue;

        /// <summary>
        /// Gets and sets the property Execution. Configuration related to executing the Lambda
        /// function
        /// </summary>
        public FunctionExecutionConfig Execution { get; set; }

        /// <summary>
        /// Checks to see if the Execution property is set.
        /// </summary>
        internal bool IsSetExecution() => this.Execution != null;

        /// <summary>
        /// Gets and sets the property ResourceAccessPolicies. A list of the resources, with their
        /// permissions, to which the Lambda function will be granted access. A Lambda function
        /// can have at most 10 resources. ResourceAccessPolicies apply only when you run the
        /// Lambda function in a Greengrass container.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceAccessPolicy> ResourceAccessPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceAccessPolicy>() : null;

        /// <summary>
        /// Checks to see if the ResourceAccessPolicies property is set.
        /// </summary>
        internal bool IsSetResourceAccessPolicies() => this.ResourceAccessPolicies != null && (this.ResourceAccessPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Variables. Environment variables for the Lambda function's
        /// configuration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Variables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
