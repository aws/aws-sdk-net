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

namespace Amazon.BedrockDataAutomationRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeDataAutomation operation. Sync API: Invoke
    /// data automation.
    /// </summary>
    public partial class InvokeDataAutomationRequest : AmazonBedrockDataAutomationRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property Blueprints. Blueprint list.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public List<Blueprint> Blueprints { get; set; } = AWSConfigs.InitializeCollections ? new List<Blueprint>() : null;

        /// <summary>
        /// Checks to see if the Blueprints property is set.
        /// </summary>
        internal bool IsSetBlueprints() => this.Blueprints != null && (this.Blueprints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataAutomationConfiguration. Data automation configuration.
        /// </summary>
        public DataAutomationConfiguration DataAutomationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataAutomationConfiguration property is set.
        /// </summary>
        internal bool IsSetDataAutomationConfiguration() => this.DataAutomationConfiguration != null;

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
        /// Gets and sets the property InputConfiguration. Input configuration.
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncInputConfiguration InputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputConfiguration property is set.
        /// </summary>
        internal bool IsSetInputConfiguration() => this.InputConfiguration != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. Output configuration.
        /// </summary>
        public OutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;
    }
}
