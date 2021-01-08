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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The statuses of the Trusted Advisor checks returned by the <a>DescribeTrustedAdvisorCheckRefreshStatuses</a>
    /// operation.
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckRefreshStatusesResponse : AmazonWebServiceResponse
    {
        private List<TrustedAdvisorCheckRefreshStatus> _statuses = new List<TrustedAdvisorCheckRefreshStatus>();

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// The refresh status of the specified Trusted Advisor checks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TrustedAdvisorCheckRefreshStatus> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && this._statuses.Count > 0; 
        }

    }
}