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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a modification to the configuration of Bring Your Own License (BYOL) for
    /// the specified account.
    /// </summary>
    public partial class AccountModification
    {
        /// <summary>
        /// Gets and sets the property DedicatedTenancyManagementCidrRange. 
        /// <para>
        /// The IP address range, specified as an IPv4 CIDR block, for the management network
        /// interface used for the account.
        /// </para>
        /// </summary>
        public string DedicatedTenancyManagementCidrRange { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedTenancyManagementCidrRange property is set.
        /// </summary>
        internal bool IsSetDedicatedTenancyManagementCidrRange() => this.DedicatedTenancyManagementCidrRange != null;

        /// <summary>
        /// Gets and sets the property DedicatedTenancySupport. 
        /// <para>
        /// The status of BYOL (whether BYOL is being enabled or disabled).
        /// </para>
        /// </summary>
        public DedicatedTenancySupportResultEnum DedicatedTenancySupport { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedTenancySupport property is set.
        /// </summary>
        internal bool IsSetDedicatedTenancySupport() => this.DedicatedTenancySupport != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that is returned if the configuration of BYOL cannot be modified.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The text of the error message that is returned if the configuration of BYOL cannot
        /// be modified.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ModificationState. 
        /// <para>
        /// The state of the modification to the configuration of BYOL.
        /// </para>
        /// </summary>
        public DedicatedTenancyModificationStateEnum ModificationState { get; set; }

        /// <summary>
        /// Checks to see if the ModificationState property is set.
        /// </summary>
        internal bool IsSetModificationState() => this.ModificationState != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the modification of the BYOL configuration was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
