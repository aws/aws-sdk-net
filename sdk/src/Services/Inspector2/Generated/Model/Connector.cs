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
    /// Describes a connector that links an external cloud provider to Amazon Inspector for
    /// vulnerability scanning.
    /// </summary>
    public partial class Connector
    {
        private bool? _autoInstallVMScanner;
        private string _awsConfigConnectorArn;
        private List<string> _azureRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _connectorArn;
        private DateTime? _createdAt;
        private string _description;
        private EnablementStatus _enablementStatus;
        private string _enablementStatusReason;
        private ConnectorHealth _health;
        private string _name;
        private ConnectorCloudProvider _provider;
        private AzureScopeConfiguration _scopeConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AutoInstallVMScanner. 
        /// <para>
        /// Specifies whether the VM scanner is automatically installed on connected resources.
        /// </para>
        /// </summary>
        public bool? AutoInstallVMScanner
        {
            get { return this._autoInstallVMScanner; }
            set { this._autoInstallVMScanner = value; }
        }

        // Check to see if AutoInstallVMScanner property is set
        internal bool IsSetAutoInstallVMScanner()
        {
            return this._autoInstallVMScanner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AwsConfigConnectorArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Config connector associated with this connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string AwsConfigConnectorArn
        {
            get { return this._awsConfigConnectorArn; }
            set { this._awsConfigConnectorArn = value; }
        }

        // Check to see if AwsConfigConnectorArn property is set
        internal bool IsSetAwsConfigConnectorArn()
        {
            return this._awsConfigConnectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property AzureRegions. 
        /// <para>
        /// The Azure regions configured for the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> AzureRegions
        {
            get { return this._azureRegions; }
            set { this._azureRegions = value; }
        }

        // Check to see if AzureRegions property is set
        internal bool IsSetAzureRegions()
        {
            return this._azureRegions != null && (this._azureRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConnectorArn
        {
            get { return this._connectorArn; }
            set { this._connectorArn = value; }
        }

        // Check to see if ConnectorArn property is set
        internal bool IsSetConnectorArn()
        {
            return this._connectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the connector was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnablementStatus. 
        /// <para>
        /// The enablement status of the connector, which indicates whether the connector is active
        /// and scanning resources.
        /// </para>
        /// </summary>
        public EnablementStatus EnablementStatus
        {
            get { return this._enablementStatus; }
            set { this._enablementStatus = value; }
        }

        // Check to see if EnablementStatus property is set
        internal bool IsSetEnablementStatus()
        {
            return this._enablementStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EnablementStatusReason. 
        /// <para>
        /// Additional information about the current enablement status of the connector.
        /// </para>
        /// </summary>
        public string EnablementStatusReason
        {
            get { return this._enablementStatusReason; }
            set { this._enablementStatusReason = value; }
        }

        // Check to see if EnablementStatusReason property is set
        internal bool IsSetEnablementStatusReason()
        {
            return this._enablementStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The health of the connector, which indicates whether Amazon Inspector can reach and
        /// scan the connected resources.
        /// </para>
        /// </summary>
        public ConnectorHealth Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property Provider. 
        /// <para>
        /// The cloud provider for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorCloudProvider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The Azure scope configuration for the connector.
        /// </para>
        /// </summary>
        public AzureScopeConfiguration ScopeConfiguration
        {
            get { return this._scopeConfiguration; }
            set { this._scopeConfiguration = value; }
        }

        // Check to see if ScopeConfiguration property is set
        internal bool IsSetScopeConfiguration()
        {
            return this._scopeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the connector was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}