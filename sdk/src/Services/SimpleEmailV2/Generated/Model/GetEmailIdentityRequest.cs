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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetEmailIdentity operation.
    /// Provides information about a specific identity, including the identity's verification
    /// status, sending authorization policies, its DKIM authentication status, and its custom
    /// Mail-From settings.
    /// </summary>
    public partial class GetEmailIdentityRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _emailIdentity;

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string EmailIdentity
        {
            get { return this._emailIdentity; }
            set { this._emailIdentity = value; }
        }

        // Check to see if EmailIdentity property is set
        internal bool IsSetEmailIdentity()
        {
            return this._emailIdentity != null;
        }

    }
}