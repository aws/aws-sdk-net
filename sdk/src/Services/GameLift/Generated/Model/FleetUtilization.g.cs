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
    /// Current resource utilization statistics in a specified fleet or location. The location
    /// value might refer to a fleet's remote location or its home region.
    /// </summary>
    public partial class FleetUtilization
    {
        /// <summary>
        /// Gets and sets the property ActiveGameSessionCount. 
        /// <para>
        /// The number of active game sessions that are currently being hosted across all instances
        /// in the fleet location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ActiveGameSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveGameSessionCount property is set.
        /// </summary>
        internal bool IsSetActiveGameSessionCount() => this.ActiveGameSessionCount.HasValue;

        /// <summary>
        /// Gets and sets the property ActiveServerProcessCount. 
        /// <para>
        /// The number of server processes in <c>ACTIVE</c> status that are currently running
        /// across all instances in the fleet location. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ActiveServerProcessCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveServerProcessCount property is set.
        /// </summary>
        internal bool IsSetActiveServerProcessCount() => this.ActiveServerProcessCount.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentPlayerSessionCount. 
        /// <para>
        /// The number of active player sessions that are currently being hosted across all instances
        /// in the fleet location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentPlayerSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPlayerSessionCount property is set.
        /// </summary>
        internal bool IsSetCurrentPlayerSessionCount() => this.CurrentPlayerSessionCount.HasValue;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetArn property is set.
        /// </summary>
        internal bool IsSetFleetArn() => this.FleetArn != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet associated with the location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The fleet location for the fleet utilization information, expressed as an Amazon Web
        /// Services Region code, such as <c>us-west-2</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// The maximum number of players allowed across all game sessions that are currently
        /// being hosted across all instances in the fleet location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaximumPlayerSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the MaximumPlayerSessionCount property is set.
        /// </summary>
        internal bool IsSetMaximumPlayerSessionCount() => this.MaximumPlayerSessionCount.HasValue;
    }
}
