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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Lifecycle.
    /// </summary>
    public partial class LifeCycle
    {
        private string _addedToServiceDateTime;
        private string _elapsedReplicationDuration;
        private string _firstByteDateTime;
        private LifeCycleLastCutover _lastCutover;
        private string _lastSeenByServiceDateTime;
        private LifeCycleLastTest _lastTest;
        private LifeCycleState _state;

        /// <summary>
        /// Gets and sets the property AddedToServiceDateTime. 
        /// <para>
        /// Lifecycle added to service data and time.
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
        /// Lifecycle elapsed time and duration.
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
        /// Lifecycle replication initiation date and time.
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
        /// Gets and sets the property LastCutover. 
        /// <para>
        /// Lifecycle last Cutover.
        /// </para>
        /// </summary>
        public LifeCycleLastCutover LastCutover
        {
            get { return this._lastCutover; }
            set { this._lastCutover = value; }
        }

        // Check to see if LastCutover property is set
        internal bool IsSetLastCutover()
        {
            return this._lastCutover != null;
        }

        /// <summary>
        /// Gets and sets the property LastSeenByServiceDateTime. 
        /// <para>
        /// Lifecycle last seen date and time.
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

        /// <summary>
        /// Gets and sets the property LastTest. 
        /// <para>
        /// Lifecycle last Test.
        /// </para>
        /// </summary>
        public LifeCycleLastTest LastTest
        {
            get { return this._lastTest; }
            set { this._lastTest = value; }
        }

        // Check to see if LastTest property is set
        internal bool IsSetLastTest()
        {
            return this._lastTest != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Lifecycle state.
        /// </para>
        /// </summary>
        public LifeCycleState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}