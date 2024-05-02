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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the GetSnapshot operation.
    /// Returns information about a specific snapshot.
    /// </summary>
    public partial class GetSnapshotRequest : AmazonRedshiftServerlessRequest
    {
        private string _ownerAccount;
        private string _snapshotArn;
        private string _snapshotName;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The owner Amazon Web Services account of a snapshot shared with another user.
        /// </para>
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot to return.
        /// </para>
        /// </summary>
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot to return.
        /// </para>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

    }
}