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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private string _failureCode;
        private string _failureReason;
        private string _snapshotClusterIdentifier;
        private string _snapshotIdentifier;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code for the error.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The text message describing the error.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotClusterIdentifier. 
        /// <para>
        /// A unique identifier for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotClusterIdentifier
        {
            get { return this._snapshotClusterIdentifier; }
            set { this._snapshotClusterIdentifier = value; }
        }

        // Check to see if SnapshotClusterIdentifier property is set
        internal bool IsSetSnapshotClusterIdentifier()
        {
            return this._snapshotClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot returning the error.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

    }
}