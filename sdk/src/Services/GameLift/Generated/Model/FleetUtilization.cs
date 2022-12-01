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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Current resource utilization statistics in a specified fleet or location. The location
    /// value might refer to a fleet's remote location or its home Region.
    /// 
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    /// </summary>
    public partial class FleetUtilization
    {
        private int? _activeGameSessionCount;
        private int? _activeServerProcessCount;
        private int? _currentPlayerSessionCount;
        private string _fleetArn;
        private string _fleetId;
        private string _location;
        private int? _maximumPlayerSessionCount;

        /// <summary>
        /// Gets and sets the property ActiveGameSessionCount. 
        /// <para>
        /// The number of active game sessions that are currently being hosted across all instances
        /// in the fleet location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ActiveGameSessionCount
        {
            get { return this._activeGameSessionCount.GetValueOrDefault(); }
            set { this._activeGameSessionCount = value; }
        }

        // Check to see if ActiveGameSessionCount property is set
        internal bool IsSetActiveGameSessionCount()
        {
            return this._activeGameSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActiveServerProcessCount. 
        /// <para>
        /// The number of server processes in <code>ACTIVE</code> status that are currently running
        /// across all instances in the fleet location. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ActiveServerProcessCount
        {
            get { return this._activeServerProcessCount.GetValueOrDefault(); }
            set { this._activeServerProcessCount = value; }
        }

        // Check to see if ActiveServerProcessCount property is set
        internal bool IsSetActiveServerProcessCount()
        {
            return this._activeServerProcessCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentPlayerSessionCount. 
        /// <para>
        /// The number of active player sessions that are currently being hosted across all instances
        /// in the fleet location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int CurrentPlayerSessionCount
        {
            get { return this._currentPlayerSessionCount.GetValueOrDefault(); }
            set { this._currentPlayerSessionCount = value; }
        }

        // Check to see if CurrentPlayerSessionCount property is set
        internal bool IsSetCurrentPlayerSessionCount()
        {
            return this._currentPlayerSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a GameLift fleet resource and uniquely identifies it. ARNs are
        /// unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</code>.
        /// </para>
        /// </summary>
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet associated with the location.
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
        /// Gets and sets the property Location. 
        /// <para>
        /// The fleet location for the fleet utilization information, expressed as an Amazon Web
        /// Services Region code, such as <code>us-west-2</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// The maximum number of players allowed across all game sessions that are currently
        /// being hosted across all instances in the fleet location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaximumPlayerSessionCount
        {
            get { return this._maximumPlayerSessionCount.GetValueOrDefault(); }
            set { this._maximumPlayerSessionCount = value; }
        }

        // Check to see if MaximumPlayerSessionCount property is set
        internal bool IsSetMaximumPlayerSessionCount()
        {
            return this._maximumPlayerSessionCount.HasValue; 
        }

    }
}