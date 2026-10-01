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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptInvitation operation. Accepts an Amazon
    /// Macie membership invitation that was received from a specific account.
    /// </summary>
    public partial class AcceptInvitationRequest : AmazonMacie2Request
    {
        /// <summary>
        /// Gets and sets the property AdministratorAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the account that sent the invitation.
        /// </para>
        /// </summary>
        public string AdministratorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorAccountId property is set.
        /// </summary>
        internal bool IsSetAdministratorAccountId() => this.AdministratorAccountId != null;

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The unique identifier for the invitation to accept.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvitationId { get; set; }

        /// <summary>
        /// Checks to see if the InvitationId property is set.
        /// </summary>
        internal bool IsSetInvitationId() => this.InvitationId != null;

        /// <summary>
        /// Gets and sets the property MasterAccount. 
        /// <para>
        /// (Deprecated) The Amazon Web Services account ID for the account that sent the invitation.
        /// This property has been replaced by the administratorAccountId property and is retained
        /// only for backward compatibility.
        /// </para>
        /// </summary>
        public string MasterAccount { get; set; }

        /// <summary>
        /// Checks to see if the MasterAccount property is set.
        /// </summary>
        internal bool IsSetMasterAccount() => this.MasterAccount != null;
    }
}
