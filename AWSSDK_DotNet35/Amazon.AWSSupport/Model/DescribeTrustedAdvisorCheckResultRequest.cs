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
    /// Container for the parameters to the DescribeTrustedAdvisorCheckResult operation.
    /// Returns the results of the Trusted Advisor check that has the specified check ID.
    /// Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
    /// 
    ///  
    /// <para>
    /// The response contains a <a>TrustedAdvisorCheckResult</a> object, which contains these
    /// three objects:
    /// </para>
    ///  <ul> <li><a>TrustedAdvisorCategorySpecificSummary</a></li> <li><a>TrustedAdvisorResourceDetail</a></li>
    /// <li><a>TrustedAdvisorResourcesSummary</a></li> </ul> 
    /// <para>
    /// In addition, the response contains these fields:
    /// </para>
    ///  <ul> <li> <b>Status.</b> The alert status of the check: "ok" (green), "warning" (yellow),
    /// "error" (red), or "not_available".</li> <li> <b>Timestamp.</b> The time of the last
    /// refresh of the check.</li> <li> <b>CheckId.</b> The unique identifier for the check.</li>
    /// </ul>
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckResultRequest : AmazonAWSSupportRequest
    {
        private string _checkId;
        private string _language;

        /// <summary>
        /// Gets and sets the property CheckId. 
        /// <para>
        /// The unique identifier for the Trusted Advisor check.
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

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language in which AWS provides support. AWS Support currently
        /// supports English ("en") and Japanese ("ja"). Language parameters must be passed explicitly
        /// for operations that take them.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

    }
}