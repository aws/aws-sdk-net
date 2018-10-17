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
    /// A resource that can be distributed to callers for executing <a>Method</a> resources
    /// that require an API key. API keys can be mapped to any <a>Stage</a> on any <a>RestApi</a>,
    /// which indicates that the callers with the API key can make requests to that stage.
    /// 
    ///  <div class="seeAlso"> <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-api-keys.html">Use
    /// API Keys</a> </div>
    /// </summary>
    public partial class UpdateApiKeyResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdDate;
        private string _customerId;
        private string _description;
        private bool? _enabled;
        private string _id;
        private DateTime? _lastUpdatedDate;
        private string _name;
        private List<string> _stageKeys = new List<string>();
        private string _value;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the API Key was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// An AWS Marketplace customer identifier , when integrating with the AWS SaaS Marketplace.
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
        /// The description of the API Key.
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
        /// Specifies whether the API Key can be used by callers.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the API Key.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The timestamp when the API Key was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API Key.
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
        /// A list of <a>Stage</a> resources that are associated with the <a>ApiKey</a> resource.
        /// </para>
        /// </summary>
        public List<string> StageKeys
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
        /// The value of the API Key.
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