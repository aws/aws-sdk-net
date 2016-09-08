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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the RefreshTrustedAdvisorCheck operation.
    /// Requests a refresh of the Trusted Advisor check that has the specified check ID. Check
    /// IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Some checks are refreshed automatically, and they cannot be refreshed by using this
    /// operation. Use of the <code>RefreshTrustedAdvisorCheck</code> operation for these
    /// checks causes an <code>InvalidParameterValue</code> error.
    /// </para>
    ///  </note> 
    /// <para>
    /// The response contains a <a>TrustedAdvisorCheckRefreshStatus</a> object, which contains
    /// these fields:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>status.</b> The refresh status of the check: "none", "enqueued", "processing",
    /// "success", or "abandoned".
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>millisUntilNextRefreshable.</b> The amount of time, in milliseconds, until the
    /// check is eligible for refresh.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>checkId.</b> The unique identifier for the check.
    /// </para>
    ///  </li> </ul>
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