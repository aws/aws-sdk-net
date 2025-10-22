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
    /// Container for the parameters to the DeleteFleets operation.
    /// Deletes the specified EC2 Fleet request.
    /// 
    ///  
    /// <para>
    /// After you delete an EC2 Fleet request, it launches no new instances.
    /// </para>
    ///  
    /// <para>
    /// You must also specify whether a deleted EC2 Fleet request should terminate its instances.
    /// If you choose to terminate the instances, the EC2 Fleet request enters the <c>deleted_terminating</c>
    /// state. Otherwise, it enters the <c>deleted_running</c> state, and the instances continue
    /// to run until they are interrupted or you terminate them manually.
    /// </para>
    ///  
    /// <para>
    /// A deleted <c>instant</c> fleet with running instances is not supported. When you delete
    /// an <c>instant</c> fleet, Amazon EC2 automatically terminates all its instances. For
    /// fleets with more than 1000 instances, the deletion request might fail. If your fleet
    /// has more than 1000 instances, first terminate most of the instances manually, leaving
    /// 1000 or fewer. Then delete the fleet, and the remaining instances will be terminated
    /// automatically.
    /// </para>
    ///  
    /// <para>
    ///  <b>Restrictions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can delete up to 25 fleets of type <c>instant</c> in a single request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can delete up to 100 fleets of type <c>maintain</c> or <c>request</c> in a single
    /// request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can delete up to 125 fleets in a single request, provided you do not exceed the
    /// quota for each fleet type, as specified above.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you exceed the specified number of fleets to delete, no fleets are deleted.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/delete-fleet.html">Delete
    /// an EC2 Fleet request and the instances in the fleet</a> in the <i>Amazon EC2 User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteFleetsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<string> _fleetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _terminateInstances;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// The IDs of the EC2 Fleets.
        /// </para>
        ///  
        /// <para>
        /// Constraints: In a single request, you can specify up to 25 <c>instant</c> fleet IDs
        /// and up to 100 <c>maintain</c> or <c>request</c> fleet IDs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._fleetIds != null && (this._fleetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TerminateInstances. 
        /// <para>
        /// Indicates whether to terminate the associated instances when the EC2 Fleet is deleted.
        /// The default is to terminate the instances.
        /// </para>
        ///  
        /// <para>
        /// To let the instances continue to run after the EC2 Fleet is deleted, specify <c>no-terminate-instances</c>.
        /// Supported only for fleets of type <c>maintain</c> and <c>request</c>.
        /// </para>
        ///  
        /// <para>
        /// For <c>instant</c> fleets, you cannot specify <c>NoTerminateInstances</c>. A deleted
        /// <c>instant</c> fleet with running instances is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? TerminateInstances
        {
            get { return this._terminateInstances; }
            set { this._terminateInstances = value; }
        }

        // Check to see if TerminateInstances property is set
        internal bool IsSetTerminateInstances()
        {
            return this._terminateInstances.HasValue; 
        }

    }
}