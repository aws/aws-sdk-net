/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The Amazon Chime account details. An AWS account can have multiple Amazon Chime accounts.
    /// </summary>
    public partial class Account
    {
        private string _accountId;
        private AccountType _accountType;
        private string _awsAccountId;
        private DateTime? _createdTimestamp;
        private License _defaultLicense;
        private string _name;
        private List<string> _supportedLicenses = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// The Amazon Chime account type. For more information about different account types,
        /// see <a href="http://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </para>
        /// </summary>
        public AccountType AccountType
        {
            get { return this._accountType; }
            set { this._accountType = value; }
        }

        // Check to see if AccountType property is set
        internal bool IsSetAccountType()
        {
            return this._accountType != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The Amazon Chime account creation timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultLicense. 
        /// <para>
        /// The default license for the Amazon Chime account.
        /// </para>
        /// </summary>
        public License DefaultLicense
        {
            get { return this._defaultLicense; }
            set { this._defaultLicense = value; }
        }

        // Check to see if DefaultLicense property is set
        internal bool IsSetDefaultLicense()
        {
            return this._defaultLicense != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Amazon Chime account name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedLicenses. 
        /// <para>
        /// Supported licenses for the Amazon Chime account.
        /// </para>
        /// </summary>
        public List<string> SupportedLicenses
        {
            get { return this._supportedLicenses; }
            set { this._supportedLicenses = value; }
        }

        // Check to see if SupportedLicenses property is set
        internal bool IsSetSupportedLicenses()
        {
            return this._supportedLicenses != null && this._supportedLicenses.Count > 0; 
        }

    }
}