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
    /// Container for the parameters to the TerminateGameSession operation.
    /// Ends a game session that's currently in progress. You can use this action to terminate
    /// any game session that isn't in <c>TERMINATED</c> or <c>TERMINATING</c> status. Terminating
    /// a game session is the most efficient way to free up a server process when it's hosting
    /// a game session that's in a bad state or not ending naturally. You can use this action
    /// to terminate a game session that's being hosted on any type of Amazon GameLift fleet
    /// compute, including computes for managed EC2, managed container, and Anywhere fleets.
    /// 
    ///  
    /// <para>
    /// There are two potential methods for terminating a game session:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// With a graceful termination, the Amazon GameLift service prompts the server process
    /// to initiate its normal game session shutdown sequence. This sequence is implemented
    /// in the game server code and might involve a variety of actions to gracefully end a
    /// game session, such as notifying players, and stop the server process. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// With a forceful termination, the Amazon GameLift service takes immediate action to
    /// terminate the game session by stopping the server process. Termination occurs without
    /// the normal game session shutdown sequence. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Request termination for a single game session. Provide the game session ID and the
    /// termination method. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, game session termination is initiated, which includes changing the
    /// game session status to <c>TERMINATING</c>. As a result of this action, and depending
    /// on the implementation of <c>OnProcessTerminate()</c>, the server process either becomes
    /// available to host a new game session, or it's recycled and a new server process started
    /// with availability to host a game session. The game session status is changed to <c>TERMINATED</c>,
    /// with a status reason that indicates the termination method used.
    /// </para>
    /// </summary>
    public partial class TerminateGameSessionRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private TerminationMode _terminationMode;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// A unique identifier for the game session to be terminated. A game session ARN has
        /// the following format: <c>arn:aws:gamelift:&lt;region&gt;::gamesession/&lt;fleet ID&gt;/&lt;custom
        /// ID string or idempotency token&gt;</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string GameSessionId
        {
            get { return this._gameSessionId; }
            set { this._gameSessionId = value; }
        }

        // Check to see if GameSessionId property is set
        internal bool IsSetGameSessionId()
        {
            return this._gameSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationMode. 
        /// <para>
        /// The method to use to terminate the game session. Available methods include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TRIGGER_ON_PROCESS_TERMINATE</c> – Sends an <c>OnProcessTerminate()</c> callback
        /// to the server process to initiate the normal game session shutdown sequence. At a
        /// minimum, the callback method must include a call to the server SDK action <c>ProcessEnding()</c>,
        /// which is how the server process signals that a game session is ending. If the server
        /// process doesn't call <c>ProcessEnding()</c>, this termination method won't be successful.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORCE_TERMINATE</c> – Takes action to stop the server process, using existing
        /// methods to control how server processes run on an Amazon GameLift managed compute.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This method is not available for game sessions that are running on Anywhere fleets
        /// unless the fleet is deployed with the Amazon GameLift Agent. In this scenario, a force
        /// terminate request results in an invalid or bad request exception.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TerminationMode TerminationMode
        {
            get { return this._terminationMode; }
            set { this._terminationMode = value; }
        }

        // Check to see if TerminationMode property is set
        internal bool IsSetTerminationMode()
        {
            return this._terminationMode != null;
        }

    }
}