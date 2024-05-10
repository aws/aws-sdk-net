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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the ListIdentityPolicies operation.
    /// Returns a list of sending authorization policies that are attached to the given identity
    /// (an email address or a domain). This operation returns only a list. To get the actual
    /// policy content, use <c>GetIdentityPolicies</c>.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is for the identity owner only. If you have not verified the identity,
    /// it returns an error.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sending authorization is a feature that enables an identity owner to authorize other
    /// senders to use its identities. For information about using sending authorization,
    /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class ListIdentityPoliciesRequest : AmazonSimpleEmailServiceRequest
    {
        private string _identity;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity that is associated with the policy for which the policies are listed.
        /// You can specify an identity by using its name or by using its Amazon Resource Name
        /// (ARN). Examples: <c>user@example.com</c>, <c>example.com</c>, <c>arn:aws:ses:us-east-1:123456789012:identity/example.com</c>.
        /// </para>
        ///  
        /// <para>
        /// To successfully call this operation, you must own the identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

    }
}