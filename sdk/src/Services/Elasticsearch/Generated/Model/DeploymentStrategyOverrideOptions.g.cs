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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Overrides the deployment strategy for a single operation, such as a version upgrade.
    /// </summary>
    public partial class DeploymentStrategyOverrideOptions
    {
        /// <summary>
        /// Gets and sets the property ClonedBlueGreenOptions. 
        /// <para>
        /// Options that apply when <c>DeploymentStrategy</c> is <c>ClonedBlueGreen</c>.
        /// </para>
        /// </summary>
        public ClonedBlueGreenOptions ClonedBlueGreenOptions { get; set; }

        /// <summary>
        /// Checks to see if the ClonedBlueGreenOptions property is set.
        /// </summary>
        internal bool IsSetClonedBlueGreenOptions() => this.ClonedBlueGreenOptions != null;

        /// <summary>
        /// Gets and sets the property DeploymentStrategy. 
        /// <para>
        /// The deployment strategy to use for this operation. The only valid value is <c>ClonedBlueGreen</c>,
        /// which creates a cloned cluster on the target version next to the primary cluster so
        /// that you can validate it and shift traffic to it before you cut over.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentStrategyOverride DeploymentStrategy { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStrategy property is set.
        /// </summary>
        internal bool IsSetDeploymentStrategy() => this.DeploymentStrategy != null;
    }
}
