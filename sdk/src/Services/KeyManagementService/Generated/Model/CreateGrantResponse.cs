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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the CreateGrant operation.
    /// </summary>
    public partial class CreateGrantResponse : AmazonWebServiceResponse
    {
        private string _grantId;
        private string _grantToken;

        /// <summary>
        /// Gets and sets the property GrantId. 
        /// <para>
        /// The unique identifier for the grant.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>GrantId</code> in a subsequent <a>RetireGrant</a> or <a>RevokeGrant</a>
        /// operation.
        /// </para>
        /// </summary>
        public string GrantId
        {
            get { return this._grantId; }
            set { this._grantId = value; }
        }

        // Check to see if GrantId property is set
        internal bool IsSetGrantId()
        {
            return this._grantId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantToken. 
        /// <para>
        /// The grant token.
        /// </para>
        ///  
        /// <para>
        /// For more information about using grant tokens, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>. 
        /// </para>
        /// </summary>
        public string GrantToken
        {
            get { return this._grantToken; }
            set { this._grantToken = value; }
        }

        // Check to see if GrantToken property is set
        internal bool IsSetGrantToken()
        {
            return this._grantToken != null;
        }

    }
}