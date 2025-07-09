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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOdbNetwork operation.
    /// Deletes the specified ODB network.
    /// </summary>
    public partial class DeleteOdbNetworkRequest : AmazonOdbRequest
    {
        private bool? _deleteAssociatedResources;
        private string _odbNetworkId;

        /// <summary>
        /// Gets and sets the property DeleteAssociatedResources. 
        /// <para>
        /// Specifies whether to delete associated OCI networking resources along with the ODB
        /// network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DeleteAssociatedResources
        {
            get { return this._deleteAssociatedResources; }
            set { this._deleteAssociatedResources = value; }
        }

        // Check to see if DeleteAssociatedResources property is set
        internal bool IsSetDeleteAssociatedResources()
        {
            return this._deleteAssociatedResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string OdbNetworkId
        {
            get { return this._odbNetworkId; }
            set { this._odbNetworkId = value; }
        }

        // Check to see if OdbNetworkId property is set
        internal bool IsSetOdbNetworkId()
        {
            return this._odbNetworkId != null;
        }

    }
}