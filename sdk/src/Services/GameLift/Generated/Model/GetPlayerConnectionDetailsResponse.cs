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
    /// This is the response object from the GetPlayerConnectionDetails operation.
    /// </summary>
    public partial class GetPlayerConnectionDetailsResponse : AmazonWebServiceResponse
    {
        private string _gameSessionId;
        private List<PlayerConnectionDetail> _playerConnectionDetails = AWSConfigs.InitializeCollections ? new List<PlayerConnectionDetail>() : null;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// A unique identifier for the game session for which the player connection details were
        /// retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property PlayerConnectionDetails. 
        /// <para>
        /// A collection of player connection detail objects, one for each requested player.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<PlayerConnectionDetail> PlayerConnectionDetails
        {
            get { return this._playerConnectionDetails; }
            set { this._playerConnectionDetails = value; }
        }

        // Check to see if PlayerConnectionDetails property is set
        internal bool IsSetPlayerConnectionDetails()
        {
            return this._playerConnectionDetails != null && (this._playerConnectionDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}