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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFleets operation.
    /// Deletes the specified EC2 Fleets.
    /// 
    ///  
    /// <para>
    /// After you delete an EC2 Fleet, it launches no new instances.
    /// </para>
    ///  
    /// <para>
    /// You must also specify whether a deleted EC2 Fleet should terminate its instances.
    /// If you choose to terminate the instances, the EC2 Fleet enters the <code>deleted_terminating</code>
    /// state. Otherwise, the EC2 Fleet enters the <code>deleted_running</code> state, and
    /// the instances continue to run until they are interrupted or you terminate them manually.
    /// </para>
    ///  
    /// <para>
    /// For <code>instant</code> fleets, EC2 Fleet must terminate the instances when the fleet
    /// is deleted. A deleted <code>instant</code> fleet with running instances is not supported.
    /// </para>
    ///  <p class="title"> <b>Restrictions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can delete up to 25 <code>instant</code> fleets in a single request. If you exceed
    /// this number, no <code>instant</code> fleets are deleted and an error is returned.
    /// There is no restriction on the number of fleets of type <code>maintain</code> or <code>request</code>
    /// that can be deleted in a single request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Up to 1000 instances can be terminated in a single request to delete <code>instant</code>
    /// fleets.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/manage-ec2-fleet.html#delete-fleet">Delete
    /// an EC2 Fleet</a> in the <i>Amazon EC2 User Guide</i>.
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
        [AWSProperty(Required=true)]
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
        /// Indicates whether to terminate the associated instances when the EC2 Fleet is deleted.
        /// The default is to terminate the instances.
        /// </para>
        ///  
        /// <para>
        /// To let the instances continue to run after the EC2 Fleet is deleted, specify <code>no-terminate-instances</code>.
        /// Supported only for fleets of type <code>maintain</code> and <code>request</code>.
        /// </para>
        ///  
        /// <para>
        /// For <code>instant</code> fleets, you cannot specify <code>NoTerminateInstances</code>.
        /// A deleted <code>instant</code> fleet with running instances is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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