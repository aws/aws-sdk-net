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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Information about the cluster.
    /// </summary>
    public partial class ClusterInformation
    {
        private string _clusterArn;
        private List<ClusterDetails> _clusterDetails = AWSConfigs.InitializeCollections ? new List<ClusterDetails>() : null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The cluster ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterDetails. 
        /// <para>
        /// Details about the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ClusterDetails> ClusterDetails
        {
            get { return this._clusterDetails; }
            set { this._clusterDetails = value; }
        }

        // Check to see if ClusterDetails property is set
        internal bool IsSetClusterDetails()
        {
            return this._clusterDetails != null && (this._clusterDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}