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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// An object that represents a connector for an Amazon EVS environment. A connector establishes
    /// a vCenter connection using the credentials stored in Amazon Web Services Secrets Manager.
    /// </summary>
    public partial class Connector
    {
        private string _applianceFqdn;
        private List<ConnectorCheck> _checks = AWSConfigs.InitializeCollections ? new List<ConnectorCheck>() : null;
        private string _connectorId;
        private DateTime? _createdAt;
        private string _environmentId;
        private DateTime? _modifiedAt;
        private string _secretArn;
        private ConnectorState _state;
        private string _stateDetails;
        private CheckResult _status;
        private ConnectorType _type;

        /// <summary>
        /// Gets and sets the property ApplianceFqdn. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the VCF appliance that the connector connects
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string ApplianceFqdn
        {
            get { return this._applianceFqdn; }
            set { this._applianceFqdn = value; }
        }

        // Check to see if ApplianceFqdn property is set
        internal bool IsSetApplianceFqdn()
        {
            return this._applianceFqdn != null;
        }

        /// <summary>
        /// Gets and sets the property Checks. 
        /// <para>
        /// A list of checks that are run on the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorCheck> Checks
        {
            get { return this._checks; }
            set { this._checks = value; }
        }

        // Check to see if Checks property is set
        internal bool IsSetChecks()
        {
            return this._checks != null && (this._checks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique ID of the connector.
        /// </para>
        /// </summary>
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the connector was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique ID of the environment that the connector belongs to.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time that the connector was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// stores the credentials for the VCF appliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the connector.
        /// </para>
        /// </summary>
        public ConnectorState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// A detailed description of the connector state.
        /// </para>
        /// </summary>
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the connector.
        /// </para>
        /// </summary>
        public CheckResult Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the connector.
        /// </para>
        /// </summary>
        public ConnectorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}