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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeHub operation.
    /// </summary>
    public partial class DescribeHubResponse : AmazonWebServiceResponse
    {
        private string _hubArn;
        private string _subscribedAt;

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The ARN of the Hub resource that was retrieved.
        /// </para>
        /// </summary>
        public string HubArn
        {
            get { return this._hubArn; }
            set { this._hubArn = value; }
        }

        // Check to see if HubArn property is set
        internal bool IsSetHubArn()
        {
            return this._hubArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribedAt. 
        /// <para>
        /// The date and time when Security Hub was enabled in the account.
        /// </para>
        /// </summary>
        public string SubscribedAt
        {
            get { return this._subscribedAt; }
            set { this._subscribedAt = value; }
        }

        // Check to see if SubscribedAt property is set
        internal bool IsSetSubscribedAt()
        {
            return this._subscribedAt != null;
        }

    }
}