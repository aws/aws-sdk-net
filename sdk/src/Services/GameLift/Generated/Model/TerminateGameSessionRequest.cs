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
    /// Ends a game session that's currently in progress. Use this action to terminate any
    /// game session that isn't in <c>ERROR</c> status. Terminating a game session is the
    /// most efficient way to free up a server process when it's hosting a game session that's
    /// in a bad state or not ending properly. You can use this action to terminate a game
    /// session that's being hosted on any type of Amazon GameLift Servers fleet compute,
    /// including computes for managed EC2, managed container, and Anywhere fleets. The game
    /// server must be integrated with Amazon GameLift Servers server SDK 5.x or greater.
    /// 
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  
    /// <para>
    /// Request termination for a single game session. Provide the game session ID and the
    /// termination mode. There are two potential methods for terminating a game session:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Initiate a graceful termination using the normal game session shutdown sequence. With
    /// this mode, the Amazon GameLift Servers service prompts the server process that's hosting
    /// the game session by calling the server SDK callback method <c>OnProcessTerminate()</c>.
    /// The callback implementation is part of the custom game server code. It might involve
    /// a variety of actions to gracefully end a game session, such as notifying players,
    /// before stopping the server process.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Force an immediate game session termination. With this mode, the Amazon GameLift Servers
    /// service takes action to stop the server process, which ends the game session without
    /// the normal game session shutdown sequence. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, game session termination is initiated. During this activity, the game
    /// session status is changed to <c>TERMINATING</c>. When completed, the server process
    /// that was hosting the game session has been stopped and replaced with a new server
    /// process that's ready to host a new game session. The old game session's status is
    /// changed to <c>TERMINATED</c> with a status reason that indicates the termination method
    /// used.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html">Add
    /// Amazon GameLift Servers to your game server</a> 
    /// </para>
    ///  
    /// <para>
    /// Amazon GameLift Servers server SDK 5 reference guide for <c>OnProcessTerminate()</c>
    /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk5-cpp-initsdk.html">C++</a>)
    /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk5-csharp-initsdk.html">C#</a>)
    /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk5-unreal-initsdk.html">Unreal</a>)
    /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk-go-initsdk.html">Go</a>)
    /// 
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
        /// the following format: <c>arn:aws:gamelift:&lt;location&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;custom ID string or idempotency token&gt;</c>.
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
        ///  <c>TRIGGER_ON_PROCESS_TERMINATE</c> – Prompts the Amazon GameLift Servers service
        /// to send an <c>OnProcessTerminate()</c> callback to the server process and initiate
        /// the normal game session shutdown sequence. The <c>OnProcessTerminate</c> method, which
        /// is implemented in the game server code, must include a call to the server SDK action
        /// <c>ProcessEnding()</c>, which is how the server process signals to Amazon GameLift
        /// Servers that a game session is ending. If the server process doesn't call <c>ProcessEnding()</c>,
        /// the game session termination won't conclude successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORCE_TERMINATE</c> – Prompts the Amazon GameLift Servers service to stop the
        /// server process immediately. Amazon GameLift Servers takes action (depending on the
        /// type of fleet) to shut down the server process without the normal game session shutdown
        /// sequence. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This method is not available for game sessions that are running on Anywhere fleets
        /// unless the fleet is deployed with the Amazon GameLift Servers Agent. In this scenario,
        /// a force terminate request results in an invalid or bad request exception.
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