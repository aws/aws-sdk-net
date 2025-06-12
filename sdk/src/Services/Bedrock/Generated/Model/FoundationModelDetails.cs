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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
    /// Information about a foundation model.
    /// </summary>
    public partial class FoundationModelDetails
    {
        private List<string> _customizationsSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _inferenceTypesSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _inputModalities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _modelArn;
        private string _modelId;
        private FoundationModelLifecycle _modelLifecycle;
        private string _modelName;
        private List<string> _outputModalities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _providerName;
        private bool? _responseStreamingSupported;

        /// <summary>
        /// Gets and sets the property CustomizationsSupported. 
        /// <para>
        /// The customization that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomizationsSupported
        {
            get { return this._customizationsSupported; }
            set { this._customizationsSupported = value; }
        }

        // Check to see if CustomizationsSupported property is set
        internal bool IsSetCustomizationsSupported()
        {
            return this._customizationsSupported != null && (this._customizationsSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferenceTypesSupported. 
        /// <para>
        /// The inference types that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InferenceTypesSupported
        {
            get { return this._inferenceTypesSupported; }
            set { this._inferenceTypesSupported = value; }
        }

        // Check to see if InferenceTypesSupported property is set
        internal bool IsSetInferenceTypesSupported()
        {
            return this._inferenceTypesSupported != null && (this._inferenceTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputModalities. 
        /// <para>
        /// The input modalities that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputModalities
        {
            get { return this._inputModalities; }
            set { this._inputModalities = value; }
        }

        // Check to see if InputModalities property is set
        internal bool IsSetInputModalities()
        {
            return this._inputModalities != null && (this._inputModalities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The model Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=140)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelLifecycle. 
        /// <para>
        /// Contains details about whether a model version is available or deprecated
        /// </para>
        /// </summary>
        public FoundationModelLifecycle ModelLifecycle
        {
            get { return this._modelLifecycle; }
            set { this._modelLifecycle = value; }
        }

        // Check to see if ModelLifecycle property is set
        internal bool IsSetModelLifecycle()
        {
            return this._modelLifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The model name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputModalities. 
        /// <para>
        /// The output modalities that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OutputModalities
        {
            get { return this._outputModalities; }
            set { this._outputModalities = value; }
        }

        // Check to see if OutputModalities property is set
        internal bool IsSetOutputModalities()
        {
            return this._outputModalities != null && (this._outputModalities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The model's provider name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseStreamingSupported. 
        /// <para>
        /// Indicates whether the model supports streaming.
        /// </para>
        /// </summary>
        public bool? ResponseStreamingSupported
        {
            get { return this._responseStreamingSupported; }
            set { this._responseStreamingSupported = value; }
        }

        // Check to see if ResponseStreamingSupported property is set
        internal bool IsSetResponseStreamingSupported()
        {
            return this._responseStreamingSupported.HasValue; 
        }

    }
}