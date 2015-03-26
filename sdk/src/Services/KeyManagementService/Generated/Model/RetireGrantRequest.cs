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
    /// Retires a grant. You can retire a grant when you're done using it to clean up. You
    /// should revoke a grant when you intend to actively deny operations that depend on it.
    /// </summary>
    public partial class RetireGrantRequest : AmazonKeyManagementServiceRequest
    {
        private string _grantToken;

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

    }
}