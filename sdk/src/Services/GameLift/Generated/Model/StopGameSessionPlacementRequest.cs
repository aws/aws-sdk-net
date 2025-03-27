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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the StopGameSessionPlacement operation.
    /// Cancels a game session placement that's in <c>PENDING</c> status. To stop a placement,
    /// provide the placement ID value. 
    /// 
    ///  
    /// <para>
    /// Results
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation removes the placement request from the queue and moves
    /// the <c>GameSessionPlacement</c> to <c>CANCELLED</c> status.
    /// </para>
    ///  
    /// <para>
    /// This operation results in an <c>InvalidRequestExecption</c> (400) error if a game
    /// session has already been created for this placement. You can clean up an unneeded
    /// game session by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_TerminateGameSession">TerminateGameSession</a>.
    /// </para>
    /// </summary>
    public partial class StopGameSessionPlacementRequest : AmazonGameLiftRequest
    {
        private string _placementId;

        /// <summary>
        /// Gets and sets the property PlacementId. 
        /// <para>
        /// A unique identifier for a game session placement to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string PlacementId
        {
            get { return this._placementId; }
            set { this._placementId = value; }
        }

        // Check to see if PlacementId property is set
        internal bool IsSetPlacementId()
        {
            return this._placementId != null;
        }

    }
}