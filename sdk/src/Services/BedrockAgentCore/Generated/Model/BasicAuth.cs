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
    /// Configuration for HTTP Basic Authentication using credentials stored in Amazon Web
    /// Services Secrets Manager. The secret must contain a JSON object with <c>username</c>
    /// and <c>password</c> string fields. Username allows alphanumeric characters and <c>@._+=-</c>
    /// symbols (pattern: <c>^[a-zA-Z0-9@._+=\-]+$</c>). Password allows alphanumeric characters
    /// and <c>@._+=-!#$%&amp;*</c> symbols (pattern: <c>^[a-zA-Z0-9@._+=\-!#$%&amp;*]+$</c>).
    /// Both fields have a maximum length of 256 characters.
    /// </summary>
    public partial class BasicAuth
    {
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret containing
        /// proxy credentials. The secret must be a JSON object with <c>username</c> and <c>password</c>
        /// string fields that meet validation requirements. The caller must have <c>secretsmanager:GetSecretValue</c>
        /// permission for this ARN. Example secret format: <c>{"username": "proxy_user", "password":
        /// "secure_password"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}