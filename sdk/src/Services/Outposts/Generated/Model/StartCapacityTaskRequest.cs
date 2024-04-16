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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the StartCapacityTask operation.
    /// Starts the specified capacity task. You can have one active capacity task for an order.
    /// </summary>
    public partial class StartCapacityTaskRequest : AmazonOutpostsRequest
    {
        private bool? _dryRun;
        private List<InstanceTypeCapacity> _instancePools = AWSConfigs.InitializeCollections ? new List<InstanceTypeCapacity>() : null;
        private string _orderId;
        private string _outpostIdentifier;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// You can request a dry run to determine if the instance type and instance size changes
        /// is above or below available instance capacity. Requesting a dry run does not make
        /// any changes to your plan.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancePools. 
        /// <para>
        /// The instance pools specified in the capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InstanceTypeCapacity> InstancePools
        {
            get { return this._instancePools; }
            set { this._instancePools = value; }
        }

        // Check to see if InstancePools property is set
        internal bool IsSetInstancePools()
        {
            return this._instancePools != null && (this._instancePools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// The ID of the Amazon Web Services Outposts order associated with the specified capacity
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string OrderId
        {
            get { return this._orderId; }
            set { this._orderId = value; }
        }

        // Check to see if OrderId property is set
        internal bool IsSetOrderId()
        {
            return this._orderId != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outposts associated with the specified capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=180)]
        public string OutpostIdentifier
        {
            get { return this._outpostIdentifier; }
            set { this._outpostIdentifier = value; }
        }

        // Check to see if OutpostIdentifier property is set
        internal bool IsSetOutpostIdentifier()
        {
            return this._outpostIdentifier != null;
        }

    }
}