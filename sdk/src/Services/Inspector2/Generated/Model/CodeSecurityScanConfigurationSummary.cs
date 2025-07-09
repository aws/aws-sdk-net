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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
        private List<string> _continuousIntegrationScanSupportedEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _frequencyExpression;
        private string _name;
        private string _ownerAccountId;
        private PeriodicScanFrequency _periodicScanFrequency;
        private List<string> _ruleSetCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scanConfigurationArn;
        private ScopeSettings _scopeSettings;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ContinuousIntegrationScanSupportedEvents. 
        /// <para>
        /// The repository events that trigger continuous integration scans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> ContinuousIntegrationScanSupportedEvents
        {
            get { return this._continuousIntegrationScanSupportedEvents; }
            set { this._continuousIntegrationScanSupportedEvents = value; }
        }

        // Check to see if ContinuousIntegrationScanSupportedEvents property is set
        internal bool IsSetContinuousIntegrationScanSupportedEvents()
        {
            return this._continuousIntegrationScanSupportedEvents != null && (this._continuousIntegrationScanSupportedEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FrequencyExpression. 
        /// <para>
        /// The schedule expression for periodic scans, in cron format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FrequencyExpression
        {
            get { return this._frequencyExpression; }
            set { this._frequencyExpression = value; }
        }

        // Check to see if FrequencyExpression property is set
        internal bool IsSetFrequencyExpression()
        {
            return this._frequencyExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=34)]
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PeriodicScanFrequency. 
        /// <para>
        /// The frequency at which periodic scans are performed.
        /// </para>
        /// </summary>
        public PeriodicScanFrequency PeriodicScanFrequency
        {
            get { return this._periodicScanFrequency; }
            set { this._periodicScanFrequency = value; }
        }

        // Check to see if PeriodicScanFrequency property is set
        internal bool IsSetPeriodicScanFrequency()
        {
            return this._periodicScanFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetCategories. 
        /// <para>
        /// The categories of security rules applied during the scan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> RuleSetCategories
        {
            get { return this._ruleSetCategories; }
            set { this._ruleSetCategories = value; }
        }

        // Check to see if RuleSetCategories property is set
        internal bool IsSetRuleSetCategories()
        {
            return this._ruleSetCategories != null && (this._ruleSetCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanConfigurationArn
        {
            get { return this._scanConfigurationArn; }
            set { this._scanConfigurationArn = value; }
        }

        // Check to see if ScanConfigurationArn property is set
        internal bool IsSetScanConfigurationArn()
        {
            return this._scanConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeSettings. 
        /// <para>
        /// The scope settings that define which repositories will be scanned. If the <c>ScopeSetting</c>
        /// parameter is <c>ALL</c> the scan configuration applies to all existing and future
        /// projects imported into Amazon Inspector.
        /// </para>
        /// </summary>
        public ScopeSettings ScopeSettings
        {
            get { return this._scopeSettings; }
            set { this._scopeSettings = value; }
        }

        // Check to see if ScopeSettings property is set
        internal bool IsSetScopeSettings()
        {
            return this._scopeSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the scan configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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