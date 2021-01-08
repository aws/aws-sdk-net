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
    /// Attaches one or more tags, each consisting of a key name and a value, to the specified
    /// secret. Tags are part of the secret's overall metadata, and are not associated with
    /// any specific version of the secret. This operation only appends tags to the existing
    /// list of tags. To remove tags, you must use <a>UntagResource</a>.
    /// 
    ///  
    /// <para>
    /// The following basic restrictions apply to tags:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Maximum number of tags per secret—50
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Maximum key length—127 Unicode characters in UTF-8
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Maximum value length—255 Unicode characters in UTF-8
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tag keys and values are case sensitive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Do not use the <code>aws:</code> prefix in your tag names or values because AWS reserves
    /// it for AWS use. You can't edit or delete tag names or values with this prefix. Tags
    /// with this prefix do not count against your tags per secret limit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use your tagging schema across multiple services and resources, remember other
    /// services might have restrictions on allowed characters. Generally allowed characters:
    /// letters, spaces, and numbers representable in UTF-8, plus the following special characters:
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
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:TagResource
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To remove one or more tags from the collection attached to a secret, use <a>UntagResource</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To view the list of tags attached to a secret, use <a>DescribeSecret</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TagResourceRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The identifier for the secret that you want to attach tags to. You can specify either
        /// the Amazon Resource Name (ARN) or the friendly name of the secret.
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
        /// The tags to attach to the secret. Each element in the list consists of a <code>Key</code>
        /// and a <code>Value</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter to the API requires a JSON text string argument. For information on
        /// how to format a JSON parameter for the various command line tool environments, see
        /// <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a> in the <i>AWS CLI User Guide</i>. For the AWS CLI, you can
        /// also use the syntax: <code>--Tags Key="Key1",Value="Value1",Key="Key2",Value="Value2"[,…]</code>
        /// 
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