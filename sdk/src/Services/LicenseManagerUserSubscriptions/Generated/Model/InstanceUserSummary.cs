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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
        private string _associationDate;
        private string _disassociationDate;
        private string _domain;
        private IdentityProvider _identityProvider;
        private string _instanceId;
        private string _instanceUserArn;
        private string _status;
        private string _statusMessage;
        private string _username;

        /// <summary>
        /// Gets and sets the property AssociationDate. 
        /// <para>
        /// The date a user was associated with an EC2 instance.
        /// </para>
        /// </summary>
        public string AssociationDate
        {
            get { return this._associationDate; }
            set { this._associationDate = value; }
        }

        // Check to see if AssociationDate property is set
        internal bool IsSetAssociationDate()
        {
            return this._associationDate != null;
        }

        /// <summary>
        /// Gets and sets the property DisassociationDate. 
        /// <para>
        /// The date a user was disassociated from an EC2 instance.
        /// </para>
        /// </summary>
        public string DisassociationDate
        {
            get { return this._disassociationDate; }
            set { this._disassociationDate = value; }
        }

        // Check to see if DisassociationDate property is set
        internal bool IsSetDisassociationDate()
        {
            return this._disassociationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name of the Active Directory that contains the user information for the
        /// product subscription.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// The <c>IdentityProvider</c> resource specifies details about the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityProvider IdentityProvider
        {
            get { return this._identityProvider; }
            set { this._identityProvider = value; }
        }

        // Check to see if IdentityProvider property is set
        internal bool IsSetIdentityProvider()
        {
            return this._identityProvider != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the EC2 instance that provides user-based subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceUserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the instance user.
        /// </para>
        /// </summary>
        public string InstanceUserArn
        {
            get { return this._instanceUserArn; }
            set { this._instanceUserArn = value; }
        }

        // Check to see if InstanceUserArn property is set
        internal bool IsSetInstanceUserArn()
        {
            return this._instanceUserArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a user associated with an EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for users of an EC2 instance.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name from the identity provider for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}