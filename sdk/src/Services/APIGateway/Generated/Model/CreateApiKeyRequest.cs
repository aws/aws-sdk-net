/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApiKey operation.
    /// Create an <a>ApiKey</a> resource. 
    /// 
    ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/create-api-key.html">AWS
    /// CLI</a></div>
    /// </summary>
    public partial class CreateApiKeyRequest : AmazonAPIGatewayRequest
    {
        private string _customerId;
        private string _description;
        private bool? _enabled;
        private bool? _generateDistinctId;
        private string _name;
        private List<StageKey> _stageKeys = new List<StageKey>();
        private string _value;

        /// <summary>
        /// Gets and sets the property CustomerId.
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
        /// The description of the <a>ApiKey</a>.
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
        /// Specifies whether the <a>ApiKey</a> can be used by callers.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
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
        /// Specifies whether (<code>true</code>) or not (<code>false</code>) the key identifier
        /// is distinct from the created API key value.
        /// </para>
        /// </summary>
        public bool GenerateDistinctId
        {
            get { return this._generateDistinctId.GetValueOrDefault(); }
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
        /// The name of the <a>ApiKey</a>.
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
        /// </summary>
        public List<StageKey> StageKeys
        {
            get { return this._stageKeys; }
            set { this._stageKeys = value; }
        }

        // Check to see if StageKeys property is set
        internal bool IsSetStageKeys()
        {
            return this._stageKeys != null && this._stageKeys.Count > 0; 
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