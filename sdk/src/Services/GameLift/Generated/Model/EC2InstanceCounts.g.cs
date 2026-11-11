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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Resource capacity settings. Fleet capacity is measured in Amazon EC2 instances. Pending
    /// and terminating counts are non-zero when the fleet capacity is adjusting to a scaling
    /// event or if access to resources is temporarily affected.
    /// </summary>
    public partial class EC2InstanceCounts
    {
        /// <summary>
        /// Gets and sets the property ACTIVE. 
        /// <para>
        /// Actual number of instances that are ready to host game sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ACTIVE { get; set; }

        /// <summary>
        /// Checks to see if the ACTIVE property is set.
        /// </summary>
        internal bool IsSetACTIVE() => this.ACTIVE.HasValue;

        /// <summary>
        /// Gets and sets the property DESIRED. 
        /// <para>
        /// Requested number of active instances. Amazon GameLift Servers takes action as needed
        /// to maintain the desired number of instances. Capacity is scaled up or down by changing
        /// the desired instances. A change in the desired instances value can take up to 1 minute
        /// to be reflected when viewing a fleet's capacity settings. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DESIRED { get; set; }

        /// <summary>
        /// Checks to see if the DESIRED property is set.
        /// </summary>
        internal bool IsSetDESIRED() => this.DESIRED.HasValue;

        /// <summary>
        /// Gets and sets the property IDLE. 
        /// <para>
        /// Number of active instances that are not currently hosting a game session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? IDLE { get; set; }

        /// <summary>
        /// Checks to see if the IDLE property is set.
        /// </summary>
        internal bool IsSetIDLE() => this.IDLE.HasValue;

        /// <summary>
        /// Gets and sets the property MAXIMUM. 
        /// <para>
        /// The maximum instance count value allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MAXIMUM { get; set; }

        /// <summary>
        /// Checks to see if the MAXIMUM property is set.
        /// </summary>
        internal bool IsSetMAXIMUM() => this.MAXIMUM.HasValue;

        /// <summary>
        /// Gets and sets the property MINIMUM. 
        /// <para>
        /// The minimum instance count value allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MINIMUM { get; set; }

        /// <summary>
        /// Checks to see if the MINIMUM property is set.
        /// </summary>
        internal bool IsSetMINIMUM() => this.MINIMUM.HasValue;

        /// <summary>
        /// Gets and sets the property PENDING. 
        /// <para>
        /// Number of instances that are starting but not yet active.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PENDING { get; set; }

        /// <summary>
        /// Checks to see if the PENDING property is set.
        /// </summary>
        internal bool IsSetPENDING() => this.PENDING.HasValue;

        /// <summary>
        /// Gets and sets the property TERMINATING. 
        /// <para>
        /// Number of instances that are no longer active but haven't yet been terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TERMINATING { get; set; }

        /// <summary>
        /// Checks to see if the TERMINATING property is set.
        /// </summary>
        internal bool IsSetTERMINATING() => this.TERMINATING.HasValue;
    }
}
