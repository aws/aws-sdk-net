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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public class DescribeTrustedAdvisorChecksResult
    {
        
        private List<TrustedAdvisorCheckDescription> checks = new List<TrustedAdvisorCheckDescription>();

        /// <summary>
        /// List of the checks returned by calling <a href="API_DescribeTrustedAdvisorChecks.html"
        /// title="DescribeTrustedAdvisorChecks">DescribeTrustedAdvisorChecks</a>
        ///  
        /// </summary>
        public List<TrustedAdvisorCheckDescription> Checks
        {
            get { return this.checks; }
            set { this.checks = value; }
        }
        /// <summary>
        /// Adds elements to the Checks collection
        /// </summary>
        /// <param name="checks">The values to add to the Checks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrustedAdvisorChecksResult WithChecks(params TrustedAdvisorCheckDescription[] checks)
        {
            foreach (TrustedAdvisorCheckDescription element in checks)
            {
                this.checks.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Checks collection
        /// </summary>
        /// <param name="checks">The values to add to the Checks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrustedAdvisorChecksResult WithChecks(IEnumerable<TrustedAdvisorCheckDescription> checks)
        {
            foreach (TrustedAdvisorCheckDescription element in checks)
            {
                this.checks.Add(element);
            }

            return this;
        }

        // Check to see if Checks property is set
        internal bool IsSetChecks()
        {
            return this.checks.Count > 0;
        }
    }
}
