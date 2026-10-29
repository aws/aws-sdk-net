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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// This is the response object from the ResendContactReachabilityEmail operation.
    /// </summary>
    public partial class ResendContactReachabilityEmailResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for which you requested a confirmation email.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address for the registrant contact at the time that we sent the verification
        /// email.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 254)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property IsAlreadyVerified. 
        /// <para>
        ///  <c>True</c> if the email address for the registrant contact has already been verified,
        /// and <c>false</c> otherwise. If the email address has already been verified, we don't
        /// send another confirmation email.
        /// </para>
        /// </summary>
        public bool? IsAlreadyVerified { get; set; }

        /// <summary>
        /// Checks to see if the IsAlreadyVerified property is set.
        /// </summary>
        internal bool IsSetIsAlreadyVerified() => this.IsAlreadyVerified.HasValue;
    }
}
