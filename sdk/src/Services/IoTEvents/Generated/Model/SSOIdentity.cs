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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Contains information about your identity source in AWS Single Sign-On. For more information,
    /// see the <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">AWS
    /// Single Sign-On User Guide</a>.
    /// </summary>
    public partial class SSOIdentity
    {
        private string _identityStoreId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The ID of the AWS SSO identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityStoreId
        {
            get { return this._identityStoreId; }
            set { this._identityStoreId = value; }
        }

        // Check to see if IdentityStoreId property is set
        internal bool IsSetIdentityStoreId()
        {
            return this._identityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}