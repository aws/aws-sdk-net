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
    /// The strategy to use when Amazon EC2 emits a signal that your Spot Instance is at an
    /// elevated risk of being interrupted.
    /// </summary>
    public partial class FleetSpotCapacityRebalance
    {
        private FleetReplacementStrategy _replacementStrategy;

        /// <summary>
        /// Gets and sets the property ReplacementStrategy. 
        /// <para>
        /// To allow EC2 Fleet to launch a replacement Spot Instance when an instance rebalance
        /// notification is emitted for an existing Spot Instance in the fleet, specify <code>launch</code>.
        /// Only available for fleets of type <code>maintain</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When a replacement instance is launched, the instance marked for rebalance is not
        /// automatically terminated. You can terminate it, or you can leave it running. You are
        /// charged for both instances while they are running.
        /// </para>
        ///  </note>
        /// </summary>
        public FleetReplacementStrategy ReplacementStrategy
        {
            get { return this._replacementStrategy; }
            set { this._replacementStrategy = value; }
        }

        // Check to see if ReplacementStrategy property is set
        internal bool IsSetReplacementStrategy()
        {
            return this._replacementStrategy != null;
        }

    }
}