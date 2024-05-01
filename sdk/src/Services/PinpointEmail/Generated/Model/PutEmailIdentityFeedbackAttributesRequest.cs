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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the PutEmailIdentityFeedbackAttributes operation.
    /// Used to enable or disable feedback forwarding for an identity. This setting determines
    /// what happens when an identity is used to send an email that results in a bounce or
    /// complaint event.
    /// 
    ///  
    /// <para>
    /// When you enable feedback forwarding, Amazon Pinpoint sends you email notifications
    /// when bounce or complaint events occur. Amazon Pinpoint sends this notification to
    /// the address that you specified in the Return-Path header of the original email.
    /// </para>
    ///  
    /// <para>
    /// When you disable feedback forwarding, Amazon Pinpoint sends notifications through
    /// other mechanisms, such as by notifying an Amazon SNS topic. You're required to have
    /// a method of tracking bounces and complaints. If you haven't set up another mechanism
    /// for receiving bounce or complaint notifications, Amazon Pinpoint sends an email notification
    /// when these events occur (even if this setting is disabled).
    /// </para>
    /// </summary>
    public partial class PutEmailIdentityFeedbackAttributesRequest : AmazonPinpointEmailRequest
    {
        private bool? _emailForwardingEnabled;
        private string _emailIdentity;

        /// <summary>
        /// Gets and sets the property EmailForwardingEnabled. 
        /// <para>
        /// Sets the feedback forwarding configuration for the identity.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>true</c>, Amazon Pinpoint sends you email notifications when bounce
        /// or complaint events occur. Amazon Pinpoint sends this notification to the address
        /// that you specified in the Return-Path header of the original email.
        /// </para>
        ///  
        /// <para>
        /// When you set this value to <c>false</c>, Amazon Pinpoint sends notifications through
        /// other mechanisms, such as by notifying an Amazon SNS topic or another event destination.
        /// You're required to have a method of tracking bounces and complaints. If you haven't
        /// set up another mechanism for receiving bounce or complaint notifications, Amazon Pinpoint
        /// sends an email notification when these events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        public bool? EmailForwardingEnabled
        {
            get { return this._emailForwardingEnabled; }
            set { this._emailForwardingEnabled = value; }
        }

        // Check to see if EmailForwardingEnabled property is set
        internal bool IsSetEmailForwardingEnabled()
        {
            return this._emailForwardingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email identity that you want to configure bounce and complaint feedback forwarding
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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