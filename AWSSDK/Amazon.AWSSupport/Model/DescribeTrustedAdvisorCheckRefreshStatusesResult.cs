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
    public class DescribeTrustedAdvisorCheckRefreshStatusesResult
    {
        
        private List<TrustedAdvisorCheckRefreshStatus> statuses = new List<TrustedAdvisorCheckRefreshStatus>();

        /// <summary>
        /// List of the statuses of the Trusted Advisor checks you've specified for refresh. Status values are: <ul> <li><b>in_progress</b>. The refresh
        /// of the check is currently executing. </li> <li><b>successful</b>. The refresh of the check has completed successfully.</li>
        /// <li><b>enqueued</b>. The refresh check is queued for execution. </li> <li><b>abandoned</b>. An error has prevented the check from
        /// refreshing. </li> </ul>
        ///  
        /// </summary>
        public List<TrustedAdvisorCheckRefreshStatus> Statuses
        {
            get { return this.statuses; }
            set { this.statuses = value; }
        }
        /// <summary>
        /// Adds elements to the Statuses collection
        /// </summary>
        /// <param name="statuses">The values to add to the Statuses collection </param>
        /// <returns>this instance</returns>
        public DescribeTrustedAdvisorCheckRefreshStatusesResult WithStatuses(params TrustedAdvisorCheckRefreshStatus[] statuses)
        {
            foreach (TrustedAdvisorCheckRefreshStatus element in statuses)
            {
                this.statuses.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Statuses collection
        /// </summary>
        /// <param name="statuses">The values to add to the Statuses collection </param>
        /// <returns>this instance</returns>
        public DescribeTrustedAdvisorCheckRefreshStatusesResult WithStatuses(IEnumerable<TrustedAdvisorCheckRefreshStatus> statuses)
        {
            foreach (TrustedAdvisorCheckRefreshStatus element in statuses)
            {
                this.statuses.Add(element);
            }

            return this;
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this.statuses.Count > 0;
        }
    }
}
