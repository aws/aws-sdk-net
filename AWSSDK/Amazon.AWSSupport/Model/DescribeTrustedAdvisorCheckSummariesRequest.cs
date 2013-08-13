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
    /// Container for the parameters to the DescribeTrustedAdvisorCheckSummaries operation.
    /// <para>This action enables you to get the latest summaries for Trusted Advisor checks that you specify in your request. You submit the list
    /// of Trusted Advisor checks for which you want summaries. You obtain these <i>CheckIds</i> by submitting a DescribeTrustedAdvisorChecks
    /// request. </para> <para>The response body contains an array of TrustedAdvisorCheckSummary objects. </para>
    /// </summary>
    /// <seealso cref="Amazon.AWSSupport.AmazonAWSSupport.DescribeTrustedAdvisorCheckSummaries"/>
    public class DescribeTrustedAdvisorCheckSummariesRequest : AmazonWebServiceRequest
    {
        private List<string> checkIds = new List<string>();

        /// <summary>
        /// Unique identifier for a Trusted Advisor check.
        ///  
        /// </summary>
        public List<string> CheckIds
        {
            get { return this.checkIds; }
            set { this.checkIds = value; }
        }
        /// <summary>
        /// Adds elements to the CheckIds collection
        /// </summary>
        /// <param name="checkIds">The values to add to the CheckIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrustedAdvisorCheckSummariesRequest WithCheckIds(params string[] checkIds)
        {
            foreach (string element in checkIds)
            {
                this.checkIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CheckIds collection
        /// </summary>
        /// <param name="checkIds">The values to add to the CheckIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrustedAdvisorCheckSummariesRequest WithCheckIds(IEnumerable<string> checkIds)
        {
            foreach (string element in checkIds)
            {
                this.checkIds.Add(element);
            }

            return this;
        }

        // Check to see if CheckIds property is set
        internal bool IsSetCheckIds()
        {
            return this.checkIds.Count > 0;
        }
    }
}
    
