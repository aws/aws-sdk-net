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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The configuration settings related to a given connector.
    /// </summary>
    public partial class ConnectorConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthenticationConfig. 
        /// <para>
        /// The authentication config required for the connector.
        /// </para>
        /// </summary>
        public AuthenticationConfig AuthenticationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfig property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfig() => this.AuthenticationConfig != null;

        /// <summary>
        /// Gets and sets the property CanUseAsDestination. 
        /// <para>
        ///  Specifies whether the connector can be used as a destination. 
        /// </para>
        /// </summary>
        public bool? CanUseAsDestination { get; set; }

        /// <summary>
        /// Checks to see if the CanUseAsDestination property is set.
        /// </summary>
        internal bool IsSetCanUseAsDestination() => this.CanUseAsDestination.HasValue;

        /// <summary>
        /// Gets and sets the property CanUseAsSource. 
        /// <para>
        ///  Specifies whether the connector can be used as a source. 
        /// </para>
        /// </summary>
        public bool? CanUseAsSource { get; set; }

        /// <summary>
        /// Checks to see if the CanUseAsSource property is set.
        /// </summary>
        internal bool IsSetCanUseAsSource() => this.CanUseAsSource.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registered connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string ConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorArn property is set.
        /// </summary>
        internal bool IsSetConnectorArn() => this.ConnectorArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorDescription. 
        /// <para>
        /// A description about the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ConnectorDescription { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDescription property is set.
        /// </summary>
        internal bool IsSetConnectorDescription() => this.ConnectorDescription != null;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The label used for registering the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorLabel property is set.
        /// </summary>
        internal bool IsSetConnectorLabel() => this.ConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property ConnectorMetadata. 
        /// <para>
        ///  Specifies connector-specific metadata such as <c>oAuthScopes</c>, <c>supportedRegions</c>,
        /// <c>privateLinkServiceUrl</c>, and so on. 
        /// </para>
        /// </summary>
        public ConnectorMetadata ConnectorMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorMetadata property is set.
        /// </summary>
        internal bool IsSetConnectorMetadata() => this.ConnectorMetadata != null;

        /// <summary>
        /// Gets and sets the property ConnectorModes. 
        /// <para>
        /// The connection modes that the connector supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectorModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorModes property is set.
        /// </summary>
        internal bool IsSetConnectorModes() => this.ConnectorModes != null && (this.ConnectorModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The connector name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorName property is set.
        /// </summary>
        internal bool IsSetConnectorName() => this.ConnectorName != null;

        /// <summary>
        /// Gets and sets the property ConnectorOwner. 
        /// <para>
        /// The owner who developed the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorOwner { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOwner property is set.
        /// </summary>
        internal bool IsSetConnectorOwner() => this.ConnectorOwner != null;

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningConfig. 
        /// <para>
        /// The configuration required for registering the connector.
        /// </para>
        /// </summary>
        public ConnectorProvisioningConfig ConnectorProvisioningConfig { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProvisioningConfig property is set.
        /// </summary>
        internal bool IsSetConnectorProvisioningConfig() => this.ConnectorProvisioningConfig != null;

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningType. 
        /// <para>
        /// The provisioning type used to register the connector.
        /// </para>
        /// </summary>
        public ConnectorProvisioningType ConnectorProvisioningType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProvisioningType property is set.
        /// </summary>
        internal bool IsSetConnectorProvisioningType() => this.ConnectorProvisioningType != null;

        /// <summary>
        /// Gets and sets the property ConnectorRuntimeSettings. 
        /// <para>
        /// The required connector runtime settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorRuntimeSetting> ConnectorRuntimeSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectorRuntimeSetting>() : null;

        /// <summary>
        /// Checks to see if the ConnectorRuntimeSettings property is set.
        /// </summary>
        internal bool IsSetConnectorRuntimeSettings() => this.ConnectorRuntimeSettings != null && (this.ConnectorRuntimeSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// The connector type.
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;

        /// <summary>
        /// Gets and sets the property ConnectorVersion. 
        /// <para>
        /// The connector version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorVersion { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorVersion property is set.
        /// </summary>
        internal bool IsSetConnectorVersion() => this.ConnectorVersion != null;

        /// <summary>
        /// Gets and sets the property IsPrivateLinkEnabled. 
        /// <para>
        ///  Specifies if PrivateLink is enabled for that connector. 
        /// </para>
        /// </summary>
        public bool? IsPrivateLinkEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsPrivateLinkEnabled property is set.
        /// </summary>
        internal bool IsSetIsPrivateLinkEnabled() => this.IsPrivateLinkEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsPrivateLinkEndpointUrlRequired. 
        /// <para>
        ///  Specifies if a PrivateLink endpoint URL is required. 
        /// </para>
        /// </summary>
        public bool? IsPrivateLinkEndpointUrlRequired { get; set; }

        /// <summary>
        /// Checks to see if the IsPrivateLinkEndpointUrlRequired property is set.
        /// </summary>
        internal bool IsSetIsPrivateLinkEndpointUrlRequired() => this.IsPrivateLinkEndpointUrlRequired.HasValue;

        /// <summary>
        /// Gets and sets the property LogoURL. 
        /// <para>
        /// Logo URL of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LogoURL { get; set; }

        /// <summary>
        /// Checks to see if the LogoURL property is set.
        /// </summary>
        internal bool IsSetLogoURL() => this.LogoURL != null;

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The date on which the connector was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredAt property is set.
        /// </summary>
        internal bool IsSetRegisteredAt() => this.RegisteredAt.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// Information about who registered the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RegisteredBy { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredBy property is set.
        /// </summary>
        internal bool IsSetRegisteredBy() => this.RegisteredBy != null;

        /// <summary>
        /// Gets and sets the property SupportedApiVersions. 
        /// <para>
        /// A list of API versions that are supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedApiVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedApiVersions property is set.
        /// </summary>
        internal bool IsSetSupportedApiVersions() => this.SupportedApiVersions != null && (this.SupportedApiVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedDataTransferApis. 
        /// <para>
        /// The APIs of the connector application that Amazon AppFlow can use to transfer your
        /// data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataTransferApi> SupportedDataTransferApis { get; set; } = AWSConfigs.InitializeCollections ? new List<DataTransferApi>() : null;

        /// <summary>
        /// Checks to see if the SupportedDataTransferApis property is set.
        /// </summary>
        internal bool IsSetSupportedDataTransferApis() => this.SupportedDataTransferApis != null && (this.SupportedDataTransferApis.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedDataTransferTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedDataTransferTypes property is set.
        /// </summary>
        internal bool IsSetSupportedDataTransferTypes() => this.SupportedDataTransferTypes != null && (this.SupportedDataTransferTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedDestinationConnectors. 
        /// <para>
        ///  Lists the connectors that are available for use as destinations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> SupportedDestinationConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedDestinationConnectors property is set.
        /// </summary>
        internal bool IsSetSupportedDestinationConnectors() => this.SupportedDestinationConnectors != null && (this.SupportedDestinationConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedOperators. 
        /// <para>
        /// A list of operators supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedOperators { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedOperators property is set.
        /// </summary>
        internal bool IsSetSupportedOperators() => this.SupportedOperators != null && (this.SupportedOperators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedSchedulingFrequencies. 
        /// <para>
        ///  Specifies the supported flow frequency for that connector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedSchedulingFrequencies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedSchedulingFrequencies property is set.
        /// </summary>
        internal bool IsSetSupportedSchedulingFrequencies() => this.SupportedSchedulingFrequencies != null && (this.SupportedSchedulingFrequencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedTriggerTypes. 
        /// <para>
        ///  Specifies the supported trigger types for the flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedTriggerTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedTriggerTypes property is set.
        /// </summary>
        internal bool IsSetSupportedTriggerTypes() => this.SupportedTriggerTypes != null && (this.SupportedTriggerTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedWriteOperations. 
        /// <para>
        /// A list of write operations supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedWriteOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedWriteOperations property is set.
        /// </summary>
        internal bool IsSetSupportedWriteOperations() => this.SupportedWriteOperations != null && (this.SupportedWriteOperations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
