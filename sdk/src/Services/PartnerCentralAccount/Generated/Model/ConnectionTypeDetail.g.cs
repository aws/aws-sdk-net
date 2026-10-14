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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Detailed information about a specific connection type within a connection.
    /// </summary>
    public partial class ConnectionTypeDetail
    {
        /// <summary>
        /// Gets and sets the property CanceledAt. 
        /// <para>
        /// The timestamp when this connection type was cancelled, if applicable.
        /// </para>
        /// </summary>
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Checks to see if the CanceledAt property is set.
        /// </summary>
        internal bool IsSetCanceledAt() => this.CanceledAt.HasValue;

        /// <summary>
        /// Gets and sets the property CanceledBy. 
        /// <para>
        /// The AWS account ID of the participant who cancelled this connection type.
        /// </para>
        /// </summary>
        public string CanceledBy { get; set; }

        /// <summary>
        /// Checks to see if the CanceledBy property is set.
        /// </summary>
        internal bool IsSetCanceledBy() => this.CanceledBy != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when this connection type was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InviterEmail. 
        /// <para>
        /// The email address of the person who initiated this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 320)]
        public string InviterEmail { get; set; }

        /// <summary>
        /// Checks to see if the InviterEmail property is set.
        /// </summary>
        internal bool IsSetInviterEmail() => this.InviterEmail != null;

        /// <summary>
        /// Gets and sets the property InviterName. 
        /// <para>
        /// The name of the person who initiated this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 80)]
        public string InviterName { get; set; }

        /// <summary>
        /// Checks to see if the InviterName property is set.
        /// </summary>
        internal bool IsSetInviterName() => this.InviterName != null;

        /// <summary>
        /// Gets and sets the property OtherParticipant. 
        /// <para>
        /// Information about the other participant in this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Participant OtherParticipant { get; set; }

        /// <summary>
        /// Checks to see if the OtherParticipant property is set.
        /// </summary>
        internal bool IsSetOtherParticipant() => this.OtherParticipant != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionTypeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
