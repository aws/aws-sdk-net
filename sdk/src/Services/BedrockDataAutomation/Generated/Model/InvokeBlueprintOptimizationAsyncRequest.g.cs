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

namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeBlueprintOptimizationAsync operation. Invoke
    /// an async job to perform Blueprint Optimization
    /// </summary>
    public partial class InvokeBlueprintOptimizationAsyncRequest : AmazonBedrockDataAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property Blueprint. Blueprint to be optimized
        /// </summary>
        [AWSProperty(Required = true)]
        public BlueprintOptimizationObject Blueprint { get; set; }

        /// <summary>
        /// Checks to see if the Blueprint property is set.
        /// </summary>
        internal bool IsSetBlueprint() => this.Blueprint != null;

        /// <summary>
        /// Gets and sets the property DataAutomationProfileArn. Data automation profile ARN
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DataAutomationProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAutomationProfileArn property is set.
        /// </summary>
        internal bool IsSetDataAutomationProfileArn() => this.DataAutomationProfileArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. Encryption configuration.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. Output configuration where the results
        /// should be placed
        /// </summary>
        [AWSProperty(Required = true)]
        public BlueprintOptimizationOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Samples. List of Blueprint Optimization Samples
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BlueprintOptimizationSample> Samples { get; set; } = AWSConfigs.InitializeCollections ? new List<BlueprintOptimizationSample>() : null;

        /// <summary>
        /// Checks to see if the Samples property is set.
        /// </summary>
        internal bool IsSetSamples() => this.Samples != null && (this.Samples.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. List of tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
