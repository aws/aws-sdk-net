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
    /// This is the response object from the ListSecrets operation.
    /// </summary>
    public partial class ListSecretsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SecretListEntry> _secretList = new List<SecretListEntry>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Secrets Manager includes this value if there's more output available than what is
        /// included in the current response. This can occur even when the response includes no
        /// values at all, such as when you ask for a filtered view of a long list. To get the
        /// next results, call <code>ListSecrets</code> again with this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SecretList. 
        /// <para>
        /// A list of the secrets in the account.
        /// </para>
        /// </summary>
        public List<SecretListEntry> SecretList
        {
            get { return this._secretList; }
            set { this._secretList = value; }
        }

        // Check to see if SecretList property is set
        internal bool IsSetSecretList()
        {
            return this._secretList != null && this._secretList.Count > 0; 
        }

    }
}