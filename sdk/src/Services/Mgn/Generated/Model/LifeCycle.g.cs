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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AddedToServiceDateTime. 
        /// <para>
        /// Lifecycle added to service date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string AddedToServiceDateTime { get; set; }

        /// <summary>
        /// Checks to see if the AddedToServiceDateTime property is set.
        /// </summary>
        internal bool IsSetAddedToServiceDateTime() => this.AddedToServiceDateTime != null;

        /// <summary>
        /// Gets and sets the property ElapsedReplicationDuration. 
        /// <para>
        /// Lifecycle elapsed time and duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ElapsedReplicationDuration { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedReplicationDuration property is set.
        /// </summary>
        internal bool IsSetElapsedReplicationDuration() => this.ElapsedReplicationDuration != null;

        /// <summary>
        /// Gets and sets the property FirstByteDateTime. 
        /// <para>
        /// Lifecycle replication initiation date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string FirstByteDateTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstByteDateTime property is set.
        /// </summary>
        internal bool IsSetFirstByteDateTime() => this.FirstByteDateTime != null;

        /// <summary>
        /// Gets and sets the property LastCutover. 
        /// <para>
        /// Lifecycle last Cutover.
        /// </para>
        /// </summary>
        public LifeCycleLastCutover LastCutover { get; set; }

        /// <summary>
        /// Checks to see if the LastCutover property is set.
        /// </summary>
        internal bool IsSetLastCutover() => this.LastCutover != null;

        /// <summary>
        /// Gets and sets the property LastSeenByServiceDateTime. 
        /// <para>
        /// Lifecycle last seen date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string LastSeenByServiceDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenByServiceDateTime property is set.
        /// </summary>
        internal bool IsSetLastSeenByServiceDateTime() => this.LastSeenByServiceDateTime != null;

        /// <summary>
        /// Gets and sets the property LastTest. 
        /// <para>
        /// Lifecycle last Test.
        /// </para>
        /// </summary>
        public LifeCycleLastTest LastTest { get; set; }

        /// <summary>
        /// Checks to see if the LastTest property is set.
        /// </summary>
        internal bool IsSetLastTest() => this.LastTest != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Lifecycle state.
        /// </para>
        /// </summary>
        public LifeCycleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
