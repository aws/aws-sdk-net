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
    /// This is the response object from the ListSecretVersionIds operation.
    /// </summary>
    public partial class ListSecretVersionIdsResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _name;
        private string _nextToken;
        private List<SecretVersionsListEntry> _versions = new List<SecretVersionsListEntry>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the secret.
        /// </para>
        ///  <note> 
        /// <para>
        /// Secrets Manager automatically adds several random characters to the name at the end
        /// of the ARN when you initially create a secret. This affects only the ARN and not the
        /// actual friendly name. This ensures that if you create a new secret with the same name
        /// as an old secret that you previously deleted, then users with access to the old secret
        /// <i>don't</i> automatically get access to the new secret because the ARNs are different.
        /// </para>
        ///  </note>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the secret.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present in the response, this value indicates that there's more output available
        /// than what's included in the current response. This can occur even when the response
        /// includes no values at all, such as when you ask for a filtered view of a very long
        /// list. Use this value in the <code>NextToken</code> request parameter in a subsequent
        /// call to the operation to continue processing and get the next part of the output.
        /// You should repeat this until the <code>NextToken</code> response element comes back
        /// empty (as <code>null</code>).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Versions. 
        /// <para>
        /// The list of the currently available versions of the specified secret.
        /// </para>
        /// </summary>
        public List<SecretVersionsListEntry> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && this._versions.Count > 0; 
        }

    }
}