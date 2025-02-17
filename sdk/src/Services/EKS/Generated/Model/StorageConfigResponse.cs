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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Indicates the status of the request to update the block storage capability of your
    /// EKS Auto Mode cluster.
    /// </summary>
    public partial class StorageConfigResponse
    {
        private BlockStorage _blockStorage;

        /// <summary>
        /// Gets and sets the property BlockStorage. 
        /// <para>
        /// Indicates the current configuration of the block storage capability on your EKS Auto
        /// Mode cluster. For example, if the capability is enabled or disabled.
        /// </para>
        /// </summary>
        public BlockStorage BlockStorage
        {
            get { return this._blockStorage; }
            set { this._blockStorage = value; }
        }

        // Check to see if BlockStorage property is set
        internal bool IsSetBlockStorage()
        {
            return this._blockStorage != null;
        }

    }
}