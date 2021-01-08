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
    /// Container for the parameters to the RefreshTrustedAdvisorCheck operation.
    /// Refreshes the AWS Trusted Advisor check that you specify using the check ID. You can
    /// get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a> operation.
    /// 
    ///  <note> 
    /// <para>
    /// Some checks are refreshed automatically. If you call the <code>RefreshTrustedAdvisorCheck</code>
    /// operation to refresh them, you might see the <code>InvalidParameterValue</code> error.
    /// </para>
    ///  </note> 
    /// <para>
    /// The response contains a <a>TrustedAdvisorCheckRefreshStatus</a> object.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business or Enterprise support plan to use the AWS Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the AWS Support API from an account that does not have a Business or Enterprise
    /// support plan, the <code>SubscriptionRequiredException</code> error message appears.
    /// For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">AWS
    /// Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class RefreshTrustedAdvisorCheckRequest : AmazonAWSSupportRequest
    {
        private string _checkId;

        /// <summary>
        /// Gets and sets the property CheckId. 
        /// <para>
        /// The unique identifier for the Trusted Advisor check to refresh. <b>Note:</b> Specifying
        /// the check ID of a check that is automatically refreshed causes an <code>InvalidParameterValue</code>
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CheckId
        {
            get { return this._checkId; }
            set { this._checkId = value; }
        }

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this._checkId != null;
        }

    }
}