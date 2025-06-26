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
    /// Container for the parameters to the ListManagedThings operation.
    /// Listing all managed things with provision for filters.
    /// </summary>
    public partial class ListManagedThingsRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _connectorDestinationIdFilter;
        private string _connectorDeviceIdFilter;
        private string _connectorPolicyIdFilter;
        private string _credentialLockerFilter;
        private int? _maxResults;
        private string _nextToken;
        private string _ownerFilter;
        private string _parentControllerIdentifierFilter;
        private ProvisioningStatus _provisioningStatusFilter;
        private Role _roleFilter;
        private string _serialNumberFilter;

        /// <summary>
        /// Gets and sets the property ConnectorDestinationIdFilter. 
        /// <para>
        /// Filter managed things by the connector destination ID they are associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorDestinationIdFilter
        {
            get { return this._connectorDestinationIdFilter; }
            set { this._connectorDestinationIdFilter = value; }
        }

        // Check to see if ConnectorDestinationIdFilter property is set
        internal bool IsSetConnectorDestinationIdFilter()
        {
            return this._connectorDestinationIdFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDeviceIdFilter. 
        /// <para>
        /// Filter managed things by the connector device ID they are associated with. When specified,
        /// only managed things with this connector device ID will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string ConnectorDeviceIdFilter
        {
            get { return this._connectorDeviceIdFilter; }
            set { this._connectorDeviceIdFilter = value; }
        }

        // Check to see if ConnectorDeviceIdFilter property is set
        internal bool IsSetConnectorDeviceIdFilter()
        {
            return this._connectorDeviceIdFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorPolicyIdFilter. 
        /// <para>
        /// Filter on a connector policy id for a managed thing.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorPolicyIdFilter is deprecated")]
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorPolicyIdFilter
        {
            get { return this._connectorPolicyIdFilter; }
            set { this._connectorPolicyIdFilter = value; }
        }

        // Check to see if ConnectorPolicyIdFilter property is set
        internal bool IsSetConnectorPolicyIdFilter()
        {
            return this._connectorPolicyIdFilter != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialLockerFilter. 
        /// <para>
        /// Filter on a credential locker for a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CredentialLockerFilter
        {
            get { return this._credentialLockerFilter; }
            set { this._credentialLockerFilter = value; }
        }

        // Check to see if CredentialLockerFilter property is set
        internal bool IsSetCredentialLockerFilter()
        {
            return this._credentialLockerFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that can be used to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerFilter. 
        /// <para>
        /// Filter on device owners when listing managed things.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string OwnerFilter
        {
            get { return this._ownerFilter; }
            set { this._ownerFilter = value; }
        }

        // Check to see if OwnerFilter property is set
        internal bool IsSetOwnerFilter()
        {
            return this._ownerFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ParentControllerIdentifierFilter. 
        /// <para>
        /// Filter on a parent controller id for a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ParentControllerIdentifierFilter
        {
            get { return this._parentControllerIdentifierFilter; }
            set { this._parentControllerIdentifierFilter = value; }
        }

        // Check to see if ParentControllerIdentifierFilter property is set
        internal bool IsSetParentControllerIdentifierFilter()
        {
            return this._parentControllerIdentifierFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningStatusFilter. 
        /// <para>
        /// Filter on the status of the device.
        /// </para>
        /// </summary>
        public ProvisioningStatus ProvisioningStatusFilter
        {
            get { return this._provisioningStatusFilter; }
            set { this._provisioningStatusFilter = value; }
        }

        // Check to see if ProvisioningStatusFilter property is set
        internal bool IsSetProvisioningStatusFilter()
        {
            return this._provisioningStatusFilter != null;
        }

        /// <summary>
        /// Gets and sets the property RoleFilter. 
        /// <para>
        /// Filter on the type of device used. This will be the Amazon Web Services hub controller,
        /// cloud device, or IoT device.
        /// </para>
        /// </summary>
        public Role RoleFilter
        {
            get { return this._roleFilter; }
            set { this._roleFilter = value; }
        }

        // Check to see if RoleFilter property is set
        internal bool IsSetRoleFilter()
        {
            return this._roleFilter != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumberFilter. 
        /// <para>
        /// Filter on the serial number of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string SerialNumberFilter
        {
            get { return this._serialNumberFilter; }
            set { this._serialNumberFilter = value; }
        }

        // Check to see if SerialNumberFilter property is set
        internal bool IsSetSerialNumberFilter()
        {
            return this._serialNumberFilter != null;
        }

    }
}