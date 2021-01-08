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
    /// Information about the Trusted Advisor checks returned by the <a>DescribeTrustedAdvisorChecks</a>
    /// operation.
    /// </summary>
    public partial class DescribeTrustedAdvisorChecksResponse : AmazonWebServiceResponse
    {
        private List<TrustedAdvisorCheckDescription> _checks = new List<TrustedAdvisorCheckDescription>();

        /// <summary>
        /// Gets and sets the property Checks. 
        /// <para>
        /// Information about all available Trusted Advisor checks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TrustedAdvisorCheckDescription> Checks
        {
            get { return this._checks; }
            set { this._checks = value; }
        }

        // Check to see if Checks property is set
        internal bool IsSetChecks()
        {
            return this._checks != null && this._checks.Count > 0; 
        }

    }
}