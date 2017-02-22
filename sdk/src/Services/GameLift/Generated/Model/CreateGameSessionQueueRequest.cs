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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGameSessionQueue operation.
    /// Establishes a new queue for processing requests for new game sessions. A queue identifies
    /// where new game sessions can be hosted--by specifying a list of fleet destinations--and
    /// how long a request can remain in the queue waiting to be placed before timing out.
    /// Requests for new game sessions are added to a queue by calling <a>StartGameSessionPlacement</a>
    /// and referencing the queue name.
    /// 
    ///  
    /// <para>
    /// When processing a request for a game session, Amazon GameLift tries each destination
    /// in order until it finds one with available resources to host the new game session.
    /// A queue's default order is determined by how destinations are listed. This default
    /// order can be overridden in a game session placement request.
    /// </para>
    ///  
    /// <para>
    /// To create a new queue, provide a name, timeout value, and a list of destinations.
    /// If successful, a new queue object is returned.
    /// </para>
    /// </summary>
    public partial class CreateGameSessionQueueRequest : AmazonGameLiftRequest
    {
        private List<GameSessionQueueDestination> _destinations = new List<GameSessionQueueDestination>();
        private string _name;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// List of fleets that can be used to fulfill game session placement requests in the
        /// queue. Fleets are identified by either a fleet ARN or a fleet alias ARN. Destinations
        /// are listed in default preference order.
        /// </para>
        /// </summary>
        public List<GameSessionQueueDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label that is associated with queue. Queue names must be unique within
        /// each region.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// Maximum time, in seconds, that a new game session placement request remains in the
        /// queue. When a request exceeds this time, the game session placement changes to a TIMED_OUT
        /// status.
        /// </para>
        /// </summary>
        public int TimeoutInSeconds
        {
            get { return this._timeoutInSeconds.GetValueOrDefault(); }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}