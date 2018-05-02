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
    /// Describes an EC2 Fleet that was successfully deleted.
    /// </summary>
    public partial class DeleteFleetSuccessItem
    {
        private FleetStateCode _currentFleetState;
        private string _fleetId;
        private FleetStateCode _previousFleetState;

        /// <summary>
        /// Gets and sets the property CurrentFleetState. 
        /// <para>
        /// The current state of the EC2 Fleet.
        /// </para>
        /// </summary>
        public FleetStateCode CurrentFleetState
        {
            get { return this._currentFleetState; }
            set { this._currentFleetState = value; }
        }

        // Check to see if CurrentFleetState property is set
        internal bool IsSetCurrentFleetState()
        {
            return this._currentFleetState != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The ID of the EC2 Fleet.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousFleetState. 
        /// <para>
        /// The previous state of the EC2 Fleet.
        /// </para>
        /// </summary>
        public FleetStateCode PreviousFleetState
        {
            get { return this._previousFleetState; }
            set { this._previousFleetState = value; }
        }

        // Check to see if PreviousFleetState property is set
        internal bool IsSetPreviousFleetState()
        {
            return this._previousFleetState != null;
        }

    }
}