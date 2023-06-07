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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountPolicies operation.
    /// </summary>
    public partial class DescribeAccountPoliciesResponse : AmazonWebServiceResponse
    {
        private List<AccountPolicy> _accountPolicies = new List<AccountPolicy>();

        /// <summary>
        /// Gets and sets the property AccountPolicies. 
        /// <para>
        /// An array of structures that contain information about the CloudWatch Logs account
        /// policies that match the specified filters.
        /// </para>
        /// </summary>
        public List<AccountPolicy> AccountPolicies
        {
            get { return this._accountPolicies; }
            set { this._accountPolicies = value; }
        }

        // Check to see if AccountPolicies property is set
        internal bool IsSetAccountPolicies()
        {
            return this._accountPolicies != null && this._accountPolicies.Count > 0; 
        }

    }
}