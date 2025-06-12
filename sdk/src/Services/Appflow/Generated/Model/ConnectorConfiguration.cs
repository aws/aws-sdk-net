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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The configuration settings related to a given connector.
    /// </summary>
    public partial class ConnectorConfiguration
    {
        private AuthenticationConfig _authenticationConfig;
        private bool? _canUseAsDestination;
        private bool? _canUseAsSource;
        private string _connectorArn;
        private string _connectorDescription;
        private string _connectorLabel;
        private ConnectorMetadata _connectorMetadata;
        private List<string> _connectorModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _connectorName;
        private string _connectorOwner;
        private ConnectorProvisioningConfig _connectorProvisioningConfig;
        private ConnectorProvisioningType _connectorProvisioningType;
        private List<ConnectorRuntimeSetting> _connectorRuntimeSettings = AWSConfigs.InitializeCollections ? new List<ConnectorRuntimeSetting>() : null;
        private ConnectorType _connectorType;
        private string _connectorVersion;
        private bool? _isPrivateLinkEnabled;
        private bool? _isPrivateLinkEndpointUrlRequired;
        private string _logourl;
        private DateTime? _registeredAt;
        private string _registeredBy;
        private List<string> _supportedApiVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataTransferApi> _supportedDataTransferApis = AWSConfigs.InitializeCollections ? new List<DataTransferApi>() : null;
        private List<string> _supportedDataTransferTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedDestinationConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedOperators = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedSchedulingFrequencies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedTriggerTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedWriteOperations = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AuthenticationConfig. 
        /// <para>
        /// The authentication config required for the connector.
        /// </para>
        /// </summary>
        public AuthenticationConfig AuthenticationConfig
        {
            get { return this._authenticationConfig; }
            set { this._authenticationConfig = value; }
        }

        // Check to see if AuthenticationConfig property is set
        internal bool IsSetAuthenticationConfig()
        {
            return this._authenticationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CanUseAsDestination. 
        /// <para>
        ///  Specifies whether the connector can be used as a destination. 
        /// </para>
        /// </summary>
        public bool? CanUseAsDestination
        {
            get { return this._canUseAsDestination; }
            set { this._canUseAsDestination = value; }
        }

        // Check to see if CanUseAsDestination property is set
        internal bool IsSetCanUseAsDestination()
        {
            return this._canUseAsDestination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanUseAsSource. 
        /// <para>
        ///  Specifies whether the connector can be used as a source. 
        /// </para>
        /// </summary>
        public bool? CanUseAsSource
        {
            get { return this._canUseAsSource; }
            set { this._canUseAsSource = value; }
        }

        // Check to see if CanUseAsSource property is set
        internal bool IsSetCanUseAsSource()
        {
            return this._canUseAsSource.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registered connector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        /// Gets and sets the property ConnectorDescription. 
        /// <para>
        /// A description about the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ConnectorDescription
        {
            get { return this._connectorDescription; }
            set { this._connectorDescription = value; }
        }

        // Check to see if ConnectorDescription property is set
        internal bool IsSetConnectorDescription()
        {
            return this._connectorDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The label used for registering the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorLabel
        {
            get { return this._connectorLabel; }
            set { this._connectorLabel = value; }
        }

        // Check to see if ConnectorLabel property is set
        internal bool IsSetConnectorLabel()
        {
            return this._connectorLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorMetadata. 
        /// <para>
        ///  Specifies connector-specific metadata such as <c>oAuthScopes</c>, <c>supportedRegions</c>,
        /// <c>privateLinkServiceUrl</c>, and so on. 
        /// </para>
        /// </summary>
        public ConnectorMetadata ConnectorMetadata
        {
            get { return this._connectorMetadata; }
            set { this._connectorMetadata = value; }
        }

        // Check to see if ConnectorMetadata property is set
        internal bool IsSetConnectorMetadata()
        {
            return this._connectorMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorModes. 
        /// <para>
        /// The connection modes that the connector supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectorModes
        {
            get { return this._connectorModes; }
            set { this._connectorModes = value; }
        }

        // Check to see if ConnectorModes property is set
        internal bool IsSetConnectorModes()
        {
            return this._connectorModes != null && (this._connectorModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The connector name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorName
        {
            get { return this._connectorName; }
            set { this._connectorName = value; }
        }

        // Check to see if ConnectorName property is set
        internal bool IsSetConnectorName()
        {
            return this._connectorName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorOwner. 
        /// <para>
        /// The owner who developed the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorOwner
        {
            get { return this._connectorOwner; }
            set { this._connectorOwner = value; }
        }

        // Check to see if ConnectorOwner property is set
        internal bool IsSetConnectorOwner()
        {
            return this._connectorOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningConfig. 
        /// <para>
        /// The configuration required for registering the connector.
        /// </para>
        /// </summary>
        public ConnectorProvisioningConfig ConnectorProvisioningConfig
        {
            get { return this._connectorProvisioningConfig; }
            set { this._connectorProvisioningConfig = value; }
        }

        // Check to see if ConnectorProvisioningConfig property is set
        internal bool IsSetConnectorProvisioningConfig()
        {
            return this._connectorProvisioningConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningType. 
        /// <para>
        /// The provisioning type used to register the connector.
        /// </para>
        /// </summary>
        public ConnectorProvisioningType ConnectorProvisioningType
        {
            get { return this._connectorProvisioningType; }
            set { this._connectorProvisioningType = value; }
        }

        // Check to see if ConnectorProvisioningType property is set
        internal bool IsSetConnectorProvisioningType()
        {
            return this._connectorProvisioningType != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorRuntimeSettings. 
        /// <para>
        /// The required connector runtime settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorRuntimeSetting> ConnectorRuntimeSettings
        {
            get { return this._connectorRuntimeSettings; }
            set { this._connectorRuntimeSettings = value; }
        }

        // Check to see if ConnectorRuntimeSettings property is set
        internal bool IsSetConnectorRuntimeSettings()
        {
            return this._connectorRuntimeSettings != null && (this._connectorRuntimeSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// The connector type.
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType
        {
            get { return this._connectorType; }
            set { this._connectorType = value; }
        }

        // Check to see if ConnectorType property is set
        internal bool IsSetConnectorType()
        {
            return this._connectorType != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorVersion. 
        /// <para>
        /// The connector version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorVersion
        {
            get { return this._connectorVersion; }
            set { this._connectorVersion = value; }
        }

        // Check to see if ConnectorVersion property is set
        internal bool IsSetConnectorVersion()
        {
            return this._connectorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IsPrivateLinkEnabled. 
        /// <para>
        ///  Specifies if PrivateLink is enabled for that connector. 
        /// </para>
        /// </summary>
        public bool? IsPrivateLinkEnabled
        {
            get { return this._isPrivateLinkEnabled; }
            set { this._isPrivateLinkEnabled = value; }
        }

        // Check to see if IsPrivateLinkEnabled property is set
        internal bool IsSetIsPrivateLinkEnabled()
        {
            return this._isPrivateLinkEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPrivateLinkEndpointUrlRequired. 
        /// <para>
        ///  Specifies if a PrivateLink endpoint URL is required. 
        /// </para>
        /// </summary>
        public bool? IsPrivateLinkEndpointUrlRequired
        {
            get { return this._isPrivateLinkEndpointUrlRequired; }
            set { this._isPrivateLinkEndpointUrlRequired = value; }
        }

        // Check to see if IsPrivateLinkEndpointUrlRequired property is set
        internal bool IsSetIsPrivateLinkEndpointUrlRequired()
        {
            return this._isPrivateLinkEndpointUrlRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogoURL. 
        /// <para>
        /// Logo URL of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string LogoURL
        {
            get { return this._logourl; }
            set { this._logourl = value; }
        }

        // Check to see if LogoURL property is set
        internal bool IsSetLogoURL()
        {
            return this._logourl != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The date on which the connector was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt
        {
            get { return this._registeredAt; }
            set { this._registeredAt = value; }
        }

        // Check to see if RegisteredAt property is set
        internal bool IsSetRegisteredAt()
        {
            return this._registeredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// Information about who registered the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string RegisteredBy
        {
            get { return this._registeredBy; }
            set { this._registeredBy = value; }
        }

        // Check to see if RegisteredBy property is set
        internal bool IsSetRegisteredBy()
        {
            return this._registeredBy != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedApiVersions. 
        /// <para>
        /// A list of API versions that are supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedApiVersions
        {
            get { return this._supportedApiVersions; }
            set { this._supportedApiVersions = value; }
        }

        // Check to see if SupportedApiVersions property is set
        internal bool IsSetSupportedApiVersions()
        {
            return this._supportedApiVersions != null && (this._supportedApiVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedDataTransferApis. 
        /// <para>
        /// The APIs of the connector application that Amazon AppFlow can use to transfer your
        /// data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataTransferApi> SupportedDataTransferApis
        {
            get { return this._supportedDataTransferApis; }
            set { this._supportedDataTransferApis = value; }
        }

        // Check to see if SupportedDataTransferApis property is set
        internal bool IsSetSupportedDataTransferApis()
        {
            return this._supportedDataTransferApis != null && (this._supportedDataTransferApis.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedDataTransferTypes. 
        /// <para>
        /// The data transfer types that the connector supports.
        /// </para>
        ///  <dl> <dt>RECORD</dt> <dd> 
        /// <para>
        /// Structured records.
        /// </para>
        ///  </dd> <dt>FILE</dt> <dd> 
        /// <para>
        /// Files or binary data.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedDataTransferTypes
        {
            get { return this._supportedDataTransferTypes; }
            set { this._supportedDataTransferTypes = value; }
        }

        // Check to see if SupportedDataTransferTypes property is set
        internal bool IsSetSupportedDataTransferTypes()
        {
            return this._supportedDataTransferTypes != null && (this._supportedDataTransferTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedDestinationConnectors. 
        /// <para>
        ///  Lists the connectors that are available for use as destinations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SupportedDestinationConnectors
        {
            get { return this._supportedDestinationConnectors; }
            set { this._supportedDestinationConnectors = value; }
        }

        // Check to see if SupportedDestinationConnectors property is set
        internal bool IsSetSupportedDestinationConnectors()
        {
            return this._supportedDestinationConnectors != null && (this._supportedDestinationConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedOperators. 
        /// <para>
        /// A list of operators supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedOperators
        {
            get { return this._supportedOperators; }
            set { this._supportedOperators = value; }
        }

        // Check to see if SupportedOperators property is set
        internal bool IsSetSupportedOperators()
        {
            return this._supportedOperators != null && (this._supportedOperators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedSchedulingFrequencies. 
        /// <para>
        ///  Specifies the supported flow frequency for that connector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedSchedulingFrequencies
        {
            get { return this._supportedSchedulingFrequencies; }
            set { this._supportedSchedulingFrequencies = value; }
        }

        // Check to see if SupportedSchedulingFrequencies property is set
        internal bool IsSetSupportedSchedulingFrequencies()
        {
            return this._supportedSchedulingFrequencies != null && (this._supportedSchedulingFrequencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedTriggerTypes. 
        /// <para>
        ///  Specifies the supported trigger types for the flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedTriggerTypes
        {
            get { return this._supportedTriggerTypes; }
            set { this._supportedTriggerTypes = value; }
        }

        // Check to see if SupportedTriggerTypes property is set
        internal bool IsSetSupportedTriggerTypes()
        {
            return this._supportedTriggerTypes != null && (this._supportedTriggerTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedWriteOperations. 
        /// <para>
        /// A list of write operations supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedWriteOperations
        {
            get { return this._supportedWriteOperations; }
            set { this._supportedWriteOperations = value; }
        }

        // Check to see if SupportedWriteOperations property is set
        internal bool IsSetSupportedWriteOperations()
        {
            return this._supportedWriteOperations != null && (this._supportedWriteOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}