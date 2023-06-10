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
    /// Container for the parameters to the CloseAccount operation.
    /// Closes an Amazon Web Services member account within an organization. You can close
    /// an account when <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">all
    /// features are enabled </a>. You can't close the management account with this API. This
    /// is an asynchronous request that Amazon Web Services performs in the background. Because
    /// <code>CloseAccount</code> operates asynchronously, it can return a successful completion
    /// message even though account closure might still be in progress. You need to wait a
    /// few minutes before the account is fully closed. To check the status of the request,
    /// do one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Use the <code>AccountId</code> that you sent in the <code>CloseAccount</code> request
    /// to provide as a parameter to the <a>DescribeAccount</a> operation. 
    /// </para>
    ///  
    /// <para>
    /// While the close account request is in progress, Account status will indicate PENDING_CLOSURE.
    /// When the close account request completes, the status will change to SUSPENDED. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Check the CloudTrail log for the <code>CloseAccountResult</code> event that gets published
    /// after the account closes successfully. For information on using CloudTrail with Organizations,
    /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_security_incident-response.html#orgs_cloudtrail-integration">Logging
    /// and monitoring in Organizations</a> in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    /// You can close only 10% of member accounts, between 10 and 200, within a rolling 30
    /// day period. This quota is not bound by a calendar month, but starts when you close
    /// an account.
    /// </para>
    ///  
    /// <para>
    /// After you reach this limit, you can close additional accounts in the Billing console.
    /// For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/close-account.html">Closing
    /// an account</a> in the Amazon Web Services Billing and Cost Management User Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To reinstate a closed account, contact Amazon Web Services Support within the 90-day
    /// grace period while the account is in SUSPENDED status. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the Amazon Web Services account you attempt to close is linked to an Amazon Web
    /// Services GovCloud (US) account, the <code>CloseAccount</code> request will close both
    /// accounts. To learn important pre-closure details, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/Closing-govcloud-account.html">
    /// Closing an Amazon Web Services GovCloud (US) account</a> in the <i> Amazon Web Services
    /// GovCloud User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// For more information about closing accounts, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_close.html">Closing
    /// an Amazon Web Services account</a> in the <i>Organizations User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class CloseAccountRequest : AmazonOrganizationsRequest
    {
        private string _accountId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Retrieves the Amazon Web Services account Id for the current <code>CloseAccount</code>
        /// API request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=12)]
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

    }
}