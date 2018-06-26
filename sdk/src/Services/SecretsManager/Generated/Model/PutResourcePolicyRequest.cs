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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Attaches the contents of the specified resource-based policy to a secret. A resource-based
    /// policy is optional. Alternatively, you can use IAM user-based policies that specify
    /// the secret's ARN in the policy statement's <code>Resources</code> element. You can
    /// also use a combination of both identity- an resource-based policies. The affected
    /// users and roles receive the permissions permitted by all of the relevant policies.
    /// For more information, see <a href="http://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_resource-based-policies.html">Using
    /// Resource-Based Policies for AWS Secrets Manager</a>. For the complete description
    /// of the AWS policy syntax and grammar, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
    /// JSON Policy Reference</a> in the <i>IAM User Guide</i>.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:PutResourcePolicy
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To retrieve the resource policy attached to a secret, use <a>GetResourcePolicy</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To delete the resource-based policy that is attached to a secret, use <a>DeleteResourcePolicy</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To list all of the currently available secrets, use <a>ListSecrets</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonSecretsManagerRequest
    {
        private string _resourcePolicy;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// A JSON-formatted string constructed according to the grammar and syntax for an AWS
        /// resource-based policy. The policy in the string identifies who can access or manage
        /// this secret and its versions. For information on how to format a JSON parameter for
        /// the various command line tool environments, see <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a> in the <i>AWS CLI User Guide</i>.
        /// </para>
        /// </summary>
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
        /// Specifies the secret to which you want to attach the resource-based policy. You can
        /// specify either the Amazon Resource Name (ARN) or the friendly name of the secret.
        /// </para>
        /// </summary>
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