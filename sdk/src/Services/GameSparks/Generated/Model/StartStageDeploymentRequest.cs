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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Container for the parameters to the StartStageDeployment operation.
    /// Deploys a snapshot to the stage and creates a new game runtime.
    /// 
    ///  
    /// <para>
    ///  After you call this operation, you can check the deployment status by using <code>GetStageDeployment</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  If there are any players connected to the previous game runtime, then both runtimes
    /// persist. Existing connections to the previous runtime are maintained. When players
    /// disconnect and reconnect, they connect to the new runtime. After there are no connections
    /// to the previous game runtime, it is deleted. 
    /// </para>
    /// </summary>
    public partial class StartStageDeploymentRequest : AmazonGameSparksRequest
    {
        private string _clientToken;
        private string _gameName;
        private string _snapshotId;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A client-defined token. With an active client token in the request, this action is
        /// idempotent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=126)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property GameName. 
        /// <para>
        /// The name of the game.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string GameName
        {
            get { return this._gameName; }
            set { this._gameName = value; }
        }

        // Check to see if GameName property is set
        internal bool IsSetGameName()
        {
            return this._gameName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The identifier of the snapshot to deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=33, Max=36)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage to deploy the snapshot onto.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}