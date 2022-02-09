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
    /// Container for the parameters to the TagResource operation.
    /// Attaches tags to a secret. Tags consist of a key name and a value. Tags are part of
    /// the secret's metadata. They are not associated with specific versions of the secret.
    /// This operation appends tags to the existing list of tags.
    /// 
    ///  
    /// <para>
    /// The following restrictions apply to tags:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Maximum number of tags per secret: 50
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Maximum key length: 127 Unicode characters in UTF-8
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Maximum value length: 255 Unicode characters in UTF-8
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tag keys and values are case sensitive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Do not use the <code>aws:</code> prefix in your tag names or values because Amazon
    /// Web Services reserves it for Amazon Web Services use. You can't edit or delete tag
    /// names or values with this prefix. Tags with this prefix do not count against your
    /// tags per secret limit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use your tagging schema across multiple services and resources, other services
    /// might have restrictions on allowed characters. Generally allowed characters: letters,
    /// spaces, and numbers representable in UTF-8, plus the following special characters:
    /// + - = . _ : / @.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// If you use tags as part of your security strategy, then adding or removing a tag can
    /// change permissions. If successfully completing this operation would result in you
    /// losing your permissions for this secret, then the operation is blocked and returns
    /// an Access Denied error.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Required permissions: </b> <code>secretsmanager:TagResource</code>. For more information,
    /// see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awssecretsmanager.html#awssecretsmanager-actions-as-permissions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The identifier for the secret to attach tags to. You can specify either the Amazon
        /// Resource Name (ARN) or the friendly name of the secret.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the secret as a JSON text string argument. Each element in the
        /// list consists of a <code>Key</code> and a <code>Value</code>.
        /// </para>
        ///  
        /// <para>
        /// For storing multiple values, we recommend that you use a JSON text string argument
        /// and specify key/value pairs. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters.html">Specifying
        /// parameter values for the Amazon Web Services CLI</a> in the Amazon Web Services CLI
        /// User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}