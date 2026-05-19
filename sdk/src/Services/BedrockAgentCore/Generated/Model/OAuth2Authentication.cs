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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// OAuth2 authentication information for third-party providers.
    /// </summary>
    public partial class OAuth2Authentication
    {
        private string _emailAddress;
        private string _name;
        private string _sub;
        private string _username;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address from the OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=254)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user's name from the OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Sub. 
        /// <para>
        /// The subject (sub) claim from the OAuth2 provider. Uniquely identifies the user at
        /// the provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Sub
        {
            get { return this._sub; }
            set { this._sub = value; }
        }

        // Check to see if Sub property is set
        internal bool IsSetSub()
        {
            return this._sub != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username from the OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}