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
    /// Container for the parameters to the GetGameSessionLogUrl operation.
    /// Retrieves the location of stored game session logs for a specified game session. When
    /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
    /// S3. Use this URL to download the logs.
    /// 
    ///  <note> 
    /// <para>
    /// See the <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
    /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
    /// are not saved.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetGameSessionLogUrlRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// Unique identifier for the game session to get logs for. Game session ID format is
        /// as follows: "arn:aws:gamelift:&lt;region&gt;::gamesession/fleet-&lt;fleet ID&gt;/&lt;ID
        /// string&gt;". The value of &lt;ID string&gt; is either a custom ID string (if one was
        /// specified when the game session was created) an auto-generated string. 
        /// </para>
        /// </summary>
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

    }
}