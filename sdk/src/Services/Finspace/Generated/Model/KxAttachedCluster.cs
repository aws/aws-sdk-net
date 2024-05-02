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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The structure containing the metadata of the attached clusters.
    /// </summary>
    public partial class KxAttachedCluster
    {
        private string _clusterName;
        private KxClusterStatus _clusterStatus;
        private KxClusterType _clusterType;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A unique name for the attached cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the attached cluster.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING – The cluster is pending creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATING – The cluster creation process is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED – The cluster creation process has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING – The cluster creation process is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING – The cluster is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING – The cluster is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETED – The cluster has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED – The cluster failed to delete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxClusterStatus ClusterStatus
        {
            get { return this._clusterStatus; }
            set { this._clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this._clusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// Specifies the type of cluster. The volume for TP and RDB cluster types will be used
        /// for TP logs.
        /// </para>
        /// </summary>
        public KxClusterType ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

    }
}