/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SetIdentityFeedbackForwardingEnabled operation.
    /// <para>Given an identity (email address or domain), enables or disables whether Amazon SES forwards feedback notifications as email. Feedback
    /// forwarding may only be disabled when both complaint and bounce topics are set. For more information about feedback notification, see the
    /// Amazon SES Developer Guide.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityFeedbackForwardingEnabled"/>
    public class SetIdentityFeedbackForwardingEnabledRequest : AmazonWebServiceRequest
    {
        private string identity;
        private bool? forwardingEnabled;

        /// <summary>
        /// The identity for which to set feedback notification forwarding. Examples: <c>user@example.com</c>, <c>example.com</c>.
        ///  
        /// </summary>
        public string Identity
        {
            get { return this.identity; }
            set { this.identity = value; }
        }

        /// <summary>
        /// Sets the Identity property
        /// </summary>
        /// <param name="identity">The value to set for the Identity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetIdentityFeedbackForwardingEnabledRequest WithIdentity(string identity)
        {
            this.identity = identity;
            return this;
        }
            

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this.identity != null;       
        }

        /// <summary>
        /// Sets whether Amazon SES will forward feedback notifications as email. <c>true</c> specifies that Amazon SES will forward feedback
        /// notifications as email, in addition to any Amazon SNS topic publishing otherwise specified. <c>false</c> specifies that Amazon SES will
        /// publish feedback notifications only through Amazon SNS. This value can only be set to <c>false</c> when topics are specified for both
        /// <c>Bounce</c> and <c>Complaint</c> topic types.
        ///  
        /// </summary>
        public bool ForwardingEnabled
        {
            get { return this.forwardingEnabled ?? default(bool); }
            set { this.forwardingEnabled = value; }
        }

        /// <summary>
        /// Sets the ForwardingEnabled property
        /// </summary>
        /// <param name="forwardingEnabled">The value to set for the ForwardingEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetIdentityFeedbackForwardingEnabledRequest WithForwardingEnabled(bool forwardingEnabled)
        {
            this.forwardingEnabled = forwardingEnabled;
            return this;
        }
            

        // Check to see if ForwardingEnabled property is set
        internal bool IsSetForwardingEnabled()
        {
            return this.forwardingEnabled.HasValue;       
        }
    }
}
    
