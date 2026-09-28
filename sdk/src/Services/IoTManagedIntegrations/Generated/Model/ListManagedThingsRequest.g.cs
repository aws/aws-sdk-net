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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the ListManagedThings operation. Listing all managed
    /// things with provision for filters.
    /// </summary>
    public partial class ListManagedThingsRequest : AmazonIoTManagedIntegrationsRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorDestinationIdFilter. 
        /// <para>
        /// Filter managed things by the connector destination ID they are associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorDestinationIdFilter { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDestinationIdFilter property is set.
        /// </summary>
        internal bool IsSetConnectorDestinationIdFilter() => this.ConnectorDestinationIdFilter != null;

        /// <summary>
        /// Gets and sets the property ConnectorDeviceIdFilter. 
        /// <para>
        /// Filter managed things by the connector device ID they are associated with. When specified,
        /// only managed things with this connector device ID will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string ConnectorDeviceIdFilter { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDeviceIdFilter property is set.
        /// </summary>
        internal bool IsSetConnectorDeviceIdFilter() => this.ConnectorDeviceIdFilter != null;

        /// <summary>
        /// Gets and sets the property ConnectorPolicyIdFilter. 
        /// <para>
        /// Filter on a connector policy id for a managed thing.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorPolicyIdFilter is deprecated")]
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorPolicyIdFilter { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorPolicyIdFilter property is set.
        /// </summary>
        internal bool IsSetConnectorPolicyIdFilter() => this.ConnectorPolicyIdFilter != null;

        /// <summary>
        /// Gets and sets the property CredentialLockerFilter. 
        /// <para>
        /// Filter on a credential locker for a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CredentialLockerFilter { get; set; }

        /// <summary>
        /// Checks to see if the CredentialLockerFilter property is set.
        /// </summary>
        internal bool IsSetCredentialLockerFilter() => this.CredentialLockerFilter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that can be used to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OwnerFilter. 
        /// <para>
        /// Filter on device owners when listing managed things.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string OwnerFilter { get; set; }

        /// <summary>
        /// Checks to see if the OwnerFilter property is set.
        /// </summary>
        internal bool IsSetOwnerFilter() => this.OwnerFilter != null;

        /// <summary>
        /// Gets and sets the property ParentControllerIdentifierFilter. 
        /// <para>
        /// Filter on a parent controller id for a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ParentControllerIdentifierFilter { get; set; }

        /// <summary>
        /// Checks to see if the ParentControllerIdentifierFilter property is set.
        /// </summary>
        internal bool IsSetParentControllerIdentifierFilter() => this.ParentControllerIdentifierFilter != null;

        /// <summary>
        /// Gets and sets the property ProvisioningStatusFilter. 
        /// <para>
        /// Filter on the status of the device. For more information, see <a href="https://docs.aws.amazon.com/iot-mi/latest/devguide/device-provisioning.html">Device
        /// Provisioning</a>.
        /// </para>
        /// </summary>
        public ProvisioningStatus ProvisioningStatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningStatusFilter property is set.
        /// </summary>
        internal bool IsSetProvisioningStatusFilter() => this.ProvisioningStatusFilter != null;

        /// <summary>
        /// Gets and sets the property RoleFilter. 
        /// <para>
        /// Filter on the type of device used. This will be the Amazon Web Services hub controller,
        /// cloud device, or IoT device.
        /// </para>
        /// </summary>
        public Role RoleFilter { get; set; }

        /// <summary>
        /// Checks to see if the RoleFilter property is set.
        /// </summary>
        internal bool IsSetRoleFilter() => this.RoleFilter != null;

        /// <summary>
        /// Gets and sets the property SerialNumberFilter. 
        /// <para>
        /// Filter on the serial number of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string SerialNumberFilter { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumberFilter property is set.
        /// </summary>
        internal bool IsSetSerialNumberFilter() => this.SerialNumberFilter != null;
    }
}
