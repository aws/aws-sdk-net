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
    /// Container for the parameters to the StartDbNode operation.
    /// Starts the specified DB node in a VM cluster.
    /// </summary>
    public partial class StartDbNodeRequest : AmazonOdbRequest
    {
        private string _cloudVmClusterId;
        private string _dbNodeId;

        /// <summary>
        /// Gets and sets the property CloudVmClusterId. 
        /// <para>
        /// The unique identifier of the VM cluster that contains the DB node to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=64)]
        public string CloudVmClusterId
        {
            get { return this._cloudVmClusterId; }
            set { this._cloudVmClusterId = value; }
        }

        // Check to see if CloudVmClusterId property is set
        internal bool IsSetCloudVmClusterId()
        {
            return this._cloudVmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property DbNodeId. 
        /// <para>
        /// The unique identifier of the DB node to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=64)]
        public string DbNodeId
        {
            get { return this._dbNodeId; }
            set { this._dbNodeId = value; }
        }

        // Check to see if DbNodeId property is set
        internal bool IsSetDbNodeId()
        {
            return this._dbNodeId != null;
        }

    }
}