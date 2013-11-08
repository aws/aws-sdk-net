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
    /// <para>JSON-formatted object contained in the <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckResult.html"
    /// >DescribeTrustedAdvisorCheckResult</a> response. This object has three child objects:</para> <ol> <li> <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCategorySpecificSummary.html"
    /// >TrustedAdvisorCategorySpecificSummary</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourceDetail.html"
    /// >TrustedAdvisorResourceDetail</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourcesSummary.html"
    /// >TrustedAdvisorResourcesSummary</a> </li>
    /// </ol>
    /// </summary>
    public class TrustedAdvisorCheckResult
    {
        
        private string checkId;
        private string timestamp;
        private string status;
        private TrustedAdvisorResourcesSummary resourcesSummary;
        private TrustedAdvisorCategorySpecificSummary categorySpecificSummary;
        private List<TrustedAdvisorResourceDetail> flaggedResources = new List<TrustedAdvisorResourceDetail>();

        /// <summary>
        /// Unique identifier for a Trusted Advisor check.
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
        /// Time at which Trusted Advisor ran the check.
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
        /// Overall status of the check. Status values are "ok," "warning," "error," or "not_available."
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
        /// JSON-formatted object that lists details about AWS resources that were analyzed in a call to Trusted Advisor <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckSummaries.html"
        /// title="DescribeTrustedAdvisorCheckSummaries">DescribeTrustedAdvisorCheckSummaries</a>.
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
        /// Reports summaries for each Trusted Advisor category. Only the category <i>cost optimizing</i> is currently supported. The other categories
        /// are security, fault tolerance, and performance.
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

        /// <summary>
        /// List of AWS resources flagged by the Trusted Advisor check.
        ///  
        /// </summary>
        public List<TrustedAdvisorResourceDetail> FlaggedResources
        {
            get { return this.flaggedResources; }
            set { this.flaggedResources = value; }
        }

        // Check to see if FlaggedResources property is set
        internal bool IsSetFlaggedResources()
        {
            return this.flaggedResources.Count > 0;
        }
    }
}
