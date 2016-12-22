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
    /// Container for the parameters to the RetireGrant operation.
    /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
    /// should revoke a grant when you intend to actively deny operations that depend on it.
    /// The following are permitted to call this API:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The AWS account (root user) under which the grant was created
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>RetiringPrincipal</code>, if present in the grant
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
    /// in the grant
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You must identify the grant to retire by its grant token or by a combination of the
    /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
    /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
    /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
    /// </para>
    /// </summary>
    public partial class RetireGrantRequest : AmazonKeyManagementServiceRequest
    {
        private string _grantId;
        private string _grantToken;
        private string _keyId;

        /// <summary>
        /// Gets and sets the property GrantId. 
        /// <para>
        /// Unique identifier of the grant to retire. The grant ID is returned in the response
        /// to a <code>CreateGrant</code> operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Grant ID Example - 0123456789012345678901234567890123456789012345678901234567890123
        /// </para>
        ///  </li> </ul>
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
        /// Token that identifies the grant to be retired.
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

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name of the CMK associated with the grant. Example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// arn:aws:kms:us-east-2:444455556666:key/1234abcd-12ab-34cd-56ef-1234567890ab
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

    }
}