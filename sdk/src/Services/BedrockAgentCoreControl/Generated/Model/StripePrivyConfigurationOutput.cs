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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Stripe Privy configuration output with secret ARNs.
    /// </summary>
    public partial class StripePrivyConfigurationOutput
    {
        private string _appId;
        private Secret _appSecretArn;
        private string _authorizationId;
        private Secret _authorizationPrivateKeyArn;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID provided by Privy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AppSecretArn.
        /// </summary>
        [AWSProperty(Required=true)]
        public Secret AppSecretArn
        {
            get { return this._appSecretArn; }
            set { this._appSecretArn = value; }
        }

        // Check to see if AppSecretArn property is set
        internal bool IsSetAppSecretArn()
        {
            return this._appSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationId. 
        /// <para>
        /// The authorization ID for the Stripe Privy integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AuthorizationId
        {
            get { return this._authorizationId; }
            set { this._authorizationId = value; }
        }

        // Check to see if AuthorizationId property is set
        internal bool IsSetAuthorizationId()
        {
            return this._authorizationId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKeyArn.
        /// </summary>
        [AWSProperty(Required=true)]
        public Secret AuthorizationPrivateKeyArn
        {
            get { return this._authorizationPrivateKeyArn; }
            set { this._authorizationPrivateKeyArn = value; }
        }

        // Check to see if AuthorizationPrivateKeyArn property is set
        internal bool IsSetAuthorizationPrivateKeyArn()
        {
            return this._authorizationPrivateKeyArn != null;
        }

    }
}