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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The Amazon Chime account details. An AWS account can have multiple Amazon Chime accounts.
    /// </summary>
    public partial class Account
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountStatus. 
        /// <para>
        /// The status of the account.
        /// </para>
        /// </summary>
        public AccountStatus AccountStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountStatus property is set.
        /// </summary>
        internal bool IsSetAccountStatus() => this.AccountStatus != null;

        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// The Amazon Chime account type. For more information about different account types,
        /// see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </para>
        /// </summary>
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Checks to see if the AccountType property is set.
        /// </summary>
        internal bool IsSetAccountType() => this.AccountType != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The Amazon Chime account creation timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultLicense. 
        /// <para>
        /// The default license for the Amazon Chime account.
        /// </para>
        /// </summary>
        public License DefaultLicense { get; set; }

        /// <summary>
        /// Checks to see if the DefaultLicense property is set.
        /// </summary>
        internal bool IsSetDefaultLicense() => this.DefaultLicense != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Amazon Chime account name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SigninDelegateGroups. 
        /// <para>
        /// The sign-in delegate groups associated with the account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SigninDelegateGroup> SigninDelegateGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<SigninDelegateGroup>() : null;

        /// <summary>
        /// Checks to see if the SigninDelegateGroups property is set.
        /// </summary>
        internal bool IsSetSigninDelegateGroups() => this.SigninDelegateGroups != null && (this.SigninDelegateGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedLicenses. 
        /// <para>
        /// Supported licenses for the Amazon Chime account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedLicenses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedLicenses property is set.
        /// </summary>
        internal bool IsSetSupportedLicenses() => this.SupportedLicenses != null && (this.SupportedLicenses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
