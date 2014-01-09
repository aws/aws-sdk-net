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
    /// <para>A summary of a Trusted Advisor check result, including the alert status, last refresh, and number of resources examined.</para>
    /// </summary>
    public class TrustedAdvisorCheckSummary
    {
        
        private string checkId;
        private string timestamp;
        private string status;
        private bool? hasFlaggedResources;
        private TrustedAdvisorResourcesSummary resourcesSummary;
        private TrustedAdvisorCategorySpecificSummary categorySpecificSummary;


        /// <summary>
        /// The unique identifier for the Trusted Advisor check.
        ///  
        /// </summary>
        public string CheckId
        {
            get { return this.checkId; }
            set { this.checkId = value; }
        }

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this.checkId != null;
        }

        /// <summary>
        /// The time of the last refresh of the check.
        ///  
        /// </summary>
        public string Timestamp
        {
            get { return this.timestamp; }
            set { this.timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this.timestamp != null;
        }

        /// <summary>
        /// The alert status of the check: "ok" (green), "warning" (yellow), "error" (red), or "not_available".
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Specifies whether the Trusted Advisor check has flagged resources.
        ///  
        /// </summary>
        public bool HasFlaggedResources
        {
            get { return this.hasFlaggedResources ?? default(bool); }
            set { this.hasFlaggedResources = value; }
        }

        // Check to see if HasFlaggedResources property is set
        internal bool IsSetHasFlaggedResources()
        {
            return this.hasFlaggedResources.HasValue;
        }

        /// <summary>
        /// Details about AWS resources that were analyzed in a call to Trusted Advisor <a>DescribeTrustedAdvisorCheckSummaries</a>.
        ///  
        /// </summary>
        public TrustedAdvisorResourcesSummary ResourcesSummary
        {
            get { return this.resourcesSummary; }
            set { this.resourcesSummary = value; }
        }

        // Check to see if ResourcesSummary property is set
        internal bool IsSetResourcesSummary()
        {
            return this.resourcesSummary != null;
        }

        /// <summary>
        /// Summary information that relates to the category of the check. Cost Optimizing is the only category that is currently supported.
        ///  
        /// </summary>
        public TrustedAdvisorCategorySpecificSummary CategorySpecificSummary
        {
            get { return this.categorySpecificSummary; }
            set { this.categorySpecificSummary = value; }
        }

        // Check to see if CategorySpecificSummary property is set
        internal bool IsSetCategorySpecificSummary()
        {
            return this.categorySpecificSummary != null;
        }
    }
}
