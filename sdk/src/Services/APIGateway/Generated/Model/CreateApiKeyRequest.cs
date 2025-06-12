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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApiKey operation.
    /// Create an ApiKey resource.
    /// </summary>
    public partial class CreateApiKeyRequest : AmazonAPIGatewayRequest
    {
        private string _customerId;
        private string _description;
        private bool? _enabled;
        private bool? _generateDistinctId;
        private string _name;
        private List<StageKey> _stageKeys = AWSConfigs.InitializeCollections ? new List<StageKey>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _value;

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// An Amazon Web Services Marketplace customer identifier, when integrating with the
        /// Amazon Web Services SaaS Marketplace.
        /// </para>
        /// </summary>
        public string CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }

        // Check to see if CustomerId property is set
        internal bool IsSetCustomerId()
        {
            return this._customerId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ApiKey.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the ApiKey can be used by callers.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GenerateDistinctId. 
        /// <para>
        /// Specifies whether (<c>true</c>) or not (<c>false</c>) the key identifier is distinct
        /// from the created API key value. This parameter is deprecated and should not be used.
        /// </para>
        /// </summary>
        public bool? GenerateDistinctId
        {
            get { return this._generateDistinctId; }
            set { this._generateDistinctId = value; }
        }

        // Check to see if GenerateDistinctId property is set
        internal bool IsSetGenerateDistinctId()
        {
            return this._generateDistinctId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ApiKey.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StageKeys. 
        /// <para>
        /// DEPRECATED FOR USAGE PLANS - Specifies stages associated with the API key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StageKey> StageKeys
        {
            get { return this._stageKeys; }
            set { this._stageKeys = value; }
        }

        // Check to see if StageKeys property is set
        internal bool IsSetStageKeys()
        {
            return this._stageKeys != null && (this._stageKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/]. The tag
        /// key can be up to 128 characters and must not start with <c>aws:</c>. The tag value
        /// can be up to 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specifies a value of the API key.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}