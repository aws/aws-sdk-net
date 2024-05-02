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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableDelegatedAdminAccount operation.
    /// Enables the Amazon Inspector delegated administrator for your Organizations organization.
    /// </summary>
    public partial class EnableDelegatedAdminAccountRequest : AmazonInspector2Request
    {
        private string _clientToken;
        private string _delegatedAdminAccountId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DelegatedAdminAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the Amazon Inspector delegated administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string DelegatedAdminAccountId
        {
            get { return this._delegatedAdminAccountId; }
            set { this._delegatedAdminAccountId = value; }
        }

        // Check to see if DelegatedAdminAccountId property is set
        internal bool IsSetDelegatedAdminAccountId()
        {
            return this._delegatedAdminAccountId != null;
        }

    }
}