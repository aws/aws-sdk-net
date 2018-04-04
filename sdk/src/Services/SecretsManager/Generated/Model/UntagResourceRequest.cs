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
    /// Container for the parameters to the UntagResource operation.
    /// Removes one or more tags from the specified secret.
    /// 
    ///  
    /// <para>
    /// This operation is idempotent. If a requested tag is not attached to the secret, no
    /// error is returned and the secret metadata is unchanged.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you use tags as part of your security strategy, then removing a tag can change
    /// permissions. If successfully completing this operation would result in you losing
    /// your permissions for this secret, then the operation is blocked and returns an Access
    /// Denied error.
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
    /// secretsmanager:UntagResource
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To add one or more tags to the collection attached to a secret, use <a>TagResource</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To view the list of tags attached to a secret, use <a>DescribeSecret</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UntagResourceRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The identifier for the secret that you want to remove tags from. You can specify either
        /// the Amazon Resource Name (ARN) or the friendly name of the secret.
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

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A list of tag key names to remove from the secret. You don't specify the value. Both
        /// the key and its associated value are removed.
        /// </para>
        ///  
        /// <para>
        /// This parameter to the API requires a JSON text string argument. For information on
        /// how to format a JSON parameter for the various command line tool environments, see
        /// <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a> in the <i>AWS CLI User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}