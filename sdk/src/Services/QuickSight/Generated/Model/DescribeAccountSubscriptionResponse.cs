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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountSubscription operation.
    /// </summary>
    public partial class DescribeAccountSubscriptionResponse : AmazonWebServiceResponse
    {
        private AccountInfo _accountInfo;
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property AccountInfo. 
        /// <para>
        /// A structure that contains the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your QuickSight account name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The edition of QuickSight that your account is using.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The notification email address that is associated with the QuickSight account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The authentication type of the QuickSight account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The status of the QuickSight account's subscription.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AccountInfo AccountInfo
        {
            get { return this._accountInfo; }
            set { this._accountInfo = value; }
        }

        // Check to see if AccountInfo property is set
        internal bool IsSetAccountInfo()
        {
            return this._accountInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}