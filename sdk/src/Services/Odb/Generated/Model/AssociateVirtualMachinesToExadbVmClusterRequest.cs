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
    /// Container for the parameters to the AssociateVirtualMachinesToExadbVmCluster operation.
    /// Adds virtual machines to the specified Exascale VM cluster.
    /// </summary>
    public partial class AssociateVirtualMachinesToExadbVmClusterRequest : AmazonOdbRequest
    {
        private int? _desiredNodeCount;
        private string _exadbVmClusterId;

        /// <summary>
        /// Gets and sets the property DesiredNodeCount. 
        /// <para>
        /// The desired number of nodes in the Exascale VM cluster after the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? DesiredNodeCount
        {
            get { return this._desiredNodeCount; }
            set { this._desiredNodeCount = value; }
        }

        // Check to see if DesiredNodeCount property is set
        internal bool IsSetDesiredNodeCount()
        {
            return this._desiredNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExadbVmClusterId. 
        /// <para>
        /// The unique identifier of the Exascale VM cluster to add virtual machines to.
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