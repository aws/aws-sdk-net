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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A summary of information about a code security scan configuration.
    /// </summary>
    public partial class CodeSecurityScanConfigurationSummary
    {
        /// <summary>
        /// Gets and sets the property ContinuousIntegrationScanSupportedEvents. 
        /// <para>
        /// The repository events that trigger continuous integration scans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> ContinuousIntegrationScanSupportedEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContinuousIntegrationScanSupportedEvents property is set.
        /// </summary>
        internal bool IsSetContinuousIntegrationScanSupportedEvents() => this.ContinuousIntegrationScanSupportedEvents != null && (this.ContinuousIntegrationScanSupportedEvents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FrequencyExpression. 
        /// <para>
        /// The schedule expression for periodic scans, in cron format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FrequencyExpression { get; set; }

        /// <summary>
        /// Checks to see if the FrequencyExpression property is set.
        /// </summary>
        internal bool IsSetFrequencyExpression() => this.FrequencyExpression != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 60)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 34)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property PeriodicScanFrequency. 
        /// <para>
        /// The frequency at which periodic scans are performed.
        /// </para>
        /// </summary>
        public PeriodicScanFrequency PeriodicScanFrequency { get; set; }

        /// <summary>
        /// Checks to see if the PeriodicScanFrequency property is set.
        /// </summary>
        internal bool IsSetPeriodicScanFrequency() => this.PeriodicScanFrequency != null;

        /// <summary>
        /// Gets and sets the property RuleSetCategories. 
        /// <para>
        /// The categories of security rules applied during the scan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 3)]
        public List<string> RuleSetCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RuleSetCategories property is set.
        /// </summary>
        internal bool IsSetRuleSetCategories() => this.RuleSetCategories != null && (this.RuleSetCategories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanConfigurationArn property is set.
        /// </summary>
        internal bool IsSetScanConfigurationArn() => this.ScanConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ScopeSettings. 
        /// <para>
        /// The scope settings that define which repositories will be scanned. If the <c>ScopeSetting</c>
        /// parameter is <c>ALL</c> the scan configuration applies to all existing and future
        /// projects imported into Amazon Inspector.
        /// </para>
        /// </summary>
        public ScopeSettings ScopeSettings { get; set; }

        /// <summary>
        /// Checks to see if the ScopeSettings property is set.
        /// </summary>
        internal bool IsSetScopeSettings() => this.ScopeSettings != null;
    }
}
