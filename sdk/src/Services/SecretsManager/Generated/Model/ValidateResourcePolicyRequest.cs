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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateResourcePolicy operation.
    /// Validates that the resource policy does not grant a wide range of IAM principals access
    /// to your secret. The JSON request string input and response output displays formatted
    /// code with white space and line breaks for better readability. Submit your input as
    /// a single line JSON string. A resource-based policy is optional for secrets.
    /// 
    ///  
    /// <para>
    /// The API performs three checks when validating the secret:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Sends a call to <a href="https://aws.amazon.com/blogs/security/protect-sensitive-data-in-the-cloud-with-automated-reasoning-zelkova/">Zelkova</a>,
    /// an automated reasoning engine, to ensure your Resource Policy does not allow broad
    /// access to your secret.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Checks for correct syntax in a policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Verifies the policy does not lock out a caller.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Minimum Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// You must have the permissions required to access the following APIs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>secretsmanager:PutResourcePolicy</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>secretsmanager:ValidateResourcePolicy</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ValidateResourcePolicyRequest : AmazonSecretsManagerRequest
    {
        private string _resourcePolicy;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// A JSON-formatted string constructed according to the grammar and syntax for an Amazon
        /// Web Services resource-based policy. The policy in the string identifies who can access
        /// or manage this secret and its versions. For information on how to format a JSON parameter
        /// for the various command line tool environments, see <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a> in the <i>CLI User Guide</i>.publi
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20480)]
        public string ResourcePolicy
        {
            get { return this._resourcePolicy; }
            set { this._resourcePolicy = value; }
        }

        // Check to see if ResourcePolicy property is set
        internal bool IsSetResourcePolicy()
        {
            return this._resourcePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        ///  (Optional) The identifier of the secret with the resource-based policy you want to
        /// validate. You can specify either the Amazon Resource Name (ARN) or the friendly name
        /// of the secret.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify an ARN, we generally recommend that you specify a complete ARN. You
        /// can specify a partial ARN too—for example, if you don’t include the final hyphen and
        /// six random characters that Secrets Manager adds at the end of the ARN when you created
        /// the secret. A partial ARN match can work as long as it uniquely matches only one secret.
        /// However, if your secret has a name that ends in a hyphen followed by six characters
        /// (before Secrets Manager adds the hyphen and six characters to the ARN) and you try
        /// to use that as a partial ARN, then those characters cause Secrets Manager to assume
        /// that you’re specifying a complete ARN. This confusion can cause unexpected results.
        /// To avoid this situation, we recommend that you don’t create secret names ending with
        /// a hyphen followed by six characters.
        /// </para>
        ///  
        /// <para>
        /// If you specify an incomplete ARN without the random suffix, and instead provide the
        /// 'friendly name', you <i>must</i> not include the random suffix. If you do include
        /// the random suffix added by Secrets Manager, you receive either a <i>ResourceNotFoundException</i>
        /// or an <i>AccessDeniedException</i> error, depending on your permissions.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

    }
}