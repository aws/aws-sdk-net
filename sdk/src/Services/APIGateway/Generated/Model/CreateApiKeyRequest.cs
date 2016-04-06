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
    /// </summary>
    public partial class CreateApiKeyRequest : AmazonAPIGatewayRequest
    {
        private string _description;
        private bool? _enabled;
        private string _name;
        private List<StageKey> _stageKeys = new List<StageKey>();

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
        /// Specifies whether the <a>ApiKey</a> can be used by callers.
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

    }
}