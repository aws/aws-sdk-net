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
    /// Information about the registered connector.
    /// </summary>
    public partial class ConnectorDetail
    {
        private string _applicationType;
        private string _connectorDescription;
        private string _connectorLabel;
        private List<string> _connectorModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _connectorName;
        private string _connectorOwner;
        private ConnectorProvisioningType _connectorProvisioningType;
        private ConnectorType _connectorType;
        private string _connectorVersion;
        private DateTime? _registeredAt;
        private string _registeredBy;
        private List<string> _supportedDataTransferTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The application type of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string ApplicationType
        {
            get { return this._applicationType; }
            set { this._applicationType = value; }
        }

        // Check to see if ApplicationType property is set
        internal bool IsSetApplicationType()
        {
            return this._applicationType != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDescription. 
        /// <para>
        /// A description about the registered connector.
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
        /// A label used for the connector.
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
        /// Gets and sets the property ConnectorModes. 
        /// <para>
        /// The connection mode that the connector supports.
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
        /// The name of the connector.
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
        /// The owner of the connector.
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
        /// Gets and sets the property ConnectorProvisioningType. 
        /// <para>
        /// The provisioning type that the connector uses.
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
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The time at which the connector was registered.
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
        /// The user who registered the connector.
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

    }
}