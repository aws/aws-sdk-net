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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the errors returned by a snapshot.
    /// </summary>
    public partial class SnapshotErrorMessage
    {
        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code for the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The text message describing the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property SnapshotClusterIdentifier. 
        /// <para>
        /// A unique identifier for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotClusterIdentifier() => this.SnapshotClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot returning the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotIdentifier() => this.SnapshotIdentifier != null;
    }
}
