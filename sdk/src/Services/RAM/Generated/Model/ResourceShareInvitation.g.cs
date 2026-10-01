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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes an invitation for an Amazon Web Services account to join a resource share.
    /// </summary>
    public partial class ResourceShareInvitation
    {
        /// <summary>
        /// Gets and sets the property InvitationTimestamp. 
        /// <para>
        /// The date and time when the invitation was sent.
        /// </para>
        /// </summary>
        public DateTime? InvitationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the InvitationTimestamp property is set.
        /// </summary>
        internal bool IsSetInvitationTimestamp() => this.InvitationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ReceiverAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that received the invitation.
        /// </para>
        /// </summary>
        public string ReceiverAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverAccountId property is set.
        /// </summary>
        internal bool IsSetReceiverAccountId() => this.ReceiverAccountId != null;

        /// <summary>
        /// Gets and sets the property ReceiverArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the IAM user or role that received the invitation.
        /// </para>
        /// </summary>
        public string ReceiverArn { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverArn property is set.
        /// </summary>
        internal bool IsSetReceiverArn() => this.ReceiverArn != null;

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource share
        /// </para>
        /// </summary>
        public string ResourceShareArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareArn property is set.
        /// </summary>
        internal bool IsSetResourceShareArn() => this.ResourceShareArn != null;

        /// <summary>
        /// Gets and sets the property ResourceShareAssociations. 
        /// <para>
        /// To view the resources associated with a pending resource share invitation, use <a>ListPendingInvitationResources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This member has been deprecated. Use ListPendingInvitationResources.")]
        public List<ResourceShareAssociation> ResourceShareAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceShareAssociation>() : null;

        /// <summary>
        /// Checks to see if the ResourceShareAssociations property is set.
        /// </summary>
        internal bool IsSetResourceShareAssociations() => this.ResourceShareAssociations != null && (this.ResourceShareAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceShareInvitationArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the invitation.
        /// </para>
        /// </summary>
        public string ResourceShareInvitationArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareInvitationArn property is set.
        /// </summary>
        internal bool IsSetResourceShareInvitationArn() => this.ResourceShareInvitationArn != null;

        /// <summary>
        /// Gets and sets the property ResourceShareName. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareName property is set.
        /// </summary>
        internal bool IsSetResourceShareName() => this.ResourceShareName != null;

        /// <summary>
        /// Gets and sets the property SenderAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that sent the invitation.
        /// </para>
        /// </summary>
        public string SenderAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SenderAccountId property is set.
        /// </summary>
        internal bool IsSetSenderAccountId() => this.SenderAccountId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the invitation.
        /// </para>
        /// </summary>
        public ResourceShareInvitationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
