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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains details for a transfer. A <i>transfer</i> is the arrangement between two
    /// management accounts where one account designates the other with specified responsibilities
    /// for their organization.
    /// </summary>
    public partial class ResponsibilityTransfer
    {
        /// <summary>
        /// Gets and sets the property ActiveHandshakeId. 
        /// <para>
        /// ID for the handshake of the transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 34)]
        public string ActiveHandshakeId { get; set; }

        /// <summary>
        /// Checks to see if the ActiveHandshakeId property is set.
        /// </summary>
        internal bool IsSetActiveHandshakeId() => this.ActiveHandshakeId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the transfer.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// Timestamp when the transfer ends.
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID for the transfer.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name assigned to the transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Account that allows another account external to its organization to manage the specified
        /// responsibilities for the organization.
        /// </para>
        /// </summary>
        public TransferParticipant Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// Timestamp when the transfer starts.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the transfer.
        /// </para>
        /// </summary>
        public ResponsibilityTransferStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Account that manages the specified responsibilities for another organization.
        /// </para>
        /// </summary>
        public TransferParticipant Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of transfer. Currently, only <c>BILLING</c> is supported.
        /// </para>
        /// </summary>
        public ResponsibilityTransferType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
