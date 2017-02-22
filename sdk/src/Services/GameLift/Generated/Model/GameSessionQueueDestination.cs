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
    /// Fleet designated in a game session queue. Requests for new game sessions in the queue
    /// are fulfilled by starting a new game session on any destination listed for a queue.
    /// </summary>
    public partial class GameSessionQueueDestination
    {
        private string _destinationArn;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) assigned to fleet or fleet alias. ARNs, which include a
        /// fleet ID or alias ID and a region name, provide a unique identifier across all regions.
        /// 
        /// </para>
        /// </summary>
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

    }
}