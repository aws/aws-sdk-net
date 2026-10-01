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

namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// Container for the parameters to the GetDeploymentPatternVersion operation. Returns
    /// information about a deployment pattern version.
    /// </summary>
    public partial class GetDeploymentPatternVersionRequest : AmazonLaunchWizardRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentPatternName. 
        /// <para>
        /// The name of the deployment pattern. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">
        /// <c>ListWorkloadDeploymentPatterns</c> </a> operation to discover supported values
        /// for this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DeploymentPatternName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentPatternName property is set.
        /// </summary>
        internal bool IsSetDeploymentPatternName() => this.DeploymentPatternName != null;

        /// <summary>
        /// Gets and sets the property DeploymentPatternVersionName. 
        /// <para>
        /// The name of the deployment pattern version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 30)]
        public string DeploymentPatternVersionName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentPatternVersionName property is set.
        /// </summary>
        internal bool IsSetDeploymentPatternVersionName() => this.DeploymentPatternVersionName != null;

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloads.html">
        /// <c>ListWorkloads</c> </a> operation to discover supported values for this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
