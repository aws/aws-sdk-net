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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about the authenticated session used by the threat actor identified
    /// in an Amazon GuardDuty Extended Threat Detection attack sequence. GuardDuty generates
    /// an attack sequence finding when multiple events align to a potentially suspicious
    /// activity. To receive GuardDuty attack sequence findings in Security Hub CSPM, you
    /// must have GuardDuty enabled. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>.
    /// </summary>
    public partial class ActorSession
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the session was created. 
        /// </para>
        ///  
        /// <para>
        /// In CloudTrail, you can find this value as <c>userIdentity.sessionContext.attributes.creationDate</c>.
        /// </para>
        /// </summary>
        public long? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        ///  The issuer of the session. 
        /// </para>
        ///  
        /// <para>
        /// In CloudTrail, you can find this value as <c>userIdentity.sessionContext.sessionIssuer.arn</c>.
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
        ///  Indicates whether multi-factor authentication (MFA) was used for authentication during
        /// the session.
        /// </para>
        ///  
        /// <para>
        /// In CloudTrail, you can find this value as <c>userIdentity.sessionContext.attributes.mfaAuthenticated</c>.
        /// </para>
        /// </summary>
        public ActorSessionMfaStatus MfaStatus { get; set; }

        /// <summary>
        /// Checks to see if the MfaStatus property is set.
        /// </summary>
        internal bool IsSetMfaStatus() => this.MfaStatus != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        ///  Unique identifier of the session. 
        /// </para>
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;
    }
}
