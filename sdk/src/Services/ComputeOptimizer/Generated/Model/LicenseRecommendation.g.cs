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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a license recommendation for an EC2 instance.
    /// </summary>
    public partial class LicenseRecommendation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the license. 
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CurrentLicenseConfiguration. 
        /// <para>
        ///  An object that describes the current configuration of an instance that runs on a
        /// license. 
        /// </para>
        /// </summary>
        public LicenseConfiguration CurrentLicenseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentLicenseConfiguration property is set.
        /// </summary>
        internal bool IsSetCurrentLicenseConfiguration() => this.CurrentLicenseConfiguration != null;

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        ///  The finding classification for an instance that runs on a license. 
        /// </para>
        ///  
        /// <para>
        /// Findings include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InsufficentMetrics</c> — When Compute Optimizer detects that your CloudWatch Application
        /// Insights isn't enabled or is enabled with insufficient permissions. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NotOptimized</c> — When Compute Optimizer detects that your EC2 infrastructure
        /// isn't using any of the SQL server license features you're paying for, a license is
        /// considered not optimized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Optimized</c> — When Compute Optimizer detects that all specifications of your
        /// license meet the performance requirements of your workload. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LicenseFinding Finding { get; set; }

        /// <summary>
        /// Checks to see if the Finding property is set.
        /// </summary>
        internal bool IsSetFinding() => this.Finding != null;

        /// <summary>
        /// Gets and sets the property FindingReasonCodes. 
        /// <para>
        ///  The reason for the finding classification for an instance that runs on a license.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Finding reason codes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Optimized</c> — All specifications of your license meet the performance requirements
        /// of your workload. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LicenseOverprovisioned</c> — A license is considered over-provisioned when your
        /// license can be downgraded while still meeting the performance requirements of your
        /// workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidCloudwatchApplicationInsights</c> — CloudWatch Application Insights isn't
        /// configured properly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CloudwatchApplicationInsightsError</c> — There is a CloudWatch Application Insights
        /// error. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FindingReasonCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingReasonCodes property is set.
        /// </summary>
        internal bool IsSetFindingReasonCodes() => this.FindingReasonCodes != null && (this.FindingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        ///  The timestamp of when the license recommendation was last generated. 
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTimestamp property is set.
        /// </summary>
        internal bool IsSetLastRefreshTimestamp() => this.LastRefreshTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the license recommendation options. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseRecommendationOption> LicenseRecommendationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseRecommendationOption>() : null;

        /// <summary>
        /// Checks to see if the LicenseRecommendationOptions property is set.
        /// </summary>
        internal bool IsSetLicenseRecommendationOptions() => this.LicenseRecommendationOptions != null && (this.LicenseRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        ///  The number of days for which utilization metrics were analyzed for an instance that
        /// runs on a license. 
        /// </para>
        /// </summary>
        public double? LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The ARN that identifies the Amazon EC2 instance. 
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to an EC2 instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
