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
    /// Contains the filter criteria for narrowing the results returned by a <c>ListConnectors</c>
    /// request. You can filter by connector ARN, Amazon Web Services account ID, Amazon Web
    /// Services Config connector ARN, connector type, or cloud provider.
    /// </summary>
    public partial class ConnectorFilterCriteria
    {
        private List<StringFilter> _accounts = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<AwsConfigConnectorArnFilter> _awsConfigConnectorArns = AWSConfigs.InitializeCollections ? new List<AwsConfigConnectorArnFilter>() : null;
        private List<ConnectorArnFilter> _connectorArns = AWSConfigs.InitializeCollections ? new List<ConnectorArnFilter>() : null;
        private List<ConnectorTypeFilter> _connectorType = AWSConfigs.InitializeCollections ? new List<ConnectorTypeFilter>() : null;
        private List<ProviderFilter> _provider = AWSConfigs.InitializeCollections ? new List<ProviderFilter>() : null;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// Filter by Amazon Web Services account IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsConfigConnectorArns. 
        /// <para>
        /// Filter by Amazon Web Services Config connector ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<AwsConfigConnectorArnFilter> AwsConfigConnectorArns
        {
            get { return this._awsConfigConnectorArns; }
            set { this._awsConfigConnectorArns = value; }
        }

        // Check to see if AwsConfigConnectorArns property is set
        internal bool IsSetAwsConfigConnectorArns()
        {
            return this._awsConfigConnectorArns != null && (this._awsConfigConnectorArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorArns. 
        /// <para>
        /// Filter by connector ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<ConnectorArnFilter> ConnectorArns
        {
            get { return this._connectorArns; }
            set { this._connectorArns = value; }
        }

        // Check to see if ConnectorArns property is set
        internal bool IsSetConnectorArns()
        {
            return this._connectorArns != null && (this._connectorArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// Filter by connector type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<ConnectorTypeFilter> ConnectorType
        {
            get { return this._connectorType; }
            set { this._connectorType = value; }
        }

        // Check to see if ConnectorType property is set
        internal bool IsSetConnectorType()
        {
            return this._connectorType != null && (this._connectorType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// Filter by cloud provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<ProviderFilter> Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null && (this._provider.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}