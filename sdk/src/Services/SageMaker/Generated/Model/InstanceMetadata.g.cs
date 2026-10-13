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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata information about an instance in a HyperPod cluster.
    /// </summary>
    public partial class InstanceMetadata
    {
        /// <summary>
        /// Gets and sets the property AdditionalEnis. 
        /// <para>
        /// Information about additional Elastic Network Interfaces (ENIs) associated with the
        /// instance.
        /// </para>
        /// </summary>
        public AdditionalEnis AdditionalEnis { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalEnis property is set.
        /// </summary>
        internal bool IsSetAdditionalEnis() => this.AdditionalEnis != null;

        /// <summary>
        /// Gets and sets the property CapacityReservation. 
        /// <para>
        /// Information about the Capacity Reservation used by the instance.
        /// </para>
        /// </summary>
        public CapacityReservation CapacityReservation { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservation property is set.
        /// </summary>
        internal bool IsSetCapacityReservation() => this.CapacityReservation != null;

        /// <summary>
        /// Gets and sets the property CustomerEni. 
        /// <para>
        /// The ID of the customer-managed Elastic Network Interface (ENI) associated with the
        /// instance.
        /// </para>
        /// </summary>
        public string CustomerEni { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEni property is set.
        /// </summary>
        internal bool IsSetCustomerEni() => this.CustomerEni != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// An error message describing why the instance creation or update failed, if applicable.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property InstanceRequirementsEniConfigurations. 
        /// <para>
        /// The ENI configurations for the instance types in the instance requirements, grouped
        /// by network interface category (for example, ENI-only or EFA with ENIs). At most one
        /// configuration per category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceRequirementsEniConfiguration> InstanceRequirementsEniConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceRequirementsEniConfiguration>() : null;

        /// <summary>
        /// Checks to see if the InstanceRequirementsEniConfigurations property is set.
        /// </summary>
        internal bool IsSetInstanceRequirementsEniConfigurations() => this.InstanceRequirementsEniConfigurations != null && (this.InstanceRequirementsEniConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LcsExecutionState. 
        /// <para>
        /// The execution state of the Lifecycle Script (LCS) for the instance.
        /// </para>
        /// </summary>
        public string LcsExecutionState { get; set; }

        /// <summary>
        /// Checks to see if the LcsExecutionState property is set.
        /// </summary>
        internal bool IsSetLcsExecutionState() => this.LcsExecutionState != null;

        /// <summary>
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// The unique logical identifier of the node within the cluster. The ID used here is
        /// the same object as in the <c>BatchAddClusterNodes</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NodeLogicalId { get; set; }

        /// <summary>
        /// Checks to see if the NodeLogicalId property is set.
        /// </summary>
        internal bool IsSetNodeLogicalId() => this.NodeLogicalId != null;
    }
}
