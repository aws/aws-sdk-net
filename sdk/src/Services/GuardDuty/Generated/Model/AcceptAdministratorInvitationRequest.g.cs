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
    /// Container for the parameters to the AcceptAdministratorInvitation operation. Accepts
    /// the invitation to be a member account and get monitored by a GuardDuty administrator
    /// account that sent the invitation.
    /// </summary>
    public partial class AcceptAdministratorInvitationRequest : AmazonGuardDutyRequest
    {
        /// <summary>
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The account ID of the GuardDuty administrator account whose invitation you're accepting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AdministratorId { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorId property is set.
        /// </summary>
        internal bool IsSetAdministratorId() => this.AdministratorId != null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector of the GuardDuty member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The value that is used to validate the administrator account to the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvitationId { get; set; }

        /// <summary>
        /// Checks to see if the InvitationId property is set.
        /// </summary>
        internal bool IsSetInvitationId() => this.InvitationId != null;
    }
}
