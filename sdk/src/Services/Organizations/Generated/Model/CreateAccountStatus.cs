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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains the status about a <a>CreateAccount</a> or <a>CreateGovCloudAccount</a> request
    /// to create an Amazon Web Services account or an Amazon Web Services GovCloud (US) account
    /// in an organization.
    /// </summary>
    public partial class CreateAccountStatus
    {
        private string _accountId;
        private string _accountName;
        private DateTime? _completedTimestamp;
        private CreateAccountFailureReason _failureReason;
        private string _govCloudAccountId;
        private string _id;
        private DateTime? _requestedTimestamp;
        private CreateAccountState _state;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// If the account was created successfully, the unique identifier (ID) of the new account.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an account ID
        /// string requires exactly 12 digits.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
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
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The account name given to the account when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        /// The date and time that the account was created and the request completed.
        /// </para>
        /// </summary>
        public DateTime CompletedTimestamp
        {
            get { return this._completedTimestamp.GetValueOrDefault(); }
            set { this._completedTimestamp = value; }
        }

        // Check to see if CompletedTimestamp property is set
        internal bool IsSetCompletedTimestamp()
        {
            return this._completedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the request failed, a description of the reason for the failure.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_LIMIT_EXCEEDED: The account couldn't be created because you reached the limit
        /// on the number of accounts in your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CONCURRENT_ACCOUNT_MODIFICATION: You already submitted a request with the same information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_ALREADY_EXISTS: The account could not be created because another Amazon Web
        /// Services account with that email address already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED_BUSINESS_VALIDATION: The Amazon Web Services account that owns your organization
        /// failed to receive business license validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GOVCLOUD_ACCOUNT_ALREADY_EXISTS: The account in the Amazon Web Services GovCloud (US)
        /// Region could not be created because this Region already includes an account with that
        /// email address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IDENTITY_INVALID_BUSINESS_VALIDATION: The Amazon Web Services account that owns your
        /// organization can't complete business license validation because it doesn't have valid
        /// identity data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ADDRESS: The account could not be created because the address you provided
        /// is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL: The account could not be created because the email address you provided
        /// is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: The Amazon Web Services account that owns your organization
        /// does not have a supported payment method associated with the account. Amazon Web Services
        /// does not support cards issued by financial institutions in Russia or Belarus. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INTERNAL_FAILURE: The account could not be created because of an internal failure.
        /// Try again later. If the problem persists, contact Amazon Web Services Customer Support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MISSING_BUSINESS_VALIDATION: The Amazon Web Services account that owns your organization
        /// has not received Business Validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  MISSING_PAYMENT_INSTRUMENT: You must configure the management account with a valid
        /// payment method, such as a credit card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_BUSINESS_VALIDATION: The Amazon Web Services account that owns your organization
        /// is still in the process of completing business license validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNKNOWN_BUSINESS_VALIDATION: The Amazon Web Services account that owns your organization
        /// has an unknown issue with business license validation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CreateAccountFailureReason FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property GovCloudAccountId. 
        /// <para>
        /// If the account was created successfully, the unique identifier (ID) of the new account
        /// in the Amazon Web Services GovCloud (US) Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
        public string GovCloudAccountId
        {
            get { return this._govCloudAccountId; }
            set { this._govCloudAccountId = value; }
        }

        // Check to see if GovCloudAccountId property is set
        internal bool IsSetGovCloudAccountId()
        {
            return this._govCloudAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) that references this request. You get this value from the
        /// response of the initial <a>CreateAccount</a> request to create the account.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a create account
        /// request ID string requires "car-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedTimestamp. 
        /// <para>
        /// The date and time that the request was made for the account creation.
        /// </para>
        /// </summary>
        public DateTime RequestedTimestamp
        {
            get { return this._requestedTimestamp.GetValueOrDefault(); }
            set { this._requestedTimestamp = value; }
        }

        // Check to see if RequestedTimestamp property is set
        internal bool IsSetRequestedTimestamp()
        {
            return this._requestedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the asynchronous request to create an Amazon Web Services account.
        /// </para>
        /// </summary>
        public CreateAccountState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}