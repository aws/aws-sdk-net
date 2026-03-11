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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private AdditionalEnis _additionalEnis;
        private CapacityReservation _capacityReservation;
        private string _customerEni;
        private string _failureMessage;
        private string _lcsExecutionState;
        private string _nodeLogicalId;

        /// <summary>
        /// Gets and sets the property AdditionalEnis. 
        /// <para>
        /// Information about additional Elastic Network Interfaces (ENIs) associated with the
        /// instance.
        /// </para>
        /// </summary>
        public AdditionalEnis AdditionalEnis
        {
            get { return this._additionalEnis; }
            set { this._additionalEnis = value; }
        }

        // Check to see if AdditionalEnis property is set
        internal bool IsSetAdditionalEnis()
        {
            return this._additionalEnis != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservation. 
        /// <para>
        /// Information about the Capacity Reservation used by the instance.
        /// </para>
        /// </summary>
        public CapacityReservation CapacityReservation
        {
            get { return this._capacityReservation; }
            set { this._capacityReservation = value; }
        }

        // Check to see if CapacityReservation property is set
        internal bool IsSetCapacityReservation()
        {
            return this._capacityReservation != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerEni. 
        /// <para>
        /// The ID of the customer-managed Elastic Network Interface (ENI) associated with the
        /// instance.
        /// </para>
        /// </summary>
        public string CustomerEni
        {
            get { return this._customerEni; }
            set { this._customerEni = value; }
        }

        // Check to see if CustomerEni property is set
        internal bool IsSetCustomerEni()
        {
            return this._customerEni != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// An error message describing why the instance creation or update failed, if applicable.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LcsExecutionState. 
        /// <para>
        /// The execution state of the Lifecycle Script (LCS) for the instance.
        /// </para>
        /// </summary>
        public string LcsExecutionState
        {
            get { return this._lcsExecutionState; }
            set { this._lcsExecutionState = value; }
        }

        // Check to see if LcsExecutionState property is set
        internal bool IsSetLcsExecutionState()
        {
            return this._lcsExecutionState != null;
        }

        /// <summary>
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// The unique logical identifier of the node within the cluster. The ID used here is
        /// the same object as in the <c>BatchAddClusterNodes</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NodeLogicalId
        {
            get { return this._nodeLogicalId; }
            set { this._nodeLogicalId = value; }
        }

        // Check to see if NodeLogicalId property is set
        internal bool IsSetNodeLogicalId()
        {
            return this._nodeLogicalId != null;
        }

    }
}