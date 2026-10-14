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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details about the resources that are deployed with this inference component.
    /// </summary>
    public partial class InferenceComponentContainerSpecificationSummary
    {
        /// <summary>
        /// Gets and sets the property ArtifactUrl. 
        /// <para>
        /// The Amazon S3 path where the model artifacts are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ArtifactUrl { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactUrl property is set.
        /// </summary>
        internal bool IsSetArtifactUrl() => this.ArtifactUrl != null;

        /// <summary>
        /// Gets and sets the property ContainerMetricsConfig. 
        /// <para>
        /// The container metrics scraping configuration for this inference component, including
        /// the metrics endpoint path and publishing frequency.
        /// </para>
        /// </summary>
        public ContainerMetricsConfig ContainerMetricsConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContainerMetricsConfig property is set.
        /// </summary>
        internal bool IsSetContainerMetricsConfig() => this.ContainerMetricsConfig != null;

        /// <summary>
        /// Gets and sets the property DeployedImage.
        /// </summary>
        public DeployedImage DeployedImage { get; set; }

        /// <summary>
        /// Checks to see if the DeployedImage property is set.
        /// </summary>
        internal bool IsSetDeployedImage() => this.DeployedImage != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
