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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
        private string _accountId;
        private LicenseConfiguration _currentLicenseConfiguration;
        private LicenseFinding _finding;
        private List<string> _findingReasonCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastRefreshTimestamp;
        private List<LicenseRecommendationOption> _licenseRecommendationOptions = AWSConfigs.InitializeCollections ? new List<LicenseRecommendationOption>() : null;
        private double? _lookbackPeriodInDays;
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the license. 
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentLicenseConfiguration. 
        /// <para>
        ///  An object that describes the current configuration of an instance that runs on a
        /// license. 
        /// </para>
        /// </summary>
        public LicenseConfiguration CurrentLicenseConfiguration
        {
            get { return this._currentLicenseConfiguration; }
            set { this._currentLicenseConfiguration = value; }
        }

        // Check to see if CurrentLicenseConfiguration property is set
        internal bool IsSetCurrentLicenseConfiguration()
        {
            return this._currentLicenseConfiguration != null;
        }

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
        public LicenseFinding Finding
        {
            get { return this._finding; }
            set { this._finding = value; }
        }

        // Check to see if Finding property is set
        internal bool IsSetFinding()
        {
            return this._finding != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FindingReasonCodes
        {
            get { return this._findingReasonCodes; }
            set { this._findingReasonCodes = value; }
        }

        // Check to see if FindingReasonCodes property is set
        internal bool IsSetFindingReasonCodes()
        {
            return this._findingReasonCodes != null && (this._findingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        ///  The timestamp of when the license recommendation was last generated. 
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp
        {
            get { return this._lastRefreshTimestamp; }
            set { this._lastRefreshTimestamp = value; }
        }

        // Check to see if LastRefreshTimestamp property is set
        internal bool IsSetLastRefreshTimestamp()
        {
            return this._lastRefreshTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the license recommendation options. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseRecommendationOption> LicenseRecommendationOptions
        {
            get { return this._licenseRecommendationOptions; }
            set { this._licenseRecommendationOptions = value; }
        }

        // Check to see if LicenseRecommendationOptions property is set
        internal bool IsSetLicenseRecommendationOptions()
        {
            return this._licenseRecommendationOptions != null && (this._licenseRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        ///  The number of days for which utilization metrics were analyzed for an instance that
        /// runs on a license. 
        /// </para>
        /// </summary>
        public double? LookbackPeriodInDays
        {
            get { return this._lookbackPeriodInDays; }
            set { this._lookbackPeriodInDays = value; }
        }

        // Check to see if LookbackPeriodInDays property is set
        internal bool IsSetLookbackPeriodInDays()
        {
            return this._lookbackPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The ARN that identifies the Amazon EC2 instance. 
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to an EC2 instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}