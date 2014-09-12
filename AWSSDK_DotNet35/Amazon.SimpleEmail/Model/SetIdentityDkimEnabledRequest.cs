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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
    /// Container for the parameters to the SetIdentityDkimEnabled operation.
    /// Enables or disables Easy DKIM signing of email sent from an identity:
    /// 
    ///             <ul>                <li>If Easy DKIM            signing is enabled for
    /// a domain name identity (e.g., <code>example.com</code>), then Amazon SES will DKIM-sign
    ///            all email sent by addresses under that domain name (e.g.,             
    ///       <code>user@example.com</code>).</li>                <li>If Easy DKIM signing
    /// is enabled for an email address, then Amazon SES will DKIM-sign            all email
    /// sent by that email address.</li>            </ul>        
    /// <para>
    /// For email addresses (e.g., <code>user@example.com</code>), you can only enable Easy
    /// DKIM signing  if the        corresponding domain (e.g., <code>example.com</code>)
    /// has been set up for Easy DKIM using the AWS Console or             the <code>VerifyDomainDkim</code>
    /// action.
    /// </para>
    ///         
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    ///         
    /// <para>
    /// For more information about Easy DKIM signing, go to the             <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Amazon
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
        /// Sets whether DKIM signing is enabled for an identity.  Set to <code>true</code> to
        /// enable DKIM signing for this identity;             <code>false</code> to disable it.
        /// 
        /// </para>
        /// </summary>
        public bool DkimEnabled
        {
            get { return this._dkimEnabled.GetValueOrDefault(); }
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