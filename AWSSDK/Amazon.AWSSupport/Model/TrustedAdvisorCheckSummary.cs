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
    public partial class TrustedAdvisorCheckSummary
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

        /// <summary>
        /// Sets the CheckId property
        /// </summary>
        /// <param name="checkId">The value to set for the CheckId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckSummary WithCheckId(string checkId)
        {
            this.checkId = checkId;
            return this;
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

        /// <summary>
        /// Sets the Timestamp property
        /// </summary>
        /// <param name="timestamp">The value to set for the Timestamp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckSummary WithTimestamp(string timestamp)
        {
            this.timestamp = timestamp;
            return this;
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

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckSummary WithStatus(string status)
        {
            this.status = status;
            return this;
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

        /// <summary>
        /// Sets the HasFlaggedResources property
        /// </summary>
        /// <param name="hasFlaggedResources">The value to set for the HasFlaggedResources property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckSummary WithHasFlaggedResources(bool hasFlaggedResources)
        {
            this.hasFlaggedResources = hasFlaggedResources;
            return this;
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

        /// <summary>
        /// Sets the ResourcesSummary property
        /// </summary>
        /// <param name="resourcesSummary">The value to set for the ResourcesSummary property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckSummary WithResourcesSummary(TrustedAdvisorResourcesSummary resourcesSummary)
        {
            this.resourcesSummary = resourcesSummary;
            return this;
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

        /// <summary>
        /// Sets the CategorySpecificSummary property
        /// </summary>
        /// <param name="categorySpecificSummary">The value to set for the CategorySpecificSummary property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckSummary WithCategorySpecificSummary(TrustedAdvisorCategorySpecificSummary categorySpecificSummary)
        {
            this.categorySpecificSummary = categorySpecificSummary;
            return this;
        }
            

        // Check to see if CategorySpecificSummary property is set
        internal bool IsSetCategorySpecificSummary()
        {
            return this.categorySpecificSummary != null;
        }
    }
}
