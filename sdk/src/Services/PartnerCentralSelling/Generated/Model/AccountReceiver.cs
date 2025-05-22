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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Contains the account details of the partner who received the Engagement Invitation,
    /// including the AWS account ID and company name.
    /// </summary>
    public partial class AccountReceiver
    {
        private string _alias;
        private string _awsAccountId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Represents the alias of the partner account receiving the Engagement Invitation, making
        /// it easier to identify and track the recipient in reports or logs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=80)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// Indicates the AWS account ID of the partner who received the Engagement Invitation.
        /// This is a unique identifier for managing engagements with specific AWS accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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

    }
}