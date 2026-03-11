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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
    /// Container for the parameters to the InvokeBlueprintOptimizationAsync operation.
    /// Invoke an async job to perform Blueprint Optimization
    /// </summary>
    public partial class InvokeBlueprintOptimizationAsyncRequest : AmazonBedrockDataAutomationRequest
    {
        private BlueprintOptimizationObject _blueprint;
        private string _dataAutomationProfileArn;
        private EncryptionConfiguration _encryptionConfiguration;
        private BlueprintOptimizationOutputConfiguration _outputConfiguration;
        private List<BlueprintOptimizationSample> _samples = AWSConfigs.InitializeCollections ? new List<BlueprintOptimizationSample>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Blueprint. 
        /// <para>
        /// Blueprint to be optimized
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlueprintOptimizationObject Blueprint
        {
            get { return this._blueprint; }
            set { this._blueprint = value; }
        }

        // Check to see if Blueprint property is set
        internal bool IsSetBlueprint()
        {
            return this._blueprint != null;
        }

        /// <summary>
        /// Gets and sets the property DataAutomationProfileArn. 
        /// <para>
        /// Data automation profile ARN
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DataAutomationProfileArn
        {
            get { return this._dataAutomationProfileArn; }
            set { this._dataAutomationProfileArn = value; }
        }

        // Check to see if DataAutomationProfileArn property is set
        internal bool IsSetDataAutomationProfileArn()
        {
            return this._dataAutomationProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Encryption configuration.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// Output configuration where the results should be placed
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlueprintOptimizationOutputConfiguration OutputConfiguration
        {
            get { return this._outputConfiguration; }
            set { this._outputConfiguration = value; }
        }

        // Check to see if OutputConfiguration property is set
        internal bool IsSetOutputConfiguration()
        {
            return this._outputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Samples. 
        /// <para>
        /// List of Blueprint Optimization Samples
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BlueprintOptimizationSample> Samples
        {
            get { return this._samples; }
            set { this._samples = value; }
        }

        // Check to see if Samples property is set
        internal bool IsSetSamples()
        {
            return this._samples != null && (this._samples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}