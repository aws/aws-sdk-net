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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
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
    /// Container for the parameters to the InvokeDataAutomation operation.
    /// Sync API: Invoke data automation.
    /// </summary>
    public partial class InvokeDataAutomationRequest : AmazonBedrockDataAutomationRuntimeRequest
    {
        private List<Blueprint> _blueprints = AWSConfigs.InitializeCollections ? new List<Blueprint>() : null;
        private DataAutomationConfiguration _dataAutomationConfiguration;
        private string _dataAutomationProfileArn;
        private EncryptionConfiguration _encryptionConfiguration;
        private SyncInputConfiguration _inputConfiguration;
        private OutputConfiguration _outputConfiguration;

        /// <summary>
        /// Gets and sets the property Blueprints. 
        /// <para>
        /// Blueprint list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public List<Blueprint> Blueprints
        {
            get { return this._blueprints; }
            set { this._blueprints = value; }
        }

        // Check to see if Blueprints property is set
        internal bool IsSetBlueprints()
        {
            return this._blueprints != null && (this._blueprints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataAutomationConfiguration. 
        /// <para>
        /// Data automation configuration.
        /// </para>
        /// </summary>
        public DataAutomationConfiguration DataAutomationConfiguration
        {
            get { return this._dataAutomationConfiguration; }
            set { this._dataAutomationConfiguration = value; }
        }

        // Check to see if DataAutomationConfiguration property is set
        internal bool IsSetDataAutomationConfiguration()
        {
            return this._dataAutomationConfiguration != null;
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
        /// Gets and sets the property InputConfiguration. 
        /// <para>
        /// Input configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SyncInputConfiguration InputConfiguration
        {
            get { return this._inputConfiguration; }
            set { this._inputConfiguration = value; }
        }

        // Check to see if InputConfiguration property is set
        internal bool IsSetInputConfiguration()
        {
            return this._inputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// Output configuration.
        /// </para>
        /// </summary>
        public OutputConfiguration OutputConfiguration
        {
            get { return this._outputConfiguration; }
            set { this._outputConfiguration = value; }
        }

        // Check to see if OutputConfiguration property is set
        internal bool IsSetOutputConfiguration()
        {
            return this._outputConfiguration != null;
        }

    }
}