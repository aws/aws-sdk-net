/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetCapacityReservationUsage operation.
    /// </summary>
    public partial class GetCapacityReservationUsageResponse : AmazonWebServiceResponse
    {
        private int? _availableInstanceCount;
        private string _capacityReservationId;
        private string _instanceType;
        private List<InstanceUsage> _instanceUsages = new List<InstanceUsage>();
        private string _nextToken;
        private CapacityReservationState _state;
        private int? _totalInstanceCount;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount.
        /// </summary>
        public int AvailableInstanceCount
        {
            get { return this._availableInstanceCount.GetValueOrDefault(); }
            set { this._availableInstanceCount = value; }
        }

        // Check to see if AvailableInstanceCount property is set
        internal bool IsSetAvailableInstanceCount()
        {
            return this._availableInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationId.
        /// </summary>
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType.
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceUsages.
        /// </summary>
        public List<InstanceUsage> InstanceUsages
        {
            get { return this._instanceUsages; }
            set { this._instanceUsages = value; }
        }

        // Check to see if InstanceUsages property is set
        internal bool IsSetInstanceUsages()
        {
            return this._instanceUsages != null && this._instanceUsages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
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
        /// Gets and sets the property State.
        /// </summary>
        public CapacityReservationState State
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
        /// Gets and sets the property TotalInstanceCount.
        /// </summary>
        public int TotalInstanceCount
        {
            get { return this._totalInstanceCount.GetValueOrDefault(); }
            set { this._totalInstanceCount = value; }
        }

        // Check to see if TotalInstanceCount property is set
        internal bool IsSetTotalInstanceCount()
        {
            return this._totalInstanceCount.HasValue; 
        }

    }
}