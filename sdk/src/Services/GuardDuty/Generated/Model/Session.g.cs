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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the authenticated session.
    /// </summary>
    public partial class Session
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the session was created.
        /// </para>
        ///  
        /// <para>
        /// In Amazon Web Services CloudTrail, you can find this value as <c>userIdentity.sessionContext.attributes.creationDate</c>.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// Identifier of the session issuer.
        /// </para>
        ///  
        /// <para>
        /// In Amazon Web Services CloudTrail, you can find this value as <c>userIdentity.sessionContext.sessionIssuer.arn</c>.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property MfaStatus. 
        /// <para>
        /// Indicates whether or not multi-factor authencation (MFA) was used during authentication.
        /// </para>
        ///  
        /// <para>
        /// In Amazon Web Services CloudTrail, you can find this value as <c>userIdentity.sessionContext.attributes.mfaAuthenticated</c>.
        /// </para>
        /// </summary>
        public MfaStatus MfaStatus { get; set; }

        /// <summary>
        /// Checks to see if the MfaStatus property is set.
        /// </summary>
        internal bool IsSetMfaStatus() => this.MfaStatus != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the session.
        /// </para>
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;
    }
}
