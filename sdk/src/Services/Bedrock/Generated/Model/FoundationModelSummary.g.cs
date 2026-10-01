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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Summary information for a foundation model.
    /// </summary>
    public partial class FoundationModelSummary
    {
        /// <summary>
        /// Gets and sets the property CustomizationsSupported. 
        /// <para>
        /// Whether the model supports fine-tuning or continual pre-training.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomizationsSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomizationsSupported property is set.
        /// </summary>
        internal bool IsSetCustomizationsSupported() => this.CustomizationsSupported != null && (this.CustomizationsSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InferenceTypesSupported. 
        /// <para>
        /// The inference types that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InferenceTypesSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InferenceTypesSupported property is set.
        /// </summary>
        internal bool IsSetInferenceTypesSupported() => this.InferenceTypesSupported != null && (this.InferenceTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputModalities. 
        /// <para>
        /// The input modalities that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputModalities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InputModalities property is set.
        /// </summary>
        internal bool IsSetInputModalities() => this.InputModalities != null && (this.InputModalities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the foundation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID of the foundation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 140)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property ModelLifecycle. 
        /// <para>
        /// Contains details about whether a model version is available or deprecated.
        /// </para>
        /// </summary>
        public FoundationModelLifecycle ModelLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the ModelLifecycle property is set.
        /// </summary>
        internal bool IsSetModelLifecycle() => this.ModelLifecycle != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property OutputModalities. 
        /// <para>
        /// The output modalities that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OutputModalities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputModalities property is set.
        /// </summary>
        internal bool IsSetOutputModalities() => this.OutputModalities != null && (this.OutputModalities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The model's provider name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property ResponseStreamingSupported. 
        /// <para>
        /// Indicates whether the model supports streaming.
        /// </para>
        /// </summary>
        public bool? ResponseStreamingSupported { get; set; }

        /// <summary>
        /// Checks to see if the ResponseStreamingSupported property is set.
        /// </summary>
        internal bool IsSetResponseStreamingSupported() => this.ResponseStreamingSupported.HasValue;
    }
}
