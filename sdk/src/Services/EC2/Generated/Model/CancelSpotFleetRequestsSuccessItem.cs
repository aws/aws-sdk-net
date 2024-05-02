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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Spot Fleet request that was successfully canceled.
    /// </summary>
    public partial class CancelSpotFleetRequestsSuccessItem
    {
        private BatchState _currentSpotFleetRequestState;
        private BatchState _previousSpotFleetRequestState;
        private string _spotFleetRequestId;

        /// <summary>
        /// Gets and sets the property CurrentSpotFleetRequestState. 
        /// <para>
        /// The current state of the Spot Fleet request.
        /// </para>
        /// </summary>
        public BatchState CurrentSpotFleetRequestState
        {
            get { return this._currentSpotFleetRequestState; }
            set { this._currentSpotFleetRequestState = value; }
        }

        // Check to see if CurrentSpotFleetRequestState property is set
        internal bool IsSetCurrentSpotFleetRequestState()
        {
            return this._currentSpotFleetRequestState != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousSpotFleetRequestState. 
        /// <para>
        /// The previous state of the Spot Fleet request.
        /// </para>
        /// </summary>
        public BatchState PreviousSpotFleetRequestState
        {
            get { return this._previousSpotFleetRequestState; }
            set { this._previousSpotFleetRequestState = value; }
        }

        // Check to see if PreviousSpotFleetRequestState property is set
        internal bool IsSetPreviousSpotFleetRequestState()
        {
            return this._previousSpotFleetRequestState != null;
        }

        /// <summary>
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot Fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId
        {
            get { return this._spotFleetRequestId; }
            set { this._spotFleetRequestId = value; }
        }

        // Check to see if SpotFleetRequestId property is set
        internal bool IsSetSpotFleetRequestId()
        {
            return this._spotFleetRequestId != null;
        }

    }
}