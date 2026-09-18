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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateEmailIdentityPolicy operation. Creates the
    /// specified sending authorization policy for the given identity (an email address or
    /// a domain). <note> <para> This API is for the identity owner only. If you have not
    /// verified the identity, this API will return an error. </para> </note> <para> Sending
    /// authorization is a feature that enables an identity owner to authorize other senders
    /// to use its identities. For information about using sending authorization, see the
    /// <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
    /// SES Developer Guide</a>. </para> <para> You can execute this operation no more than
    /// once per second. </para>
    /// </summary>
    public partial class CreateEmailIdentityPolicyRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string EmailIdentity { get; set; }

        /// <summary>
        /// Checks to see if the EmailIdentity property is set.
        /// </summary>
        internal bool IsSetEmailIdentity() => this.EmailIdentity != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The text of the policy in JSON format. The policy cannot exceed 4 KB.
        /// </para>
        ///  
        /// <para>
        /// For information about the syntax of sending authorization policies, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-policies.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        ///  
        /// <para>
        /// The policy name cannot exceed 64 characters and can only include alphanumeric characters,
        /// dashes, and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
