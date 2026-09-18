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
    /// Contains information about the credentials used by the threat actor identified in
    /// an Amazon GuardDuty Extended Threat Detection attack sequence. GuardDuty generates
    /// an attack sequence finding when multiple events align to a potentially suspicious
    /// activity. To receive GuardDuty attack sequence findings in Security Hub CSPM, you
    /// must have GuardDuty enabled. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>.
    /// </summary>
    public partial class ActorUser
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        ///  The account of the threat actor. 
        /// </para>
        /// </summary>
        public UserAccount Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property CredentialUid. 
        /// <para>
        ///  Unique identifier of the threat actor’s user credentials. 
        /// </para>
        /// </summary>
        public string CredentialUid { get; set; }

        /// <summary>
        /// Checks to see if the CredentialUid property is set.
        /// </summary>
        internal bool IsSetCredentialUid() => this.CredentialUid != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the threat actor. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of user. 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        ///  The unique identifier of the threat actor. 
        /// </para>
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;
    }
}
