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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
        private List<ConfigurationIssue> _incorrectAppendableConfigurationOrder = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;
        private List<ConfigurationIssue> _incorrectSingleValueConfigurations = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;
        private List<ConfigurationIssue> _missingAppendableConfigurationValues = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;
        private List<ConfigurationIssue> _missingMergeableConfigurationValues = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;
        private List<ConfigurationIssue> _unexpectedAppendableConfigurationValues = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;
        private List<ConfigurationIssue> _unexpectedMergeableConfigurationValues = AWSConfigs.InitializeCollections ? new List<ConfigurationIssue>() : null;

        /// <summary>
        /// Gets and sets the property IncorrectAppendableConfigurationOrder. 
        /// <para>
        /// Appendable configuration values that are present but in the wrong order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConfigurationIssue> IncorrectAppendableConfigurationOrder
        {
            get { return this._incorrectAppendableConfigurationOrder; }
            set { this._incorrectAppendableConfigurationOrder = value; }
        }

        // Check to see if IncorrectAppendableConfigurationOrder property is set
        internal bool IsSetIncorrectAppendableConfigurationOrder()
        {
            return this._incorrectAppendableConfigurationOrder != null && (this._incorrectAppendableConfigurationOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncorrectSingleValueConfigurations. 
        /// <para>
        /// Single-value configuration settings whose values do not match the expected values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConfigurationIssue> IncorrectSingleValueConfigurations
        {
            get { return this._incorrectSingleValueConfigurations; }
            set { this._incorrectSingleValueConfigurations = value; }
        }

        // Check to see if IncorrectSingleValueConfigurations property is set
        internal bool IsSetIncorrectSingleValueConfigurations()
        {
            return this._incorrectSingleValueConfigurations != null && (this._incorrectSingleValueConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MissingAppendableConfigurationValues. 
        /// <para>
        /// Appendable configuration values that are expected but missing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConfigurationIssue> MissingAppendableConfigurationValues
        {
            get { return this._missingAppendableConfigurationValues; }
            set { this._missingAppendableConfigurationValues = value; }
        }

        // Check to see if MissingAppendableConfigurationValues property is set
        internal bool IsSetMissingAppendableConfigurationValues()
        {
            return this._missingAppendableConfigurationValues != null && (this._missingAppendableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MissingMergeableConfigurationValues. 
        /// <para>
        /// Mergeable configuration values that are expected but missing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConfigurationIssue> MissingMergeableConfigurationValues
        {
            get { return this._missingMergeableConfigurationValues; }
            set { this._missingMergeableConfigurationValues = value; }
        }

        // Check to see if MissingMergeableConfigurationValues property is set
        internal bool IsSetMissingMergeableConfigurationValues()
        {
            return this._missingMergeableConfigurationValues != null && (this._missingMergeableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnexpectedAppendableConfigurationValues. 
        /// <para>
        /// Appendable configuration values that are present but not expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConfigurationIssue> UnexpectedAppendableConfigurationValues
        {
            get { return this._unexpectedAppendableConfigurationValues; }
            set { this._unexpectedAppendableConfigurationValues = value; }
        }

        // Check to see if UnexpectedAppendableConfigurationValues property is set
        internal bool IsSetUnexpectedAppendableConfigurationValues()
        {
            return this._unexpectedAppendableConfigurationValues != null && (this._unexpectedAppendableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnexpectedMergeableConfigurationValues. 
        /// <para>
        /// Mergeable configuration values that are present but not expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConfigurationIssue> UnexpectedMergeableConfigurationValues
        {
            get { return this._unexpectedMergeableConfigurationValues; }
            set { this._unexpectedMergeableConfigurationValues = value; }
        }

        // Check to see if UnexpectedMergeableConfigurationValues property is set
        internal bool IsSetUnexpectedMergeableConfigurationValues()
        {
            return this._unexpectedMergeableConfigurationValues != null && (this._unexpectedMergeableConfigurationValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}