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
    /// Container for the parameters to the DisassociateVirtualMachinesFromExadbVmCluster operation.
    /// Removes virtual machines from the specified Exascale VM cluster.
    /// </summary>
    public partial class DisassociateVirtualMachinesFromExadbVmClusterRequest : AmazonOdbRequest
    {
        private List<string> _dbNodeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _exadbVmClusterId;

        /// <summary>
        /// Gets and sets the property DbNodeIds. 
        /// <para>
        /// The list of DB node IDs to remove from the Exascale VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DbNodeIds
        {
            get { return this._dbNodeIds; }
            set { this._dbNodeIds = value; }
        }

        // Check to see if DbNodeIds property is set
        internal bool IsSetDbNodeIds()
        {
            return this._dbNodeIds != null && (this._dbNodeIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExadbVmClusterId. 
        /// <para>
        /// The unique identifier of the Exascale VM cluster to remove virtual machines from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string ExadbVmClusterId
        {
            get { return this._exadbVmClusterId; }
            set { this._exadbVmClusterId = value; }
        }

        // Check to see if ExadbVmClusterId property is set
        internal bool IsSetExadbVmClusterId()
        {
            return this._exadbVmClusterId != null;
        }

    }
}