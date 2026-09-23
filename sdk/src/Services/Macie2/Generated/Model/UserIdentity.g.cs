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
    /// Provides information about the type and other characteristics of an entity that performed
    /// an action on an affected resource.
    /// </summary>
    public partial class UserIdentity
    {
        /// <summary>
        /// Gets and sets the property AssumedRole. 
        /// <para>
        /// If the action was performed with temporary security credentials that were obtained
        /// using the AssumeRole operation of the Security Token Service (STS) API, the identifiers,
        /// session context, and other details about the identity.
        /// </para>
        /// </summary>
        public AssumedRole AssumedRole { get; set; }

        /// <summary>
        /// Checks to see if the AssumedRole property is set.
        /// </summary>
        internal bool IsSetAssumedRole() => this.AssumedRole != null;

        /// <summary>
        /// Gets and sets the property AwsAccount. 
        /// <para>
        /// If the action was performed using the credentials for another Amazon Web Services
        /// account, the details of that account.
        /// </para>
        /// </summary>
        public AwsAccount AwsAccount { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccount property is set.
        /// </summary>
        internal bool IsSetAwsAccount() => this.AwsAccount != null;

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// If the action was performed by an Amazon Web Services account that belongs to an Amazon
        /// Web Services service, the name of the service.
        /// </para>
        /// </summary>
        public AwsService AwsService { get; set; }

        /// <summary>
        /// Checks to see if the AwsService property is set.
        /// </summary>
        internal bool IsSetAwsService() => this.AwsService != null;

        /// <summary>
        /// Gets and sets the property FederatedUser. 
        /// <para>
        /// If the action was performed with temporary security credentials that were obtained
        /// using the GetFederationToken operation of the Security Token Service (STS) API, the
        /// identifiers, session context, and other details about the identity.
        /// </para>
        /// </summary>
        public FederatedUser FederatedUser { get; set; }

        /// <summary>
        /// Checks to see if the FederatedUser property is set.
        /// </summary>
        internal bool IsSetFederatedUser() => this.FederatedUser != null;

        /// <summary>
        /// Gets and sets the property IamUser. 
        /// <para>
        /// If the action was performed using the credentials for an Identity and Access Management
        /// (IAM) user, the name and other details about the user.
        /// </para>
        /// </summary>
        public IamUser IamUser { get; set; }

        /// <summary>
        /// Checks to see if the IamUser property is set.
        /// </summary>
        internal bool IsSetIamUser() => this.IamUser != null;

        /// <summary>
        /// Gets and sets the property Root. 
        /// <para>
        /// If the action was performed using the credentials for your Amazon Web Services account,
        /// the details of your account.
        /// </para>
        /// </summary>
        public UserIdentityRoot Root { get; set; }

        /// <summary>
        /// Checks to see if the Root property is set.
        /// </summary>
        internal bool IsSetRoot() => this.Root != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entity that performed the action.
        /// </para>
        /// </summary>
        public UserIdentityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
