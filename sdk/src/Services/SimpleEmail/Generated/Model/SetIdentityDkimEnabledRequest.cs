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
    /// Container for the parameters to the SetIdentityDkimEnabled operation.
    /// Enables or disables Easy DKIM signing of email sent from an identity. If Easy DKIM
    /// signing is enabled for a domain, then Amazon SES uses DKIM to sign all email that
    /// it sends from addresses on that domain. If Easy DKIM signing is enabled for an email
    /// address, then Amazon SES uses DKIM to sign all email it sends from that address.
    /// 
    ///  <note> 
    /// <para>
    /// For email addresses (for example, <c>user@example.com</c>), you can only enable DKIM
    /// signing if the corresponding domain (in this case, <c>example.com</c>) has been set
    /// up to use Easy DKIM.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can enable DKIM signing for an identity at any time after you start the verification
    /// process for the identity, even if the verification process isn't complete. 
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    ///  
    /// <para>
    /// For more information about Easy DKIM signing, go to the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class SetIdentityDkimEnabledRequest : AmazonSimpleEmailServiceRequest
    {
        private bool? _dkimEnabled;
        private string _identity;

        /// <summary>
        /// Gets and sets the property DkimEnabled. 
        /// <para>
        /// Sets whether DKIM signing is enabled for an identity. Set to <c>true</c> to enable
        /// DKIM signing for this identity; <c>false</c> to disable it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DkimEnabled
        {
            get { return this._dkimEnabled; }
            set { this._dkimEnabled = value; }
        }

        // Check to see if DkimEnabled property is set
        internal bool IsSetDkimEnabled()
        {
            return this._dkimEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity for which DKIM signing should be enabled or disabled.
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