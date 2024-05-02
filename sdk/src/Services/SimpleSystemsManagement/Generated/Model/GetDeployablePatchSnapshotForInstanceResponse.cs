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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetDeployablePatchSnapshotForInstance operation.
    /// </summary>
    public partial class GetDeployablePatchSnapshotForInstanceResponse : AmazonWebServiceResponse
    {
        private string _instanceId;
        private string _product;
        private string _snapshotDownloadUrl;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// Returns the specific operating system (for example Windows Server 2012 or Amazon Linux
        /// 2015.09) on the managed node for the specified patch snapshot.
        /// </para>
        /// </summary>
        public string Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        // Check to see if Product property is set
        internal bool IsSetProduct()
        {
            return this._product != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotDownloadUrl. 
        /// <para>
        /// A pre-signed Amazon Simple Storage Service (Amazon S3) URL that can be used to download
        /// the patch snapshot.
        /// </para>
        /// </summary>
        public string SnapshotDownloadUrl
        {
            get { return this._snapshotDownloadUrl; }
            set { this._snapshotDownloadUrl = value; }
        }

        // Check to see if SnapshotDownloadUrl property is set
        internal bool IsSetSnapshotDownloadUrl()
        {
            return this._snapshotDownloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The user-defined snapshot ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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