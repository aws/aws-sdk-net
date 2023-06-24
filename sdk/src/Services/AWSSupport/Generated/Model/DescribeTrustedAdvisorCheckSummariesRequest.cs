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
    /// Container for the parameters to the DescribeTrustedAdvisorCheckSummaries operation.
    /// Returns the results for the Trusted Advisor check summaries for the check IDs that
    /// you specified. You can get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// The response contains an array of <a>TrustedAdvisorCheckSummary</a> objects.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
    /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
    /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
    /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
    /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckSummariesRequest : AmazonAWSSupportRequest
    {
        private List<string> _checkIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CheckIds. 
        /// <para>
        /// The IDs of the Trusted Advisor checks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CheckIds
        {
            get { return this._checkIds; }
            set { this._checkIds = value; }
        }

        // Check to see if CheckIds property is set
        internal bool IsSetCheckIds()
        {
            return this._checkIds != null && this._checkIds.Count > 0; 
        }

    }
}