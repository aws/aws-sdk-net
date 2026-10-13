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
    /// Contains information about the delegated administrator.
    /// </summary>
    public partial class DelegatedAdministrator
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the delegated administrator's account.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DelegationEnabledDate. 
        /// <para>
        /// The date when the account was made a delegated administrator.
        /// </para>
        /// </summary>
        public DateTime? DelegationEnabledDate { get; set; }

        /// <summary>
        /// Checks to see if the DelegationEnabledDate property is set.
        /// </summary>
        internal bool IsSetDelegationEnabledDate() => this.DelegationEnabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address that is associated with the delegated administrator's Amazon Web
        /// Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 64)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of the delegated administrator's account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property JoinedMethod. 
        /// <para>
        /// The method by which the delegated administrator's account joined the organization.
        /// </para>
        /// </summary>
        public AccountJoinedMethod JoinedMethod { get; set; }

        /// <summary>
        /// Checks to see if the JoinedMethod property is set.
        /// </summary>
        internal bool IsSetJoinedMethod() => this.JoinedMethod != null;

        /// <summary>
        /// Gets and sets the property JoinedTimestamp. 
        /// <para>
        /// The date when the delegated administrator's account became a part of the organization.
        /// </para>
        /// </summary>
        public DateTime? JoinedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the JoinedTimestamp property is set.
        /// </summary>
        internal bool IsSetJoinedTimestamp() => this.JoinedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the delegated administrator's account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Each state represents a specific phase in the account lifecycle. Use this information
        /// to manage account access, automate workflows, or trigger actions based on account
        /// state changes.
        /// </para>
        ///  
        /// <para>
        /// For more information about account states and their implications, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_account_state.html">Monitor
        /// the state of your Amazon Web Services accounts </a> in the <i>Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public AccountState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the delegated administrator's account in the organization.
        /// </para>
        /// </summary>
        public AccountStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
