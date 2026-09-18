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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Describes users of an EC2 instance providing user-based subscriptions.
    /// </summary>
    public partial class InstanceUserSummary
    {
        /// <summary>
        /// Gets and sets the property AssociationDate. 
        /// <para>
        /// The date a user was associated with an EC2 instance.
        /// </para>
        /// </summary>
        public string AssociationDate { get; set; }

        /// <summary>
        /// Checks to see if the AssociationDate property is set.
        /// </summary>
        internal bool IsSetAssociationDate() => this.AssociationDate != null;

        /// <summary>
        /// Gets and sets the property DisassociationDate. 
        /// <para>
        /// The date a user was disassociated from an EC2 instance.
        /// </para>
        /// </summary>
        public string DisassociationDate { get; set; }

        /// <summary>
        /// Checks to see if the DisassociationDate property is set.
        /// </summary>
        internal bool IsSetDisassociationDate() => this.DisassociationDate != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name of the Active Directory that contains the user information for the
        /// product subscription.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// The <c>IdentityProvider</c> resource specifies details about the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the EC2 instance that provides user-based subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceUserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the instance user.
        /// </para>
        /// </summary>
        public string InstanceUserArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceUserArn property is set.
        /// </summary>
        internal bool IsSetInstanceUserArn() => this.InstanceUserArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a user associated with an EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for users of an EC2 instance.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name from the identity provider for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
