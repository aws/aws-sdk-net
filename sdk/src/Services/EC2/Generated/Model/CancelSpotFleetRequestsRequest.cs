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
    /// If you choose to terminate the instances, the Spot Fleet request enters the <code>cancelled_terminating</code>
    /// state. Otherwise, the Spot Fleet request enters the <code>cancelled_running</code>
    /// state and the instances continue to run until they are interrupted or you terminate
    /// them manually.
    /// </para>
    /// </summary>
    public partial class CancelSpotFleetRequestsRequest : AmazonEC2Request
    {
        private List<string> _spotFleetRequestIds = new List<string>();
        private bool? _terminateInstances;

        /// <summary>
        /// Gets and sets the property SpotFleetRequestIds. 
        /// <para>
        /// The IDs of the Spot Fleet requests.
        /// </para>
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
            return this._spotFleetRequestIds != null && this._spotFleetRequestIds.Count > 0; 
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
        /// <code>no-terminate-instances</code>.
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