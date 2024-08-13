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
    /// Container for the parameters to the SetIdentityFeedbackForwardingEnabled operation.
    /// Given an identity (an email address or a domain), enables or disables whether Amazon
    /// SES forwards bounce and complaint notifications as email. Feedback forwarding can
    /// only be disabled when Amazon Simple Notification Service (Amazon SNS) topics are specified
    /// for both bounces and complaints.
    /// 
    ///  <note> 
    /// <para>
    /// Feedback forwarding does not apply to delivery notifications. Delivery notifications
    /// are only available through Amazon SNS.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    ///  
    /// <para>
    /// For more information about using notifications with Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class SetIdentityFeedbackForwardingEnabledRequest : AmazonSimpleEmailServiceRequest
    {
        private bool? _forwardingEnabled;
        private string _identity;

        /// <summary>
        /// Gets and sets the property ForwardingEnabled. 
        /// <para>
        /// Sets whether Amazon SES forwards bounce and complaint notifications as email. <c>true</c>
        /// specifies that Amazon SES forwards bounce and complaint notifications as email, in
        /// addition to any Amazon SNS topic publishing otherwise specified. <c>false</c> specifies
        /// that Amazon SES publishes bounce and complaint notifications only through Amazon SNS.
        /// This value can only be set to <c>false</c> when Amazon SNS topics are set for both
        /// <c>Bounce</c> and <c>Complaint</c> notification types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ForwardingEnabled
        {
            get { return this._forwardingEnabled; }
            set { this._forwardingEnabled = value; }
        }

        // Check to see if ForwardingEnabled property is set
        internal bool IsSetForwardingEnabled()
        {
            return this._forwardingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity for which to set bounce and complaint notification forwarding. Examples:
        /// <c>user@example.com</c>, <c>example.com</c>.
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