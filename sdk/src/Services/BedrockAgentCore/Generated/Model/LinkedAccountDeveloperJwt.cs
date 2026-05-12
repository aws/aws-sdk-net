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
    /// Authentication method using JWT with key ID and subject claims.
    /// </summary>
    public partial class LinkedAccountDeveloperJwt
    {
        private string _kid;
        private string _sub;

        /// <summary>
        /// Gets and sets the property Kid. 
        /// <para>
        /// The key ID (kid) from the JWT header. Identifies which key was used to sign the JWT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Kid
        {
            get { return this._kid; }
            set { this._kid = value; }
        }

        // Check to see if Kid property is set
        internal bool IsSetKid()
        {
            return this._kid != null;
        }

        /// <summary>
        /// Gets and sets the property Sub. 
        /// <para>
        /// The subject (sub) claim from the JWT payload. Identifies the principal that is the
        /// subject of the JWT.
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

    }
}