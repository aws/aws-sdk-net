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
    /// This is the response object from the StartGameSessionPlacement operation.
    /// </summary>
    public partial class StartGameSessionPlacementResponse : AmazonWebServiceResponse
    {
        private GameSessionPlacement _gameSessionPlacement;

        /// <summary>
        /// Gets and sets the property GameSessionPlacement. 
        /// <para>
        /// Object that describes the newly created game session placement. This object includes
        /// all the information provided in the request, as well as start/end time stamps and
        /// placement status. 
        /// </para>
        /// </summary>
        public GameSessionPlacement GameSessionPlacement
        {
            get { return this._gameSessionPlacement; }
            set { this._gameSessionPlacement = value; }
        }

        // Check to see if GameSessionPlacement property is set
        internal bool IsSetGameSessionPlacement()
        {
            return this._gameSessionPlacement != null;
        }

    }
}