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
    /// A list of container definitions that describe the different containers that make up
    /// an AutoML candidate. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
    /// ContainerDefinition</a>.
    /// </summary>
    public partial class AutoMLContainerDefinition
    {
        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the container. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
        /// ContainerDefinition</a>.
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

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The Amazon Elastic Container Registry (Amazon ECR) path of the container. For more
        /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
        /// ContainerDefinition</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The location of the model artifacts. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
        /// ContainerDefinition</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string ModelDataUrl { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataUrl property is set.
        /// </summary>
        internal bool IsSetModelDataUrl() => this.ModelDataUrl != null;
    }
}
