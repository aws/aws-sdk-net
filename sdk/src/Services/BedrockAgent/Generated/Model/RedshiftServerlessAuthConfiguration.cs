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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Specifies configurations for authentication to a Redshift Serverless. Specify the
    /// type of authentication to use in the <c>type</c> field and include the corresponding
    /// field. If you specify IAM authentication, you don't need to include another field.
    /// </summary>
    public partial class RedshiftServerlessAuthConfiguration
    {
        private RedshiftServerlessAuthType _type;
        private string _usernamePasswordSecretArn;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of authentication to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedshiftServerlessAuthType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UsernamePasswordSecretArn. 
        /// <para>
        /// The ARN of an Secrets Manager secret for authentication.
        /// </para>
        /// </summary>
        public string UsernamePasswordSecretArn
        {
            get { return this._usernamePasswordSecretArn; }
            set { this._usernamePasswordSecretArn = value; }
        }

        // Check to see if UsernamePasswordSecretArn property is set
        internal bool IsSetUsernamePasswordSecretArn()
        {
            return this._usernamePasswordSecretArn != null;
        }

    }
}