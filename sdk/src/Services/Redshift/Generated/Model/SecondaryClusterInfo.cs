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
    /// The AvailabilityZone and ClusterNodes information of the secondary compute unit.
    /// </summary>
    public partial class SecondaryClusterInfo
    {
        private string _availabilityZone;
        private List<ClusterNode> _clusterNodes = AWSConfigs.InitializeCollections ? new List<ClusterNode>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone in which the secondary compute unit of the cluster
        /// is located.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterNodes. 
        /// <para>
        /// The nodes in the secondary compute unit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterNode> ClusterNodes
        {
            get { return this._clusterNodes; }
            set { this._clusterNodes = value; }
        }

        // Check to see if ClusterNodes property is set
        internal bool IsSetClusterNodes()
        {
            return this._clusterNodes != null && (this._clusterNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}