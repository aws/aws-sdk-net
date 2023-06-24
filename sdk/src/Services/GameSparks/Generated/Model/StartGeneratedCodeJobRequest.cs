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
    /// Container for the parameters to the StartGeneratedCodeJob operation.
    /// Starts an asynchronous process that generates client code for system-defined and
    /// custom messages. The resulting code is collected as a .zip file and uploaded to a
    /// pre-signed Amazon S3 URL.
    /// </summary>
    public partial class StartGeneratedCodeJobRequest : AmazonGameSparksRequest
    {
        private string _gameName;
        private Generator _generator;
        private string _snapshotId;

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
        /// Gets and sets the property Generator. 
        /// <para>
        /// Properties of the generator to use for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Generator Generator
        {
            get { return this._generator; }
            set { this._generator = value; }
        }

        // Check to see if Generator property is set
        internal bool IsSetGenerator()
        {
            return this._generator != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The identifier of the snapshot for which to generate code.
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

    }
}