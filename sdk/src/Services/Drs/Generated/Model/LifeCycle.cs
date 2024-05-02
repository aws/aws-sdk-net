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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object representing the Source Server Lifecycle.
    /// </summary>
    public partial class LifeCycle
    {
        private string _addedToServiceDateTime;
        private string _elapsedReplicationDuration;
        private string _firstByteDateTime;
        private LifeCycleLastLaunch _lastLaunch;
        private string _lastSeenByServiceDateTime;

        /// <summary>
        /// Gets and sets the property AddedToServiceDateTime. 
        /// <para>
        /// The date and time of when the Source Server was added to the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string AddedToServiceDateTime
        {
            get { return this._addedToServiceDateTime; }
            set { this._addedToServiceDateTime = value; }
        }

        // Check to see if AddedToServiceDateTime property is set
        internal bool IsSetAddedToServiceDateTime()
        {
            return this._addedToServiceDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ElapsedReplicationDuration. 
        /// <para>
        /// The amount of time that the Source Server has been replicating for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ElapsedReplicationDuration
        {
            get { return this._elapsedReplicationDuration; }
            set { this._elapsedReplicationDuration = value; }
        }

        // Check to see if ElapsedReplicationDuration property is set
        internal bool IsSetElapsedReplicationDuration()
        {
            return this._elapsedReplicationDuration != null;
        }

        /// <summary>
        /// Gets and sets the property FirstByteDateTime. 
        /// <para>
        /// The date and time of the first byte that was replicated from the Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string FirstByteDateTime
        {
            get { return this._firstByteDateTime; }
            set { this._firstByteDateTime = value; }
        }

        // Check to see if FirstByteDateTime property is set
        internal bool IsSetFirstByteDateTime()
        {
            return this._firstByteDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property LastLaunch. 
        /// <para>
        /// An object containing information regarding the last launch of the Source Server.
        /// </para>
        /// </summary>
        public LifeCycleLastLaunch LastLaunch
        {
            get { return this._lastLaunch; }
            set { this._lastLaunch = value; }
        }

        // Check to see if LastLaunch property is set
        internal bool IsSetLastLaunch()
        {
            return this._lastLaunch != null;
        }

        /// <summary>
        /// Gets and sets the property LastSeenByServiceDateTime. 
        /// <para>
        /// The date and time this Source Server was last seen by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string LastSeenByServiceDateTime
        {
            get { return this._lastSeenByServiceDateTime; }
            set { this._lastSeenByServiceDateTime = value; }
        }

        // Check to see if LastSeenByServiceDateTime property is set
        internal bool IsSetLastSeenByServiceDateTime()
        {
            return this._lastSeenByServiceDateTime != null;
        }

    }
}