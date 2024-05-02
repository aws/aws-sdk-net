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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
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
namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshot operation.
    /// Creates a snapshot of the specified simulation. A snapshot is a file that contains
    /// simulation state data at a specific time. The state data saved in a snapshot includes
    /// entity data from the State Fabric, the simulation configuration specified in the schema,
    /// and the clock tick number. You can use the snapshot to initialize a new simulation.
    /// For more information about snapshots, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/working-with_snapshots.html">Snapshots</a>
    /// in the <i>SimSpace Weaver User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// You specify a <c>Destination</c> when you create a snapshot. The <c>Destination</c>
    /// is the name of an Amazon S3 bucket and an optional <c>ObjectKeyPrefix</c>. The <c>ObjectKeyPrefix</c>
    /// is usually the name of a folder in the bucket. SimSpace Weaver creates a <c>snapshot</c>
    /// folder inside the <c>Destination</c> and places the snapshot file there.
    /// </para>
    ///  
    /// <para>
    /// The snapshot file is an Amazon S3 object. It has an object key with the form: <c>
    /// <i>object-key-prefix</i>/snapshot/<i>simulation-name</i>-<i>YYMMdd</i>-<i>HHmm</i>-<i>ss</i>.zip</c>,
    /// where: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c> <i>YY</i> </c> is the 2-digit year
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <i>MM</i> </c> is the 2-digit month
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <i>dd</i> </c> is the 2-digit day of the month
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <i>HH</i> </c> is the 2-digit hour (24-hour clock)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <i>mm</i> </c> is the 2-digit minutes
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <i>ss</i> </c> is the 2-digit seconds
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSnapshotRequest : AmazonSimSpaceWeaverRequest
    {
        private S3Destination _destination;
        private string _simulation;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon S3 bucket and optional folder (object key prefix) where SimSpace Weaver
        /// creates the snapshot file.
        /// </para>
        ///  
        /// <para>
        /// The Amazon S3 bucket must be in the same Amazon Web Services Region as the simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Simulation. 
        /// <para>
        /// The name of the simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Simulation
        {
            get { return this._simulation; }
            set { this._simulation = value; }
        }

        // Check to see if Simulation property is set
        internal bool IsSetSimulation()
        {
            return this._simulation != null;
        }

    }
}