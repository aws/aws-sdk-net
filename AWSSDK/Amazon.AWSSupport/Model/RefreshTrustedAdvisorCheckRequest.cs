/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Requests a refresh of the Trusted Advisor check that has the specified check ID. Check IDs can be obtained by calling
    /// DescribeTrustedAdvisorChecks.</para> <para>The response contains a RefreshTrustedAdvisorCheckResult object, which contains these
    /// fields:</para>
    /// <ul>
    /// <li> <b>Status.</b> The refresh status of the check: "none", "enqueued", "processing", "success", or "abandoned".</li>
    /// <li> <b>MillisUntilNextRefreshable.</b> The amount of time, in milliseconds, until the check is eligible for refresh.</li>
    /// <li> <b>CheckId.</b> The unique identifier for the check.</li>
    /// 
    /// </ul>
    /// </summary>
    /// <seealso cref="Amazon.AWSSupport.AmazonAWSSupport.RefreshTrustedAdvisorCheck"/>
    public class RefreshTrustedAdvisorCheckRequest : AmazonWebServiceRequest
    {
        private string checkId;

        /// <summary>
        /// The unique identifier for the Trusted Advisor check.
        ///  
        /// </summary>
        public string CheckId
        {
            get { return this.checkId; }
            set { this.checkId = value; }
        }

        /// <summary>
        /// Sets the CheckId property
        /// </summary>
        /// <param name="checkId">The value to set for the CheckId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RefreshTrustedAdvisorCheckRequest WithCheckId(string checkId)
        {
            this.checkId = checkId;
            return this;
        }
            

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this.checkId != null;
        }
    }
}
    
