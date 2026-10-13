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
    /// Contains information about an Amazon Web Services account that is a member of an organization.
    /// </summary>
    public partial class Account
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsorganizations.html#awsorganizations-resources-for-iam-policies">ARN
        /// Formats Supported by Organizations</a> in the <i>Amazon Web Services Service Authorization
        /// Reference</i>.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address associated with the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter
        /// is a string of characters that represents a standard internet email address.
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
        /// The unique identifier (ID) of the account.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an account ID
        /// string requires exactly 12 digits.
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
        /// The method by which the account joined the organization.
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
        /// The date the account became a part of the organization.
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
        /// The friendly name of the account.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter is a string of any of the characters in the ASCII character range.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// The paths in the organization where the account exists.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Paths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Paths property is set.
        /// </summary>
        internal bool IsSetPaths() => this.Paths != null && (this.Paths.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The status of the account in the organization.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>Status</c> parameter in the <c>Account</c> object will be retired on September
        /// 9, 2026. Although both the account <c>State</c> and account <c>Status</c> parameters
        /// are currently available in the Organizations APIs (<c>DescribeAccount</c>, <c>ListAccounts</c>,
        /// <c>ListAccountsForParent</c>), we recommend that you update your scripts or other
        /// code to use the <c>State</c> parameter instead of <c>Status</c> before September 9,
        /// 2026.
        /// </para>
        ///  </important>
        /// </summary>
        public AccountStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
