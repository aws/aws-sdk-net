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

namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Contains detailed information about different types of handshakes.
    /// </summary>
    public partial class HandshakeDetail
    {
        /// <summary>
        /// Gets and sets the property ProgramManagementAccountHandshakeDetail. 
        /// <para>
        /// Details for a program management account handshake.
        /// </para>
        /// </summary>
        public ProgramManagementAccountHandshakeDetail ProgramManagementAccountHandshakeDetail { get; set; }

        /// <summary>
        /// Checks to see if the ProgramManagementAccountHandshakeDetail property is set.
        /// </summary>
        internal bool IsSetProgramManagementAccountHandshakeDetail() => this.ProgramManagementAccountHandshakeDetail != null;

        /// <summary>
        /// Gets and sets the property RevokeServicePeriodHandshakeDetail. 
        /// <para>
        /// Details for a revoke service period handshake.
        /// </para>
        /// </summary>
        public RevokeServicePeriodHandshakeDetail RevokeServicePeriodHandshakeDetail { get; set; }

        /// <summary>
        /// Checks to see if the RevokeServicePeriodHandshakeDetail property is set.
        /// </summary>
        internal bool IsSetRevokeServicePeriodHandshakeDetail() => this.RevokeServicePeriodHandshakeDetail != null;

        /// <summary>
        /// Gets and sets the property StartServicePeriodHandshakeDetail. 
        /// <para>
        /// Details for a start service period handshake.
        /// </para>
        /// </summary>
        public StartServicePeriodHandshakeDetail StartServicePeriodHandshakeDetail { get; set; }

        /// <summary>
        /// Checks to see if the StartServicePeriodHandshakeDetail property is set.
        /// </summary>
        internal bool IsSetStartServicePeriodHandshakeDetail() => this.StartServicePeriodHandshakeDetail != null;
    }
}
