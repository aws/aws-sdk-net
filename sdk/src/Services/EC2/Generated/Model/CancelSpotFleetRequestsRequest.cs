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
    /// Container for the parameters to the CancelSpotFleetRequests operation.
    /// Cancels the specified Spot Fleet requests.
    /// 
    ///  
    /// <para>
    /// After you cancel a Spot Fleet request, the Spot Fleet launches no new instances.
    /// </para>
    ///  
    /// <para>
    /// You must also specify whether a canceled Spot Fleet request should terminate its instances.
    /// If you choose to terminate the instances, the Spot Fleet request enters the <c>cancelled_terminating</c>
    /// state. Otherwise, the Spot Fleet request enters the <c>cancelled_running</c> state
    /// and the instances continue to run until they are interrupted or you terminate them
    /// manually.
    /// </para>
    ///  
    /// <para>
    ///  <b>Restrictions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can delete up to 100 fleets in a single request. If you exceed the specified number,
    /// no fleets are deleted.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CancelSpotFleetRequestsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<string> _spotFleetRequestIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// Gets and sets the property SpotFleetRequestIds. 
        /// <para>
        /// The IDs of the Spot Fleet requests.
        /// </para>
        ///  
        /// <para>
        /// Constraint: You can specify up to 100 IDs in a single request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SpotFleetRequestIds
        {
            get { return this._spotFleetRequestIds; }
            set { this._spotFleetRequestIds = value; }
        }

        // Check to see if SpotFleetRequestIds property is set
        internal bool IsSetSpotFleetRequestIds()
        {
            return this._spotFleetRequestIds != null && (this._spotFleetRequestIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TerminateInstances. 
        /// <para>
        /// Indicates whether to terminate the associated instances when the Spot Fleet request
        /// is canceled. The default is to terminate the instances.
        /// </para>
        ///  
        /// <para>
        /// To let the instances continue to run after the Spot Fleet request is canceled, specify
        /// <c>no-terminate-instances</c>.
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