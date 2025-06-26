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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one managed thing.
    /// </summary>
    public partial class ManagedThingSummary
    {
        private DateTime? _activatedAt;
        private string _advertisedProductId;
        private string _arn;
        private string _brand;
        private string _classification;
        private string _connectorDestinationId;
        private string _connectorDeviceId;
        private string _connectorPolicyId;
        private DateTime? _createdAt;
        private string _credentialLockerId;
        private string _id;
        private string _model;
        private string _name;
        private string _owner;
        private string _parentControllerId;
        private ProvisioningStatus _provisioningStatus;
        private Role _role;
        private string _serialNumber;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ActivatedAt. 
        /// <para>
        /// The timestampe value of when the managed thing was activated at.
        /// </para>
        /// </summary>
        public DateTime? ActivatedAt
        {
            get { return this._activatedAt; }
            set { this._activatedAt = value; }
        }

        // Check to see if ActivatedAt property is set
        internal bool IsSetActivatedAt()
        {
            return this._activatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdvertisedProductId. 
        /// <para>
        /// The id of the advertised product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
        public string AdvertisedProductId
        {
            get { return this._advertisedProductId; }
            set { this._advertisedProductId = value; }
        }

        // Check to see if AdvertisedProductId property is set
        internal bool IsSetAdvertisedProductId()
        {
            return this._advertisedProductId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Brand. 
        /// <para>
        /// The brand of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        // Check to see if Brand property is set
        internal bool IsSetBrand()
        {
            return this._brand != null;
        }

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the managed thing such as light bulb or thermostat.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDestinationId. 
        /// <para>
        /// The identifier of the connector destination associated with this managed thing, if
        /// applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorDestinationId
        {
            get { return this._connectorDestinationId; }
            set { this._connectorDestinationId = value; }
        }

        // Check to see if ConnectorDestinationId property is set
        internal bool IsSetConnectorDestinationId()
        {
            return this._connectorDestinationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDeviceId. 
        /// <para>
        /// The third-party device id as defined by the connector. This device id must not contain
        /// personal identifiable information (PII).
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for cloud-to-cloud devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string ConnectorDeviceId
        {
            get { return this._connectorDeviceId; }
            set { this._connectorDeviceId = value; }
        }

        // Check to see if ConnectorDeviceId property is set
        internal bool IsSetConnectorDeviceId()
        {
            return this._connectorDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorPolicyId. 
        /// <para>
        /// The id of the connector policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for cloud-to-cloud devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("ConnectorPolicyId has been deprecated")]
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorPolicyId
        {
            get { return this._connectorPolicyId; }
            set { this._connectorPolicyId = value; }
        }

        // Check to see if ConnectorPolicyId property is set
        internal bool IsSetConnectorPolicyId()
        {
            return this._connectorPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp value of when the device creation request occurred.
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
        /// Gets and sets the property CredentialLockerId. 
        /// <para>
        /// The identifier of the credential locker for the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CredentialLockerId
        {
            get { return this._credentialLockerId; }
            set { this._credentialLockerId = value; }
        }

        // Check to see if CredentialLockerId property is set
        internal bool IsSetCredentialLockerId()
        {
            return this._credentialLockerId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed thing representing the physical device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// Owner of the device, usually an indication of whom the device belongs to. This value
        /// should not contain personal identifiable information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ParentControllerId. 
        /// <para>
        /// Id of the controller device used for the discovery job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ParentControllerId
        {
            get { return this._parentControllerId; }
            set { this._parentControllerId = value; }
        }

        // Check to see if ParentControllerId property is set
        internal bool IsSetParentControllerId()
        {
            return this._parentControllerId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The provisioning status of the device in the provisioning workflow for onboarding
        /// to IoT managed integrations.
        /// </para>
        /// </summary>
        public ProvisioningStatus ProvisioningStatus
        {
            get { return this._provisioningStatus; }
            set { this._provisioningStatus = value; }
        }

        // Check to see if ProvisioningStatus property is set
        internal bool IsSetProvisioningStatus()
        {
            return this._provisioningStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The type of device used. This will be the Amazon Web Services hub controller, cloud
        /// device, or IoT device.
        /// </para>
        /// </summary>
        public Role Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp value of when the managed thing was last updated at.
        /// </para>
        /// </summary>
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