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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The results of a Trusted Advisor check returned by <a>DescribeTrustedAdvisorCheckResult</a>.
    /// </summary>
    public partial class TrustedAdvisorCheckResult
    {
        /// <summary>
        /// Gets and sets the property CategorySpecificSummary. 
        /// <para>
        /// Summary information that relates to the category of the check. Cost Optimizing is
        /// the only category that is currently supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAdvisorCategorySpecificSummary CategorySpecificSummary { get; set; }

        /// <summary>
        /// Checks to see if the CategorySpecificSummary property is set.
        /// </summary>
        internal bool IsSetCategorySpecificSummary() => this.CategorySpecificSummary != null;

        /// <summary>
        /// Gets and sets the property CheckId. 
        /// <para>
        /// The unique identifier for the Trusted Advisor check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CheckId { get; set; }

        /// <summary>
        /// Checks to see if the CheckId property is set.
        /// </summary>
        internal bool IsSetCheckId() => this.CheckId != null;

        /// <summary>
        /// Gets and sets the property FlaggedResources. 
        /// <para>
        /// The details about each resource listed in the check result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TrustedAdvisorResourceDetail> FlaggedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<TrustedAdvisorResourceDetail>() : null;

        /// <summary>
        /// Checks to see if the FlaggedResources property is set.
        /// </summary>
        internal bool IsSetFlaggedResources() => this.FlaggedResources != null && (this.FlaggedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourcesSummary.
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAdvisorResourcesSummary ResourcesSummary { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesSummary property is set.
        /// </summary>
        internal bool IsSetResourcesSummary() => this.ResourcesSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The alert status of the check: "ok" (green), "warning" (yellow), "error" (red), or
        /// "not_available".
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time of the last refresh of the check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;
    }
}
