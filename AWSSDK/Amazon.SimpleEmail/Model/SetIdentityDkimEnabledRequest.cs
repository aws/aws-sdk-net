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
    /// Container for the parameters to the SetIdentityDkimEnabled operation.
    /// <para>Enables or disables Easy DKIM signing of email sent from an identity:</para>
    /// <ul>
    /// <li>If Easy DKIM signing is enabled for a domain name identity (e.g., <c>example.com</c> ), then Amazon SES will DKIM-sign all email sent
    /// by addresses under that domain name (e.g., <c>user@example.com</c> ).</li>
    /// <li>If Easy DKIM signing is enabled for an email address, then Amazon SES will DKIM-sign all email sent by that email address.</li>
    /// 
    /// </ul>
    /// <para>For email addresses (e.g., <c>user@example.com</c> ), you can only enable Easy DKIM signing if the corresponding domain (e.g.,
    /// <c>example.com</c> ) has been set up for Easy DKIM using the AWS Console or the <c>VerifyDomainDkim</c> action.</para> <para>For more
    /// information about Easy DKIM signing, go to the Amazon SES Developer Guide.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityDkimEnabled"/>
    public class SetIdentityDkimEnabledRequest : AmazonWebServiceRequest
    {
        private string identity;
        private bool? dkimEnabled;

        /// <summary>
        /// The identity for which DKIM signing should be enabled or disabled.
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
        public SetIdentityDkimEnabledRequest WithIdentity(string identity)
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
        /// Sets whether DKIM signing is enabled for an identity. Set to <c>true</c> to enable DKIM signing for this identity; <c>false</c> to disable
        /// it.
        ///  
        /// </summary>
        public bool DkimEnabled
        {
            get { return this.dkimEnabled ?? default(bool); }
            set { this.dkimEnabled = value; }
        }

        /// <summary>
        /// Sets the DkimEnabled property
        /// </summary>
        /// <param name="dkimEnabled">The value to set for the DkimEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetIdentityDkimEnabledRequest WithDkimEnabled(bool dkimEnabled)
        {
            this.dkimEnabled = dkimEnabled;
            return this;
        }
            

        // Check to see if DkimEnabled property is set
        internal bool IsSetDkimEnabled()
        {
            return this.dkimEnabled.HasValue;       
        }
    }
}
    
