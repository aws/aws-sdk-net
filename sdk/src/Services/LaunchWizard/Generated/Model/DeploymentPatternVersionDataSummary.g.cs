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
    /// Describes a deployment pattern version summary.
    /// </summary>
    public partial class DeploymentPatternVersionDataSummary
    {
        /// <summary>
        /// Gets and sets the property DeploymentPatternName. 
        /// <para>
        /// The name of the deployment pattern.
        /// </para>
        /// </summary>
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
        public string DeploymentPatternVersionName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentPatternVersionName property is set.
        /// </summary>
        internal bool IsSetDeploymentPatternVersionName() => this.DeploymentPatternVersionName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the deployment pattern version.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DocumentationUrl. 
        /// <para>
        /// The URL of the documentation for the deployment pattern version.
        /// </para>
        /// </summary>
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationUrl property is set.
        /// </summary>
        internal bool IsSetDocumentationUrl() => this.DocumentationUrl != null;

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload.
        /// </para>
        /// </summary>
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
