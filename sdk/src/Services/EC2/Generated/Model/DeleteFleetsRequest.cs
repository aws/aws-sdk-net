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
    /// Container for the parameters to the DeleteFleets operation.
    /// Deletes the specified EC2 Fleet.
    /// 
    ///  
    /// <para>
    /// After you delete an EC2 Fleet, the EC2 Fleet launches no new instances. You must specify
    /// whether the EC2 Fleet should also terminate its instances. If you terminate the instances,
    /// the EC2 Fleet enters the <code>deleted_terminating</code> state. Otherwise, the EC2
    /// Fleet enters the <code>deleted_running</code> state, and the instances continue to
    /// run until they are interrupted or you terminate them manually. 
    /// </para>
    /// </summary>
    public partial class DeleteFleetsRequest : AmazonEC2Request
    {
        private List<string> _fleetIds = new List<string>();
        private bool? _terminateInstances;

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// The IDs of the EC2 Fleets.
        /// </para>
        /// </summary>
        public List<string> FleetIds
        {
            get { return this._fleetIds; }
            set { this._fleetIds = value; }
        }

        // Check to see if FleetIds property is set
        internal bool IsSetFleetIds()
        {
            return this._fleetIds != null && this._fleetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminateInstances. 
        /// <para>
        /// Indicates whether to terminate instances for an EC2 Fleet if it is deleted successfully.
        /// </para>
        /// </summary>
        public bool TerminateInstances
        {
            get { return this._terminateInstances.GetValueOrDefault(); }
            set { this._terminateInstances = value; }
        }

        // Check to see if TerminateInstances property is set
        internal bool IsSetTerminateInstances()
        {
            return this._terminateInstances.HasValue; 
        }

    }
}