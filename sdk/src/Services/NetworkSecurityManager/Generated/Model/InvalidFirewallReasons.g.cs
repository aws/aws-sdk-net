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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Details about the ways in which a firewall's configuration differs from the intended
    /// configuration.
    /// </summary>
    public partial class InvalidFirewallReasons
    {
        /// <summary>
        /// Gets and sets the property IncorrectAppendableConfigurationOrder. 
        /// <para>
        /// Appendable configuration values that are present but in the wrong order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<ConfigurationIssue> IncorrectAppendableConfigurationOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;

        /// <summary>
        /// Checks to see if the IncorrectAppendableConfigurationOrder property is set.
        /// </summary>
        internal bool IsSetIncorrectAppendableConfigurationOrder() => this.IncorrectAppendableConfigurationOrder != null && (this.IncorrectAppendableConfigurationOrder.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncorrectSingleValueConfigurations. 
        /// <para>
        /// Single-value configuration settings whose values do not match the expected values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<ConfigurationIssue> IncorrectSingleValueConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;

        /// <summary>
        /// Checks to see if the IncorrectSingleValueConfigurations property is set.
        /// </summary>
        internal bool IsSetIncorrectSingleValueConfigurations() => this.IncorrectSingleValueConfigurations != null && (this.IncorrectSingleValueConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MissingAppendableConfigurationValues. 
        /// <para>
        /// Appendable configuration values that are expected but missing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<ConfigurationIssue> MissingAppendableConfigurationValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;

        /// <summary>
        /// Checks to see if the MissingAppendableConfigurationValues property is set.
        /// </summary>
        internal bool IsSetMissingAppendableConfigurationValues() => this.MissingAppendableConfigurationValues != null && (this.MissingAppendableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MissingMergeableConfigurationValues. 
        /// <para>
        /// Mergeable configuration values that are expected but missing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<ConfigurationIssue> MissingMergeableConfigurationValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;

        /// <summary>
        /// Checks to see if the MissingMergeableConfigurationValues property is set.
        /// </summary>
        internal bool IsSetMissingMergeableConfigurationValues() => this.MissingMergeableConfigurationValues != null && (this.MissingMergeableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnexpectedAppendableConfigurationValues. 
        /// <para>
        /// Appendable configuration values that are present but not expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<ConfigurationIssue> UnexpectedAppendableConfigurationValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;

        /// <summary>
        /// Checks to see if the UnexpectedAppendableConfigurationValues property is set.
        /// </summary>
        internal bool IsSetUnexpectedAppendableConfigurationValues() => this.UnexpectedAppendableConfigurationValues != null && (this.UnexpectedAppendableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnexpectedMergeableConfigurationValues. 
        /// <para>
        /// Mergeable configuration values that are present but not expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<ConfigurationIssue> UnexpectedMergeableConfigurationValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;

        /// <summary>
        /// Checks to see if the UnexpectedMergeableConfigurationValues property is set.
        /// </summary>
        internal bool IsSetUnexpectedMergeableConfigurationValues() => this.UnexpectedMergeableConfigurationValues != null && (this.UnexpectedMergeableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
