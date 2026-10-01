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
    /// Contains the information of a Blueprint.
    /// </summary>
    public partial class Blueprint
    {
        /// <summary>
        /// Gets and sets the property BlueprintArn.
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string BlueprintArn { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintArn property is set.
        /// </summary>
        internal bool IsSetBlueprintArn() => this.BlueprintArn != null;

        /// <summary>
        /// Gets and sets the property BlueprintName.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string BlueprintName { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintName property is set.
        /// </summary>
        internal bool IsSetBlueprintName() => this.BlueprintName != null;

        /// <summary>
        /// Gets and sets the property BlueprintStage.
        /// </summary>
        public BlueprintStage BlueprintStage { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintStage property is set.
        /// </summary>
        internal bool IsSetBlueprintStage() => this.BlueprintStage != null;

        /// <summary>
        /// Gets and sets the property BlueprintVersion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string BlueprintVersion { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintVersion property is set.
        /// </summary>
        internal bool IsSetBlueprintVersion() => this.BlueprintVersion != null;

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property KmsEncryptionContext.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, string> KmsEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KmsEncryptionContext property is set.
        /// </summary>
        internal bool IsSetKmsEncryptionContext() => this.KmsEncryptionContext != null && (this.KmsEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OptimizationSamples.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlueprintOptimizationSample> OptimizationSamples { get; set; } = AWSConfigs.InitializeCollections ? new List<BlueprintOptimizationSample>() : null;

        /// <summary>
        /// Checks to see if the OptimizationSamples property is set.
        /// </summary>
        internal bool IsSetOptimizationSamples() => this.OptimizationSamples != null && (this.OptimizationSamples.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptimizationTime.
        /// </summary>
        public DateTime? OptimizationTime { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationTime property is set.
        /// </summary>
        internal bool IsSetOptimizationTime() => this.OptimizationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Schema.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100000)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        [AWSProperty(Required = true)]
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
