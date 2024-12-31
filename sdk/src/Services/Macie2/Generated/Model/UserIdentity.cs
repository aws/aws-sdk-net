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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
    /// Provides information about the type and other characteristics of an entity that performed
    /// an action on an affected resource.
    /// </summary>
    public partial class UserIdentity
    {
        private AssumedRole _assumedRole;
        private AwsAccount _awsAccount;
        private AwsService _awsService;
        private FederatedUser _federatedUser;
        private IamUser _iamUser;
        private UserIdentityRoot _root;
        private UserIdentityType _type;

        /// <summary>
        /// Gets and sets the property AssumedRole. 
        /// <para>
        /// If the action was performed with temporary security credentials that were obtained
        /// using the AssumeRole operation of the Security Token Service (STS) API, the identifiers,
        /// session context, and other details about the identity.
        /// </para>
        /// </summary>
        public AssumedRole AssumedRole
        {
            get { return this._assumedRole; }
            set { this._assumedRole = value; }
        }

        // Check to see if AssumedRole property is set
        internal bool IsSetAssumedRole()
        {
            return this._assumedRole != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccount. 
        /// <para>
        /// If the action was performed using the credentials for another Amazon Web Services
        /// account, the details of that account.
        /// </para>
        /// </summary>
        public AwsAccount AwsAccount
        {
            get { return this._awsAccount; }
            set { this._awsAccount = value; }
        }

        // Check to see if AwsAccount property is set
        internal bool IsSetAwsAccount()
        {
            return this._awsAccount != null;
        }

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// If the action was performed by an Amazon Web Services account that belongs to an Amazon
        /// Web Services service, the name of the service.
        /// </para>
        /// </summary>
        public AwsService AwsService
        {
            get { return this._awsService; }
            set { this._awsService = value; }
        }

        // Check to see if AwsService property is set
        internal bool IsSetAwsService()
        {
            return this._awsService != null;
        }

        /// <summary>
        /// Gets and sets the property FederatedUser. 
        /// <para>
        /// If the action was performed with temporary security credentials that were obtained
        /// using the GetFederationToken operation of the Security Token Service (STS) API, the
        /// identifiers, session context, and other details about the identity.
        /// </para>
        /// </summary>
        public FederatedUser FederatedUser
        {
            get { return this._federatedUser; }
            set { this._federatedUser = value; }
        }

        // Check to see if FederatedUser property is set
        internal bool IsSetFederatedUser()
        {
            return this._federatedUser != null;
        }

        /// <summary>
        /// Gets and sets the property IamUser. 
        /// <para>
        /// If the action was performed using the credentials for an Identity and Access Management
        /// (IAM) user, the name and other details about the user.
        /// </para>
        /// </summary>
        public IamUser IamUser
        {
            get { return this._iamUser; }
            set { this._iamUser = value; }
        }

        // Check to see if IamUser property is set
        internal bool IsSetIamUser()
        {
            return this._iamUser != null;
        }

        /// <summary>
        /// Gets and sets the property Root. 
        /// <para>
        /// If the action was performed using the credentials for your Amazon Web Services account,
        /// the details of your account.
        /// </para>
        /// </summary>
        public UserIdentityRoot Root
        {
            get { return this._root; }
            set { this._root = value; }
        }

        // Check to see if Root property is set
        internal bool IsSetRoot()
        {
            return this._root != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entity that performed the action.
        /// </para>
        /// </summary>
        public UserIdentityType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}