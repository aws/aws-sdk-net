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
    /// Container for the parameters to the DescribeTrustedAdvisorCheckRefreshStatuses operation.
    /// Returns the refresh status of the Trusted Advisor checks that have the specified check
    /// IDs. Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Some checks are refreshed automatically, and their refresh statuses cannot be retrieved
    /// by using this operation. Use of the <code>DescribeTrustedAdvisorCheckRefreshStatuses</code>
    /// operation for these checks causes an <code>InvalidParameterValue</code> error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckRefreshStatusesRequest : AmazonAWSSupportRequest
    {
        private List<string> _checkIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CheckIds. 
        /// <para>
        /// The IDs of the Trusted Advisor checks to get the status of. <b>Note:</b> Specifying
        /// the check ID of a check that is automatically refreshed causes an <code>InvalidParameterValue</code>
        /// error.
        /// </para>
        /// </summary>
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