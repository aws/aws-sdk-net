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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Configuration settings of a canary deployment.
    /// </summary>
    public partial class CanarySettings
    {
        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the canary deployment.
        /// </para>
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property PercentTraffic. 
        /// <para>
        /// The percent (0-100) of traffic diverted to a canary deployment.
        /// </para>
        /// </summary>
        public double? PercentTraffic { get; set; }

        /// <summary>
        /// Checks to see if the PercentTraffic property is set.
        /// </summary>
        internal bool IsSetPercentTraffic() => this.PercentTraffic.HasValue;

        /// <summary>
        /// Gets and sets the property StageVariableOverrides. 
        /// <para>
        /// Stage variables overridden for a canary release deployment, including new stage variables
        /// introduced in the canary. These stage variables are represented as a string-to-string
        /// map between stage variable names and their values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StageVariableOverrides { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StageVariableOverrides property is set.
        /// </summary>
        internal bool IsSetStageVariableOverrides() => this.StageVariableOverrides != null && (this.StageVariableOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseStageCache. 
        /// <para>
        /// A Boolean flag to indicate whether the canary deployment uses the stage cache or not.
        /// </para>
        /// </summary>
        public bool? UseStageCache { get; set; }

        /// <summary>
        /// Checks to see if the UseStageCache property is set.
        /// </summary>
        internal bool IsSetUseStageCache() => this.UseStageCache.HasValue;
    }
}
